/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 18/5/2026
 * Time: 10:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PlataformaEducativa.Forms
{
    partial class frmManageUsers
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditarScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();

            // dgvUsuarios
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(20, 120);
            this.dgvUsuarios.Size = new System.Drawing.Size(550, 250);
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

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
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // labels
            this.label1.Text = "Usuario:"; this.label1.Location = new System.Drawing.Point(30, 23); this.label1.AutoSize = true;
            this.label2.Text = "Contraseña:"; this.label2.Location = new System.Drawing.Point(30, 53); this.label2.AutoSize = true;
            this.label3.Text = "Rol:"; this.label3.Location = new System.Drawing.Point(30, 83); this.label3.AutoSize = true;

            // botones
            this.btnCrear.Text = "Crear usuario"; this.btnCrear.Location = new System.Drawing.Point(280, 20); this.btnCrear.Size = new System.Drawing.Size(120, 30);
            this.btnEliminar.Text = "Eliminar seleccionado"; this.btnEliminar.Location = new System.Drawing.Point(280, 60); this.btnEliminar.Size = new System.Drawing.Size(120, 30);
            this.btnEditarScore.Text = "Editar puntaje"; this.btnEditarScore.Location = new System.Drawing.Point(420, 20); this.btnEditarScore.Size = new System.Drawing.Size(120, 30);

            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEditarScore.Click += new System.EventHandler(this.btnEditarScore_Click);

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

            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Text = "Gestionar Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtUser, txtPass;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnCrear, btnEliminar, btnEditarScore;
        private System.Windows.Forms.Label label1, label2, label3;
    }
}