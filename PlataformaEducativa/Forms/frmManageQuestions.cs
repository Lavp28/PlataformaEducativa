/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 18/5/2026
 * Time: 10:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PlataformaEducativa.DAL;
using PlataformaEducativa.Models;

namespace PlataformaEducativa.Forms
{
    public partial class frmManageQuestions : Form
    {
        private int selectedQuestionId = -1;
        private int selectedModuleId = -1;

        public frmManageQuestions()
        {
            InitializeComponent();
            CargarModulos();
            AplicarIdioma();
        }

        private void CargarModulos()
        {
            DataTable dt = ModuleDAL.GetAllModules();
            cmbModulos.DataSource = dt;
            cmbModulos.DisplayMember = "ModuleName_Es";
            cmbModulos.ValueMember = "ModuleID";
            if (dt.Rows.Count > 0)
                cmbModulos.SelectedIndex = 0;
        }

        private void cmbModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModulos.SelectedValue != null)
            {
                selectedModuleId = Convert.ToInt32(cmbModulos.SelectedValue);
                CargarPreguntas();
            }
        }

        private void CargarPreguntas()
        {
            DataTable dt = QuestionDAL.GetQuestionsByModule(selectedModuleId);
            dgvPreguntas.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgvPreguntas.Columns["QuestionID"].Visible = false;
                dgvPreguntas.Columns["QuestionText_Es"].HeaderText = LanguageManager.GetText("question_es");
                dgvPreguntas.Columns["QuestionText_En"].HeaderText = LanguageManager.GetText("question_en");
            }
            LimpiarFormulario();
        }

        private void dgvPreguntas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPreguntas.CurrentRow != null)
            {
                selectedQuestionId = Convert.ToInt32(dgvPreguntas.CurrentRow.Cells["QuestionID"].Value);
                txtPreguntaEs.Text = dgvPreguntas.CurrentRow.Cells["QuestionText_Es"].Value.ToString();
                txtPreguntaEn.Text = dgvPreguntas.CurrentRow.Cells["QuestionText_En"].Value.ToString();
                if (dgvPreguntas.CurrentRow.Cells["ImagePath"].Value != DBNull.Value)
                    txtImagePath.Text = dgvPreguntas.CurrentRow.Cells["ImagePath"].Value.ToString();
                else
                    txtImagePath.Clear();

                Question q = QuestionDAL.GetQuestionWithOptions(selectedQuestionId);
                if (q != null)
                {
                    for (int i = 0; i < q.Options.Count && i < 4; i++)
                    {
                        txtOpcionEs[i].Text = q.Options[i].Text_Es;
                        txtOpcionEn[i].Text = q.Options[i].Text_En;
                        rbCorrecta[i].Checked = q.Options[i].IsCorrect;
                    }
                }
            }
        }

        private void btnExaminarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
                txtImagePath.Text = ofd.FileName;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            List<Option> opciones = ObtenerOpciones();
            if (!HayUnaCorrecta(opciones))
            {
                MessageBox.Show(LanguageManager.GetText("select_correct_option"));
                return;
            }
            string imagen = string.IsNullOrEmpty(txtImagePath.Text) ? null : txtImagePath.Text;
            if (QuestionDAL.AddQuestion(selectedModuleId, txtPreguntaEs.Text, txtPreguntaEn.Text, imagen, opciones))
            {
                MessageBox.Show(LanguageManager.GetText("question_added"));
                CargarPreguntas();
                LimpiarFormulario();
            }
            else
                MessageBox.Show(LanguageManager.GetText("error"));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (selectedQuestionId == -1)
            {
                MessageBox.Show(LanguageManager.GetText("select_question"));
                return;
            }
            if (!ValidarCampos()) return;
            List<Option> opciones = ObtenerOpciones();
            if (!HayUnaCorrecta(opciones))
            {
                MessageBox.Show(LanguageManager.GetText("select_correct_option"));
                return;
            }
            string imagen = string.IsNullOrEmpty(txtImagePath.Text) ? null : txtImagePath.Text;
            if (QuestionDAL.UpdateQuestion(selectedQuestionId, txtPreguntaEs.Text, txtPreguntaEn.Text, imagen, opciones))
            {
                MessageBox.Show(LanguageManager.GetText("question_updated"));
                CargarPreguntas();
            }
            else
                MessageBox.Show(LanguageManager.GetText("error"));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedQuestionId == -1)
            {
                MessageBox.Show(LanguageManager.GetText("select_question"));
                return;
            }
            if (MessageBox.Show(LanguageManager.GetText("confirm_delete_question"), LanguageManager.GetText("confirm"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (QuestionDAL.DeleteQuestion(selectedQuestionId))
                {
                    MessageBox.Show(LanguageManager.GetText("question_deleted"));
                    CargarPreguntas();
                }
                else
                    MessageBox.Show(LanguageManager.GetText("error"));
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtPreguntaEs.Text) || string.IsNullOrEmpty(txtPreguntaEn.Text))
            {
                MessageBox.Show(LanguageManager.GetText("fill_question"));
                return false;
            }
            for (int i = 0; i < 4; i++)
            {
                if (string.IsNullOrEmpty(txtOpcionEs[i].Text) || string.IsNullOrEmpty(txtOpcionEn[i].Text))
                {
                    MessageBox.Show(LanguageManager.GetText("fill_all_options"));
                    return false;
                }
            }
            return true;
        }

        private List<Option> ObtenerOpciones()
        {
            List<Option> opts = new List<Option>();
            for (int i = 0; i < 4; i++)
            {
                opts.Add(new Option
                {
                    Text_Es = txtOpcionEs[i].Text,
                    Text_En = txtOpcionEn[i].Text,
                    IsCorrect = rbCorrecta[i].Checked
                });
            }
            return opts;
        }

        private bool HayUnaCorrecta(List<Option> opts)
        {
            foreach (var opt in opts)
                if (opt.IsCorrect) return true;
            return false;
        }

        private void LimpiarFormulario()
        {
            selectedQuestionId = -1;
            txtPreguntaEs.Clear();
            txtPreguntaEn.Clear();
            txtImagePath.Clear();
            for (int i = 0; i < 4; i++)
            {
                txtOpcionEs[i].Clear();
                txtOpcionEn[i].Clear();
                rbCorrecta[i].Checked = false;
            }
        }

        private void AplicarIdioma()
        {
            this.Text = LanguageManager.GetText("manage_questions_title");
            btnAgregar.Text = LanguageManager.GetText("add");
            btnActualizar.Text = LanguageManager.GetText("update");
            btnEliminar.Text = LanguageManager.GetText("delete");
            btnExaminarImagen.Text = LanguageManager.GetText("browse");
            labelModulo.Text = LanguageManager.GetText("module");
            labelPreguntaEs.Text = LanguageManager.GetText("question_es") + ":";
            labelPreguntaEn.Text = LanguageManager.GetText("question_en") + ":";
            labelImagen.Text = LanguageManager.GetText("image_path") + ":";
            for (int i = 0; i < 4; i++)
            {
                labelOpcion[i].Text = LanguageManager.GetText("option") + " " + (i + 1) + ":";
                rbCorrecta[i].Text = LanguageManager.GetText("correct");
            }
        }
    }
}