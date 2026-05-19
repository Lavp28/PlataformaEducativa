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
using PlataformaEducativa.Models;

namespace PlataformaEducativa.Forms
{
    public partial class frmAdminDashboard : Form
    {
        private User _admin;
        private Button btnManageUsers, btnManageModules, btnManageQuestions, btnLogout;

        public frmAdminDashboard(User admin)
        {
            InitializeComponent();
            _admin = admin;
            AplicarIdioma();
            this.Text += " - " + _admin.Username;
        }

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
        	this.btnManageUsers = new System.Windows.Forms.Button();
        	this.btnManageModules = new System.Windows.Forms.Button();
        	this.btnManageQuestions = new System.Windows.Forms.Button();
        	this.btnLogout = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// btnManageUsers
        	// 
        	this.btnManageUsers.BackColor = System.Drawing.Color.Transparent;
        	this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
        	this.btnManageUsers.Location = new System.Drawing.Point(257, 132);
        	this.btnManageUsers.Name = "btnManageUsers";
        	this.btnManageUsers.Size = new System.Drawing.Size(199, 51);
        	this.btnManageUsers.TabIndex = 3;
        	this.btnManageUsers.UseVisualStyleBackColor = false;
        	this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
        	// 
        	// btnManageModules
        	// 
        	this.btnManageModules.BackColor = System.Drawing.Color.Transparent;
        	this.btnManageModules.Image = ((System.Drawing.Image)(resources.GetObject("btnManageModules.Image")));
        	this.btnManageModules.Location = new System.Drawing.Point(30, 132);
        	this.btnManageModules.Name = "btnManageModules";
        	this.btnManageModules.Size = new System.Drawing.Size(201, 51);
        	this.btnManageModules.TabIndex = 2;
        	this.btnManageModules.UseVisualStyleBackColor = false;
        	this.btnManageModules.Click += new System.EventHandler(this.btnManageModules_Click);
        	// 
        	// btnManageQuestions
        	// 
        	this.btnManageQuestions.BackColor = System.Drawing.Color.Transparent;
        	this.btnManageQuestions.Image = ((System.Drawing.Image)(resources.GetObject("btnManageQuestions.Image")));
        	this.btnManageQuestions.Location = new System.Drawing.Point(257, 232);
        	this.btnManageQuestions.Name = "btnManageQuestions";
        	this.btnManageQuestions.Size = new System.Drawing.Size(199, 51);
        	this.btnManageQuestions.TabIndex = 1;
        	this.btnManageQuestions.UseVisualStyleBackColor = false;
        	this.btnManageQuestions.Click += new System.EventHandler(this.btnManageQuestions_Click);
        	// 
        	// btnLogout
        	// 
        	this.btnLogout.BackColor = System.Drawing.Color.Transparent;
        	this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
        	this.btnLogout.Location = new System.Drawing.Point(30, 232);
        	this.btnLogout.Name = "btnLogout";
        	this.btnLogout.Size = new System.Drawing.Size(201, 51);
        	this.btnLogout.TabIndex = 0;
        	this.btnLogout.UseVisualStyleBackColor = false;
        	this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.Transparent;
        	this.label1.Font = new System.Drawing.Font("Unispace", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(127, 82);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(229, 32);
        	this.label1.TabIndex = 4;
        	this.label1.Text = "ADMINISTRACION";
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(141, 12);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(143, 65);
        	this.pictureBox1.TabIndex = 5;
        	this.pictureBox1.TabStop = false;
        	// 
        	// frmAdminDashboard
        	// 
        	this.BackColor = System.Drawing.Color.Navy;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(479, 346);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnLogout);
        	this.Controls.Add(this.btnManageQuestions);
        	this.Controls.Add(this.btnManageModules);
        	this.Controls.Add(this.btnManageUsers);
        	this.Name = "frmAdminDashboard";
        	this.Text = "Admin Dashboard";
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

        private void AplicarIdioma()
        {
            this.Text = LanguageManager.GetText("admin_title");
            btnManageUsers.Text = LanguageManager.GetText("admin_users");
            btnManageModules.Text = LanguageManager.GetText("admin_modules");
            btnManageQuestions.Text = LanguageManager.GetText("admin_questions");
            btnLogout.Text = LanguageManager.GetText("admin_logout");
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            new frmManageUsers().ShowDialog();
        }

        private void btnManageModules_Click(object sender, EventArgs e)
        {
            new frmManageModules().ShowDialog();
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            new frmManageQuestions().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }
    }
}