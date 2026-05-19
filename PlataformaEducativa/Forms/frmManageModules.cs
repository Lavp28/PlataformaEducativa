/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 18/5/2026
 * Time: 10:09 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using PlataformaEducativa.DAL;
using System.Data;

namespace PlataformaEducativa.Forms
{
    public partial class frmManageModules : Form
    {
        private int selectedModuleId = -1;

        public frmManageModules()
        {
            InitializeComponent();
            CargarModulos();
            AplicarIdioma();
        }

        private void CargarModulos()
        {
            DataTable dt = ModuleDAL.GetAllModules();
            dgvModulos.DataSource = dt;
            if (dt.Rows.Count > 0) dgvModulos.Columns["ModuleID"].Visible = false;
        }

        private void dgvModulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModulos.CurrentRow != null)
            {
                selectedModuleId = Convert.ToInt32(dgvModulos.CurrentRow.Cells["ModuleID"].Value);
                txtNombreEs.Text = dgvModulos.CurrentRow.Cells["ModuleName_Es"].Value.ToString();
                txtNombreEn.Text = dgvModulos.CurrentRow.Cells["ModuleName_En"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEs.Text) || string.IsNullOrEmpty(txtNombreEn.Text))
            {
                MessageBox.Show(LanguageManager.GetText("fill_both_names"));
                return;
            }
            if (ModuleDAL.AddModule(txtNombreEs.Text, txtNombreEn.Text))
            {
                MessageBox.Show(LanguageManager.GetText("module_added"));
                Limpiar();
                CargarModulos();
            }
            else MessageBox.Show(LanguageManager.GetText("error"));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (selectedModuleId == -1) { MessageBox.Show(LanguageManager.GetText("select_module")); return; }
            if (ModuleDAL.UpdateModule(selectedModuleId, txtNombreEs.Text, txtNombreEn.Text))
            {
                MessageBox.Show(LanguageManager.GetText("module_updated"));
                CargarModulos();
            }
            else MessageBox.Show(LanguageManager.GetText("error"));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedModuleId == -1) { MessageBox.Show(LanguageManager.GetText("select_module")); return; }
            if (MessageBox.Show(LanguageManager.GetText("confirm_delete_module"), LanguageManager.GetText("confirm"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ModuleDAL.DeleteModule(selectedModuleId))
                {
                    MessageBox.Show(LanguageManager.GetText("module_deleted"));
                    Limpiar();
                    CargarModulos();
                }
                else MessageBox.Show(LanguageManager.GetText("error"));
            }
        }

        private void Limpiar()
        {
            txtNombreEs.Clear();
            txtNombreEn.Clear();
            selectedModuleId = -1;
        }

        private void AplicarIdioma()
        {
            this.Text = LanguageManager.GetText("manage_modules_title");
            btnAgregar.Text = LanguageManager.GetText("add");
            btnActualizar.Text = LanguageManager.GetText("update");
            btnEliminar.Text = LanguageManager.GetText("delete");
            lblNombreEs.Text = LanguageManager.GetText("name_es");
            lblNombreEn.Text = LanguageManager.GetText("name_en");
        }
    }
}