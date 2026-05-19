/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 1:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using PlataformaEducativa.DAL;
using Microsoft.VisualBasic;

namespace PlataformaEducativa.Forms
{
    public partial class frmManageUsers : Form
    {
        private DataGridView dgvUsuarios;
        private TextBox txtUser, txtPass;
        private ComboBox cmbRole;
        private Button btnCrear, btnEliminar, btnEditarScore;
        private Label label1, label2, label3;

        public frmManageUsers()
        {
            InitializeComponent();
            CargarUsuarios();
            AplicarIdioma();
        }

        private void InitializeComponent()
        {
            this.dgvUsuarios = new DataGridView();
            this.txtUser = new TextBox();
            this.txtPass = new TextBox();
            this.cmbRole = new ComboBox();
            this.btnCrear = new Button();
            this.btnEliminar = new Button();
            this.btnEditarScore = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();

            // dgvUsuarios
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(20, 120);
            this.dgvUsuarios.Size = new System.Drawing.Size(550, 250);
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // txtUser
            this.txtUser.Location = new System.Drawing.Point(100, 20);
            this.txtUser.Size = new System.Drawing.Size(150, 20);

            // txtPass
            this.txtPass.Location = new System.Drawing.Point(100, 50);
            this.txtPass.Size = new System.Drawing.Size(150, 20);

            // cmbRole
            this.cmbRole.Items.AddRange(new object[] { "Admin", "Jugador" });
            this.cmbRole.Location = new System.Drawing.Point(100, 80);
            this.cmbRole.Size = new System.Drawing.Size(150, 21);
            this.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;

            // labels
            this.label1.Text = "Usuario:";
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.AutoSize = true;

            this.label2.Text = "Contraseña:";
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.AutoSize = true;

            this.label3.Text = "Rol:";
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.AutoSize = true;

            // btnCrear
            this.btnCrear.Text = "Crear usuario";
            this.btnCrear.Location = new System.Drawing.Point(280, 20);
            this.btnCrear.Size = new System.Drawing.Size(120, 30);
            this.btnCrear.Click += new EventHandler(this.btnCrear_Click);

            // btnEliminar
            this.btnEliminar.Text = "Eliminar seleccionado";
            this.btnEliminar.Location = new System.Drawing.Point(280, 60);
            this.btnEliminar.Size = new System.Drawing.Size(120, 30);
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            // btnEditarScore
            this.btnEditarScore.Text = "Editar puntaje";
            this.btnEditarScore.Location = new System.Drawing.Point(420, 20);
            this.btnEditarScore.Size = new System.Drawing.Size(120, 30);
            this.btnEditarScore.Click += new EventHandler(this.btnEditarScore_Click);

            // Añadir controles
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditarScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);

            // Formulario
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Text = "Gestionar Usuarios";
            this.StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
                MessageBox.Show(LanguageManager.GetText("fill_all_fields"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserDAL.CreateUser(user, pass, role))
            {
                MessageBox.Show(LanguageManager.GetText("user_created"), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                txtUser.Clear();
                txtPass.Clear();
                cmbRole.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(LanguageManager.GetText("user_create_error"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["UserID"].Value);
            string username = dgvUsuarios.CurrentRow.Cells["Username"].Value.ToString();

            if (MessageBox.Show(string.Format(LanguageManager.GetText("confirm_delete_user"), username),
                LanguageManager.GetText("confirm"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (UserDAL.DeleteUser(id))
                {
                    MessageBox.Show(LanguageManager.GetText("user_deleted"), "Éxito");
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show(LanguageManager.GetText("user_delete_error"), "Error");
                }
            }
        }

        private void btnEditarScore_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(LanguageManager.GetText("select_user"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show(LanguageManager.GetText("score_updated"), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show(LanguageManager.GetText("score_update_error"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(nuevoScoreStr))
            {
                MessageBox.Show(LanguageManager.GetText("invalid_score"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}