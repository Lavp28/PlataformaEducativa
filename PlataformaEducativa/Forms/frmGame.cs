using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PlataformaEducativa.Models;
using PlataformaEducativa.DAL;

namespace PlataformaEducativa.Forms
{
    public partial class frmGame : Form
    {
        private User _jugador;
        private int _moduleId;
        private List<int> _preguntasIds;
        private int _currentIndex = 0;
        private Question _currentQuestion;
        private bool _idiomaEspañol = true;

        public frmGame(User jugador, int moduleId)
        {
            InitializeComponent();
            _jugador = jugador;
            _moduleId = moduleId;
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarPreguntasNoRespondidas();
            AplicarIdioma();
        }

        private void AplicarIdioma()
        {
            btnResponder.Text = LanguageManager.GetText("answer");
            btnCambiarIdioma.Text = _idiomaEspañol ? "English" : "Español";
            this.Text = LanguageManager.GetText("game_title");
        }

        private void CargarPreguntasNoRespondidas()
        {
            try
            {
                _preguntasIds = QuestionDAL.GetUnansweredQuestions(_jugador.UserID, _moduleId);
                if (_preguntasIds == null || _preguntasIds.Count == 0)
                {
                    MessageBox.Show(LanguageManager.GetText("no_pending_questions"), LanguageManager.GetText("game_over"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                _currentIndex = 0;
                CargarPreguntaActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.Close();
            }
        }

        private void CargarPreguntaActual()
        {
            try
            {
                if (_currentIndex >= _preguntasIds.Count)
                {
                    MessageBox.Show(LanguageManager.GetText("all_questions_completed"), LanguageManager.GetText("game_over"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                int qid = _preguntasIds[_currentIndex];
                _currentQuestion = QuestionDAL.GetQuestionWithOptions(qid);
                if (_currentQuestion == null)
                {
                    _currentIndex++;
                    CargarPreguntaActual();
                    return;
                }

                lblPregunta.Text = _idiomaEspañol ? _currentQuestion.Text_Es : _currentQuestion.Text_En;

                // Cargar imagen
                try
                {
                    if (!string.IsNullOrEmpty(_currentQuestion.ImagePath) && System.IO.File.Exists(_currentQuestion.ImagePath))
                        picImagen.Image = System.Drawing.Image.FromFile(_currentQuestion.ImagePath);
                    else
                        picImagen.Image = null;
                }
                catch { picImagen.Image = null; }

                var opciones = _currentQuestion.Options;
                RadioButton[] radios = { rbOpcion1, rbOpcion2, rbOpcion3, rbOpcion4 };
                for (int i = 0; i < 4; i++)
                {
                    if (i < opciones.Count)
                    {
                        radios[i].Text = _idiomaEspañol ? opciones[i].Text_Es : opciones[i].Text_En;
                        radios[i].Visible = true;
                    }
                    else radios[i].Visible = false;
                    radios[i].Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.Close();
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton[] radios = { rbOpcion1, rbOpcion2, rbOpcion3, rbOpcion4 };
                int selectedIndex = -1;
                for (int i = 0; i < radios.Length; i++)
                    if (radios[i].Checked) { selectedIndex = i; break; }

                if (selectedIndex == -1)
                {
                    MessageBox.Show(LanguageManager.GetText("select_answer"), LanguageManager.GetText("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool esCorrecta = _currentQuestion.Options[selectedIndex].IsCorrect;
                int scoreActual = UserDAL.GetUserScore(_jugador.UserID);
                int nuevoScore = scoreActual + (esCorrecta ? 10 : -5);
                if (nuevoScore < 0) nuevoScore = 0;
                UserDAL.UpdateScore(_jugador.UserID, nuevoScore);
                QuestionDAL.RegisterAttempt(_jugador.UserID, _currentQuestion.QuestionID, esCorrecta);

                MessageBox.Show(esCorrecta ? LanguageManager.GetText("Respuesta Correcta") : LanguageManager.GetText("Respuesta incorrecta"), LanguageManager.GetText("Resultado"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                _currentIndex++;
                CargarPreguntaActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.Close();
            }
        }

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            _idiomaEspañol = !_idiomaEspañol;
            btnCambiarIdioma.Text = _idiomaEspañol ? "English" : "Español";
            if (_currentQuestion != null)
                CargarPreguntaActual();
        }

        private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (picImagen.Image != null) picImagen.Image.Dispose();
        }
    }
}