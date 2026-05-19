/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 12:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using PlataformaEducativa.DAL;
using PlataformaEducativa.Models;

namespace PlataformaEducativa.Forms
{
    public partial class FormLogin : Form
    {
        // Controles
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEspanol;
        private System.Windows.Forms.RadioButton rbIngles;

        public FormLogin()
        {
            InitializeComponent();
            AplicarIdioma(); // Aplica el idioma por defecto (español)
        }

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
        	this.txtUsername = new System.Windows.Forms.TextBox();
        	this.txtPassword = new System.Windows.Forms.TextBox();
        	this.btnLogin = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.rbEspanol = new System.Windows.Forms.RadioButton();
        	this.rbIngles = new System.Windows.Forms.RadioButton();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	this.pictureBox3 = new System.Windows.Forms.PictureBox();
        	this.pictureBox4 = new System.Windows.Forms.PictureBox();
        	this.pictureBox5 = new System.Windows.Forms.PictureBox();
        	this.pictureBox6 = new System.Windows.Forms.PictureBox();
        	this.pictureBox7 = new System.Windows.Forms.PictureBox();
        	this.pictureBox8 = new System.Windows.Forms.PictureBox();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// txtUsername
        	// 
        	this.txtUsername.Location = new System.Drawing.Point(246, 42);
        	this.txtUsername.Name = "txtUsername";
        	this.txtUsername.Size = new System.Drawing.Size(150, 20);
        	this.txtUsername.TabIndex = 0;
        	// 
        	// txtPassword
        	// 
        	this.txtPassword.Location = new System.Drawing.Point(246, 94);
        	this.txtPassword.Name = "txtPassword";
        	this.txtPassword.PasswordChar = '*';
        	this.txtPassword.Size = new System.Drawing.Size(150, 20);
        	this.txtPassword.TabIndex = 1;
        	// 
        	// btnLogin
        	// 
        	this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnLogin.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnLogin.ForeColor = System.Drawing.Color.Black;
        	this.btnLogin.Location = new System.Drawing.Point(265, 137);
        	this.btnLogin.Name = "btnLogin";
        	this.btnLogin.Size = new System.Drawing.Size(118, 33);
        	this.btnLogin.TabIndex = 2;
        	this.btnLogin.Text = "Ingresar";
        	this.btnLogin.UseVisualStyleBackColor = true;
        	this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.BackColor = System.Drawing.Color.Transparent;
        	this.label1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.Black;
        	this.label1.Location = new System.Drawing.Point(50, 37);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(123, 33);
        	this.label1.TabIndex = 6;
        	this.label1.Text = "Usuario:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.BackColor = System.Drawing.Color.Transparent;
        	this.label2.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold);
        	this.label2.ForeColor = System.Drawing.Color.Black;
        	this.label2.Location = new System.Drawing.Point(50, 89);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(168, 33);
        	this.label2.TabIndex = 5;
        	this.label2.Text = "Contraseña:";
        	// 
        	// rbEspanol
        	// 
        	this.rbEspanol.AutoSize = true;
        	this.rbEspanol.BackColor = System.Drawing.Color.Transparent;
        	this.rbEspanol.Checked = true;
        	this.rbEspanol.ForeColor = System.Drawing.Color.White;
        	this.rbEspanol.Image = ((System.Drawing.Image)(resources.GetObject("rbEspanol.Image")));
        	this.rbEspanol.Location = new System.Drawing.Point(306, 192);
        	this.rbEspanol.Name = "rbEspanol";
        	this.rbEspanol.Size = new System.Drawing.Size(62, 32);
        	this.rbEspanol.TabIndex = 3;
        	this.rbEspanol.TabStop = true;
        	this.rbEspanol.UseVisualStyleBackColor = false;
        	this.rbEspanol.CheckedChanged += new System.EventHandler(this.rbIdioma_CheckedChanged);
        	// 
        	// rbIngles
        	// 
        	this.rbIngles.AutoSize = true;
        	this.rbIngles.BackColor = System.Drawing.Color.Transparent;
        	this.rbIngles.ForeColor = System.Drawing.Color.White;
        	this.rbIngles.Image = ((System.Drawing.Image)(resources.GetObject("rbIngles.Image")));
        	this.rbIngles.Location = new System.Drawing.Point(385, 196);
        	this.rbIngles.Name = "rbIngles";
        	this.rbIngles.Size = new System.Drawing.Size(62, 25);
        	this.rbIngles.TabIndex = 4;
        	this.rbIngles.UseVisualStyleBackColor = false;
        	this.rbIngles.CheckedChanged += new System.EventHandler(this.rbIdioma_CheckedChanged);
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(12, 88);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(32, 34);
        	this.pictureBox1.TabIndex = 7;
        	this.pictureBox1.TabStop = false;
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
        	this.pictureBox2.Location = new System.Drawing.Point(12, 37);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(32, 37);
        	this.pictureBox2.TabIndex = 8;
        	this.pictureBox2.TabStop = false;
        	// 
        	// pictureBox3
        	// 
        	this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
        	this.pictureBox3.Location = new System.Drawing.Point(393, 140);
        	this.pictureBox3.Name = "pictureBox3";
        	this.pictureBox3.Size = new System.Drawing.Size(54, 50);
        	this.pictureBox3.TabIndex = 9;
        	this.pictureBox3.TabStop = false;
        	// 
        	// pictureBox4
        	// 
        	this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
        	this.pictureBox4.Location = new System.Drawing.Point(12, 154);
        	this.pictureBox4.Name = "pictureBox4";
        	this.pictureBox4.Size = new System.Drawing.Size(80, 70);
        	this.pictureBox4.TabIndex = 10;
        	this.pictureBox4.TabStop = false;
        	// 
        	// pictureBox5
        	// 
        	this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
        	this.pictureBox5.Location = new System.Drawing.Point(215, 176);
        	this.pictureBox5.Name = "pictureBox5";
        	this.pictureBox5.Size = new System.Drawing.Size(63, 59);
        	this.pictureBox5.TabIndex = 11;
        	this.pictureBox5.TabStop = false;
        	// 
        	// pictureBox6
        	// 
        	this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
        	this.pictureBox6.Location = new System.Drawing.Point(173, 180);
        	this.pictureBox6.Name = "pictureBox6";
        	this.pictureBox6.Size = new System.Drawing.Size(55, 50);
        	this.pictureBox6.TabIndex = 12;
        	this.pictureBox6.TabStop = false;
        	// 
        	// pictureBox7
        	// 
        	this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
        	this.pictureBox7.Location = new System.Drawing.Point(193, 24);
        	this.pictureBox7.Name = "pictureBox7";
        	this.pictureBox7.Size = new System.Drawing.Size(25, 28);
        	this.pictureBox7.TabIndex = 13;
        	this.pictureBox7.TabStop = false;
        	// 
        	// pictureBox8
        	// 
        	this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
        	this.pictureBox8.Location = new System.Drawing.Point(117, 164);
        	this.pictureBox8.Name = "pictureBox8";
        	this.pictureBox8.Size = new System.Drawing.Size(26, 15);
        	this.pictureBox8.TabIndex = 14;
        	this.pictureBox8.TabStop = false;
        	// 
        	// FormLogin
        	// 
        	this.BackColor = System.Drawing.SystemColors.ActiveCaption;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(476, 233);
        	this.Controls.Add(this.pictureBox8);
        	this.Controls.Add(this.pictureBox7);
        	this.Controls.Add(this.pictureBox6);
        	this.Controls.Add(this.pictureBox5);
        	this.Controls.Add(this.pictureBox4);
        	this.Controls.Add(this.pictureBox3);
        	this.Controls.Add(this.pictureBox2);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.rbIngles);
        	this.Controls.Add(this.rbEspanol);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnLogin);
        	this.Controls.Add(this.txtPassword);
        	this.Controls.Add(this.txtUsername);
        	this.Cursor = System.Windows.Forms.Cursors.Arrow;
        	this.Name = "FormLogin";
        	this.RightToLeftLayout = true;
        	this.Text = "Login Plataforma Educativa";
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;

        // Aplica el idioma seleccionado a todos los textos del formulario
        private void AplicarIdioma()
        {
            this.Text = LanguageManager.GetText("login_title");
            label1.Text = LanguageManager.GetText("login_user");
            label2.Text = LanguageManager.GetText("login_pass");
            btnLogin.Text = LanguageManager.GetText("login_btn");
        }

        // Evento al cambiar la selección de idioma
        private void rbIdioma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEspanol.Checked)
                LanguageManager.CurrentLanguage = LanguageManager.AppLanguage.Spanish;
            else if (rbIngles.Checked)
                LanguageManager.CurrentLanguage = LanguageManager.AppLanguage.English;
            
            AplicarIdioma(); // Actualizar textos del formulario
        }

        // Evento del botón Login
        private void btnLogin_Click(object sender, EventArgs e)
{
    string user = txtUsername.Text.Trim();
    string pass = txtPassword.Text;

    if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
    {
        MessageBox.Show(LanguageManager.GetText("login_error_empty"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    // Intentar autenticar
    User u = UserDAL.Authenticate(user, pass);
    
    if (u != null)
    {
        // Usuario existe y contraseña correcta
        if (u.Role == "Admin")
        {
            frmAdminDashboard adminForm = new frmAdminDashboard(u);
            adminForm.Show();
            this.Hide();
        }
        else if (u.Role == "Jugador")
        {
            frmJugadorMain jugadorForm = new frmJugadorMain(u);
            jugadorForm.Show();
            this.Hide();
        }
    }
    else
    {
        // Usuario no existe o contraseña incorrecta
        // Primero verificamos si el usuario existe (independientemente de la contraseña)
        bool userExists = UserDAL.UserExists(user);
        
        if (!userExists)
        {
            // El usuario no existe, ofrecemos registrarlo
            DialogResult res = MessageBox.Show(
                string.Format(LanguageManager.GetText("ask_register"), user),
                LanguageManager.GetText("register_title"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                // Crear nuevo usuario con rol "Jugador"
                if (UserDAL.CreateUser(user, pass, "Jugador"))
                {
                    MessageBox.Show(LanguageManager.GetText("register_success"), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: iniciar sesión automáticamente después de registrar
                    User newUser = UserDAL.Authenticate(user, pass);
                    if (newUser != null)
                    {
                        frmJugadorMain jugadorForm = new frmJugadorMain(newUser);
                        jugadorForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show(LanguageManager.GetText("register_error"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        else
        {
            // El usuario existe pero la contraseña es incorrecta
            MessageBox.Show(LanguageManager.GetText("login_error_credentials"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
        
 }
}
