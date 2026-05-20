/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 18/5/2026
 * Time: 10:10 p. m.
 * Hola
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
                if (dgvPreguntas.Columns["QuestionID"] != null) dgvPreguntas.Columns["QuestionID"].Visible = false;
                if (dgvPreguntas.Columns["QuestionText_Es"] != null) dgvPreguntas.Columns["QuestionText_Es"].HeaderText = LanguageManager.GetText("question_es");
                if (dgvPreguntas.Columns["QuestionText_En"] != null) dgvPreguntas.Columns["QuestionText_En"].HeaderText = LanguageManager.GetText("question_en");
            }
            LimpiarFormulario();
        }

        private void dgvPreguntas_SelectionChanged(object sender, EventArgs e)
{
    if (dgvPreguntas.CurrentRow != null)
    {
        selectedQuestionId = Convert.ToInt32(dgvPreguntas.CurrentRow.Cells["QuestionID"].Value);
        
        // Versión compatible con versiones antiguas de C#
        object valEs = dgvPreguntas.CurrentRow.Cells["QuestionText_Es"].Value;
        txtPreguntaEs.Text = (valEs != null) ? valEs.ToString() : "";

        object valEn = dgvPreguntas.CurrentRow.Cells["QuestionText_En"].Value;
        txtPreguntaEn.Text = (valEn != null) ? valEn.ToString() : "";
        
        if (dgvPreguntas.CurrentRow.Cells["ImagePath"].Value != DBNull.Value)
        {
            object valImg = dgvPreguntas.CurrentRow.Cells["ImagePath"].Value;
            txtImagePath.Text = (valImg != null) ? valImg.ToString() : "";
        }
        else
        {
            txtImagePath.Clear();
        }

        Question q = QuestionDAL.GetQuestionWithOptions(selectedQuestionId);
        // Evitamos el uso de ?. y usamos validación tradicional
        if (q != null && q.Options != null)
        {
            // Lógica adicional si fuera necesario
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
            return true;
        }

        private List<Option> ObtenerOpciones()
        {
            // Retorna una lista vacía o valores predeterminados para evitar romper la firma de la capa DAL
            return new List<Option>();
        }

        private void LimpiarFormulario()
        {
            selectedQuestionId = -1;
            txtPreguntaEs.Clear();
            txtPreguntaEn.Clear();
            txtImagePath.Clear();
        }

        private void AplicarIdioma()
        {
            this.Text = LanguageManager.GetText("manage_questions_title") ?? "Gestionar Preguntas";
            
            // Verificaciones de nulos para controles antes de asignar texto
            if (btnAgregar != null) btnAgregar.Text = LanguageManager.GetText("add");
            if (btnActualizar != null) btnActualizar.Text = LanguageManager.GetText("update");
            if (btnEliminar != null) btnEliminar.Text = LanguageManager.GetText("delete");
            if (btnExaminarImagen != null) btnExaminarImagen.Text = LanguageManager.GetText("browse");
            
            // Mapeo seguro con los textos fijos de tu UI (Módulo, Pregunta (Español), Pregunta (Inglés), Imagen (ruta))
            if (labelModulo != null) labelModulo.Text = LanguageManager.GetText("module");
            if (labelPreguntaEs != null) labelPreguntaEs.Text = LanguageManager.GetText("question_es") + ":";
            if (labelPreguntaEn != null) labelPreguntaEn.Text = LanguageManager.GetText("question_en") + ":";
            if (labelImagen != null) labelImagen.Text = LanguageManager.GetText("image_path") + ":";
        }
    }
}