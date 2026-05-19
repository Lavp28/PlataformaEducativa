using System;
using System.Data;
using System.Windows.Forms;
using PlataformaEducativa.DAL;
using Microsoft.VisualBasic;

namespace PlataformaEducativa.Forms
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
            CargarUsuarios();
            AplicarIdioma();
        }

        private void CargarUsuarios()
        {
            DataTable dt = UserDAL.GetAllUsers();
            dgvUsuarios.DataSource = dt;
            if (dt.Rows.Count > 0 && dgvUsuarios.Columns["PasswordHash"] != null)
                dgvUsuarios.Columns["PasswordHash"].Visible = false;
        }

        private void AplicarIdioma()
        {
            this.Text = LanguageManager.GetText("manage_users_title");
            label1.Text = LanguageManager.GetText("username");
            label2.Text = LanguageManager.GetText("password");
            label3.Text = LanguageManager.GetText("role");
            btnCrear.Text = LanguageManager.GetText("create_user");
            btnEliminar.Text = LanguageManager.GetText("delete_user");
            btnEditarScore.Text = LanguageManager.GetText("edit_score");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;
            string role = cmbRole.SelectedItem == null ? "" : cmbRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show(LanguageManager.GetText("fill_all_fields"));
                return;
            }
            if (UserDAL.CreateUser(user, pass, role))
            {
                MessageBox.Show(LanguageManager.GetText("user_created"));
                CargarUsuarios();
                txtUser.Clear();
                txtPass.Clear();
                cmbRole.SelectedIndex = -1;
            }
            else
                MessageBox.Show(LanguageManager.GetText("user_create_error"));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["UserID"].Value);
            string username = dgvUsuarios.CurrentRow.Cells["Username"].Value.ToString();
            if (MessageBox.Show(string.Format(LanguageManager.GetText("confirm_delete_user"), username), LanguageManager.GetText("confirm"), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (UserDAL.DeleteUser(id))
                {
                    MessageBox.Show(LanguageManager.GetText("user_deleted"));
                    CargarUsuarios();
                }
                else
                    MessageBox.Show(LanguageManager.GetText("user_delete_error"));
            }
        }

        private void btnEditarScore_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(LanguageManager.GetText("select_user"));
                return;
            }
            int userId = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["UserID"].Value);
            string username = dgvUsuarios.CurrentRow.Cells["Username"].Value.ToString();
            int currentScore = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Score"].Value);

            string nuevoScoreStr = Interaction.InputBox(
                string.Format(LanguageManager.GetText("enter_new_score"), username),
                LanguageManager.GetText("edit_score_title"),
                currentScore.ToString());

            int nuevoScore;
            if (int.TryParse(nuevoScoreStr, out nuevoScore) && nuevoScore >= 0)
            {
                if (UserDAL.UpdateScore(userId, nuevoScore))
                {
                    MessageBox.Show(LanguageManager.GetText("score_updated"));
                    CargarUsuarios();
                }
                else
                    MessageBox.Show(LanguageManager.GetText("score_update_error"));
            }
            else if (!string.IsNullOrEmpty(nuevoScoreStr))
                MessageBox.Show(LanguageManager.GetText("invalid_score"));
        }
    }
}