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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
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
        	// 
        	// dgvUsuarios
        	// 
        	this.dgvUsuarios.AllowUserToAddRows = false;
        	this.dgvUsuarios.AllowUserToDeleteRows = false;
        	this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
        	this.dgvUsuarios.Location = new System.Drawing.Point(96, 111);
        	this.dgvUsuarios.Name = "dgvUsuarios";
        	this.dgvUsuarios.ReadOnly = true;
        	this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvUsuarios.Size = new System.Drawing.Size(550, 250);
        	this.dgvUsuarios.TabIndex = 0;
        	// 
        	// txtUser
        	// 
        	this.txtUser.Location = new System.Drawing.Point(200, 11);
        	this.txtUser.Name = "txtUser";
        	this.txtUser.Size = new System.Drawing.Size(150, 20);
        	this.txtUser.TabIndex = 1;
        	// 
        	// txtPass
        	// 
        	this.txtPass.Location = new System.Drawing.Point(200, 41);
        	this.txtPass.Name = "txtPass";
        	this.txtPass.Size = new System.Drawing.Size(150, 20);
        	this.txtPass.TabIndex = 2;
        	// 
        	// cmbRole
        	// 
        	this.cmbRole.BackColor = System.Drawing.SystemColors.Window;
        	this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbRole.Items.AddRange(new object[] {
			"Admin",
			"Jugador"});
        	this.cmbRole.Location = new System.Drawing.Point(200, 71);
        	this.cmbRole.Name = "cmbRole";
        	this.cmbRole.Size = new System.Drawing.Size(150, 21);
        	this.cmbRole.TabIndex = 3;
        	// 
        	// btnCrear
        	// 
        	this.btnCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrear.BackgroundImage")));
        	this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.btnCrear.Location = new System.Drawing.Point(356, 11);
        	this.btnCrear.Name = "btnCrear";
        	this.btnCrear.Size = new System.Drawing.Size(120, 30);
        	this.btnCrear.TabIndex = 4;
        	this.btnCrear.Text = "Crear usuario";
        	this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
        	// 
        	// btnEliminar
        	// 
        	this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
        	this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.btnEliminar.Location = new System.Drawing.Point(356, 51);
        	this.btnEliminar.Name = "btnEliminar";
        	this.btnEliminar.Size = new System.Drawing.Size(120, 30);
        	this.btnEliminar.TabIndex = 5;
        	this.btnEliminar.Text = "Eliminar seleccionado";
        	this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
        	// 
        	// btnEditarScore
        	// 
        	this.btnEditarScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarScore.BackgroundImage")));
        	this.btnEditarScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnEditarScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.btnEditarScore.Location = new System.Drawing.Point(496, 11);
        	this.btnEditarScore.Name = "btnEditarScore";
        	this.btnEditarScore.Size = new System.Drawing.Size(120, 30);
        	this.btnEditarScore.TabIndex = 6;
        	this.btnEditarScore.Text = "Editar puntaje";
        	this.btnEditarScore.Click += new System.EventHandler(this.btnEditarScore_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
        	this.label1.Location = new System.Drawing.Point(106, 14);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(54, 13);
        	this.label1.TabIndex = 7;
        	this.label1.Text = "Usuario:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
        	this.label2.Location = new System.Drawing.Point(106, 44);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(75, 13);
        	this.label2.TabIndex = 8;
        	this.label2.Text = "Contraseña:";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
        	this.label3.Location = new System.Drawing.Point(106, 74);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(30, 13);
        	this.label3.TabIndex = 9;
        	this.label3.Text = "Rol:";
        	// 
        	// frmManageUsers
        	// 
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(736, 457);
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
        	this.Name = "frmManageUsers";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Gestionar Usuarios";
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