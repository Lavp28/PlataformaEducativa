/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 1:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

        // Controles (declarados manualmente)
        private Label lblPregunta;
        private RadioButton rbOpcion1, rbOpcion2, rbOpcion3, rbOpcion4;
        private Button btnResponder, btnCambiarIdioma;
        private PictureBox picImagen;

        public frmGame(User jugador, int moduleId)
        {
            InitializeComponent();
            _jugador = jugador;
            _moduleId = moduleId;
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarPreguntasNoRespondidas();
        }

        private void InitializeComponent()
        {
            this.lblPregunta = new Label();
            this.rbOpcion1 = new RadioButton();
            this.rbOpcion2 = new RadioButton();
            this.rbOpcion3 = new RadioButton();
            this.rbOpcion4 = new RadioButton();
            this.btnResponder = new Button();
            this.btnCambiarIdioma = new Button();
            this.picImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();

            // lblPregunta
            this.lblPregunta.Location = new System.Drawing.Point(20, 20);
            this.lblPregunta.Size = new System.Drawing.Size(450, 60);
            this.lblPregunta.Text = "Pregunta";

            // rbOpcion1
            this.rbOpcion1.Location = new System.Drawing.Point(20, 90);
            this.rbOpcion1.Size = new System.Drawing.Size(200, 20);
            // rbOpcion2
            this.rbOpcion2.Location = new System.Drawing.Point(20, 120);
            this.rbOpcion2.Size = new System.Drawing.Size(200, 20);
            // rbOpcion3
            this.rbOpcion3.Location = new System.Drawing.Point(20, 150);
            this.rbOpcion3.Size = new System.Drawing.Size(200, 20);
            // rbOpcion4
            this.rbOpcion4.Location = new System.Drawing.Point(20, 180);
            this.rbOpcion4.Size = new System.Drawing.Size(200, 20);

            // btnResponder
            this.btnResponder.Location = new System.Drawing.Point(20, 230);
            this.btnResponder.Size = new System.Drawing.Size(100, 30);
            this.btnResponder.Text = "Responder";
            this.btnResponder.Click += new EventHandler(this.btnResponder_Click);

            // btnCambiarIdioma
            this.btnCambiarIdioma.Location = new System.Drawing.Point(140, 230);
            this.btnCambiarIdioma.Size = new System.Drawing.Size(100, 30);
            this.btnCambiarIdioma.Text = "English";
            this.btnCambiarIdioma.Click += new EventHandler(this.btnCambiarIdioma_Click);

            // picImagen
            this.picImagen.Location = new System.Drawing.Point(300, 90);
            this.picImagen.Size = new System.Drawing.Size(150, 120);
            this.picImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            // frmGame
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.btnCambiarIdioma);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rbOpcion4);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.lblPregunta);
            this.Text = "Responder preguntas";
            this.FormClosed += new FormClosedEventHandler(this.frmGame_FormClosed);

            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
        }

        private void CargarPreguntasNoRespondidas()
        {
            try
            {
                _preguntasIds = QuestionDAL.GetUnansweredQuestions(_jugador.UserID, _moduleId);
                if (_preguntasIds == null || _preguntasIds.Count == 0)
                {
                    MessageBox.Show("No hay preguntas pendientes en este módulo. ¡Felicidades!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                _currentIndex = 0;
                CargarPreguntaActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar preguntas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CargarPreguntaActual()
        {
            try
            {
                if (_currentIndex >= _preguntasIds.Count)
                {
                    MessageBox.Show("¡Has completado todas las preguntas del módulo!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // Mostrar texto según idioma
                lblPregunta.Text = _idiomaEspañol ? _currentQuestion.Text_Es : _currentQuestion.Text_En;

                // Cargar imagen
                try
                {
                    if (!string.IsNullOrEmpty(_currentQuestion.ImagePath) && System.IO.File.Exists(_currentQuestion.ImagePath))
                        picImagen.Image = System.Drawing.Image.FromFile(_currentQuestion.ImagePath);
                    else
                        picImagen.Image = null;
                }
                catch (Exception ex)
                {
                    picImagen.Image = null;
                    Console.WriteLine("Error cargando imagen: " + ex.Message);
                }

                // Cargar opciones (4 como máximo)
                var opciones = _currentQuestion.Options;
                RadioButton[] radios = { rbOpcion1, rbOpcion2, rbOpcion3, rbOpcion4 };
                for (int i = 0; i < 4; i++)
                {
                    if (i < opciones.Count)
                    {
                        string texto = _idiomaEspañol ? opciones[i].Text_Es : opciones[i].Text_En;
                        radios[i].Text = texto;
                        radios[i].Visible = true;
                    }
                    else
                    {
                        radios[i].Visible = false;
                    }
                    radios[i].Checked = false;
                }

                // Limpiar selección
                foreach (var rb in radios) rb.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la pregunta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                {
                    if (radios[i].Checked) { selectedIndex = i; break; }
                }

                if (selectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una respuesta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool esCorrecta = _currentQuestion.Options[selectedIndex].IsCorrect;
                int scoreActual = UserDAL.GetUserScore(_jugador.UserID);
                int nuevoScore = scoreActual + (esCorrecta ? 10 : -5);
                if (nuevoScore < 0) nuevoScore = 0;
                UserDAL.UpdateScore(_jugador.UserID, nuevoScore);
                QuestionDAL.RegisterAttempt(_jugador.UserID, _currentQuestion.QuestionID, esCorrecta);

                MessageBox.Show(esCorrecta ? "¡Correcto! +10 puntos" : "Incorrecto. -5 puntos", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _currentIndex++;
                CargarPreguntaActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la respuesta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Liberar recursos de imagen para evitar memory leak
            if (picImagen.Image != null)
            {
                picImagen.Image.Dispose();
                picImagen.Image = null;
            }
        }
    }
}