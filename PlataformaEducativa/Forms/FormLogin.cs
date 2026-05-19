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
        	this.txtUsername = new System.Windows.Forms.TextBox();
        	this.txtPassword = new System.Windows.Forms.TextBox();
        	this.btnLogin = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.rbEspanol = new System.Windows.Forms.RadioButton();
        	this.rbIngles = new System.Windows.Forms.RadioButton();
        	this.SuspendLayout();
        	// 
        	// txtUsername
        	// 
        	this.txtUsername.Location = new System.Drawing.Point(80, 25);
        	this.txtUsername.Name = "txtUsername";
        	this.txtUsername.Size = new System.Drawing.Size(150, 20);
        	this.txtUsername.TabIndex = 0;
        	// 
        	// txtPassword
        	// 
        	this.txtPassword.Location = new System.Drawing.Point(80, 51);
        	this.txtPassword.Name = "txtPassword";
        	this.txtPassword.PasswordChar = '*';
        	this.txtPassword.Size = new System.Drawing.Size(150, 20);
        	this.txtPassword.TabIndex = 1;
        	// 
        	// btnLogin
        	// 
        	this.btnLogin.ForeColor = System.Drawing.Color.Black;
        	this.btnLogin.Location = new System.Drawing.Point(119, 77);
        	this.btnLogin.Name = "btnLogin";
        	this.btnLogin.Size = new System.Drawing.Size(75, 23);
        	this.btnLogin.TabIndex = 2;
        	this.btnLogin.Text = "Ingresar";
        	this.btnLogin.UseVisualStyleBackColor = true;
        	this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(18, 28);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(46, 13);
        	this.label1.TabIndex = 6;
        	this.label1.Text = "Usuario:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.ForeColor = System.Drawing.Color.White;
        	this.label2.Location = new System.Drawing.Point(10, 54);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(64, 13);
        	this.label2.TabIndex = 5;
        	this.label2.Text = "Contraseña:";
        	// 
        	// rbEspanol
        	// 
        	this.rbEspanol.AutoSize = true;
        	this.rbEspanol.Checked = true;
        	this.rbEspanol.ForeColor = System.Drawing.Color.White;
        	this.rbEspanol.Location = new System.Drawing.Point(80, 115);
        	this.rbEspanol.Name = "rbEspanol";
        	this.rbEspanol.Size = new System.Drawing.Size(63, 17);
        	this.rbEspanol.TabIndex = 3;
        	this.rbEspanol.TabStop = true;
        	this.rbEspanol.Text = "Español";
        	this.rbEspanol.CheckedChanged += new System.EventHandler(this.rbIdioma_CheckedChanged);
        	// 
        	// rbIngles
        	// 
        	this.rbIngles.AutoSize = true;
        	this.rbIngles.ForeColor = System.Drawing.Color.White;
        	this.rbIngles.Location = new System.Drawing.Point(171, 115);
        	this.rbIngles.Name = "rbIngles";
        	this.rbIngles.Size = new System.Drawing.Size(59, 17);
        	this.rbIngles.TabIndex = 4;
        	this.rbIngles.Text = "English";
        	this.rbIngles.CheckedChanged += new System.EventHandler(this.rbIdioma_CheckedChanged);
        	// 
        	// FormLogin
        	// 
        	this.BackColor = System.Drawing.Color.Purple;
        	this.ClientSize = new System.Drawing.Size(713, 325);
        	this.Controls.Add(this.rbIngles);
        	this.Controls.Add(this.rbEspanol);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnLogin);
        	this.Controls.Add(this.txtPassword);
        	this.Controls.Add(this.txtUsername);
        	this.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.Name = "FormLogin";
        	this.Text = "Login Plataforma Educativa";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

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
