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
    partial class frmJugadorMain
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJugadorMain));
        	this.lblPuntajeTotal = new System.Windows.Forms.Label();
        	this.cmbModulosJugar = new System.Windows.Forms.ComboBox();
        	this.btnJugar = new System.Windows.Forms.Button();
        	this.btnCerrarSesion = new System.Windows.Forms.Button();
        	this.lblRankingModulo = new System.Windows.Forms.Label();
        	this.cmbRankingModulo = new System.Windows.Forms.ComboBox();
        	this.dgvRanking = new System.Windows.Forms.DataGridView();
        	this.grpMisEstadisticas = new System.Windows.Forms.GroupBox();
        	this.lblMiModulo = new System.Windows.Forms.Label();
        	this.lblMisCorrectas = new System.Windows.Forms.Label();
        	this.lblMisIncorrectas = new System.Windows.Forms.Label();
        	this.lblMiPuntaje = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	this.pictureBox3 = new System.Windows.Forms.PictureBox();
        	this.pictureBox4 = new System.Windows.Forms.PictureBox();
        	((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
        	this.grpMisEstadisticas.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lblPuntajeTotal
        	// 
        	this.lblPuntajeTotal.AutoSize = true;
        	this.lblPuntajeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.lblPuntajeTotal.Image = ((System.Drawing.Image)(resources.GetObject("lblPuntajeTotal.Image")));
        	this.lblPuntajeTotal.Location = new System.Drawing.Point(692, 16);
        	this.lblPuntajeTotal.Name = "lblPuntajeTotal";
        	this.lblPuntajeTotal.Size = new System.Drawing.Size(131, 20);
        	this.lblPuntajeTotal.TabIndex = 0;
        	this.lblPuntajeTotal.Text = "Puntaje total: 0";
        	// 
        	// cmbModulosJugar
        	// 
        	this.cmbModulosJugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbModulosJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cmbModulosJugar.Location = new System.Drawing.Point(50, 16);
        	this.cmbModulosJugar.Name = "cmbModulosJugar";
        	this.cmbModulosJugar.Size = new System.Drawing.Size(200, 21);
        	this.cmbModulosJugar.TabIndex = 1;
        	// 
        	// btnJugar
        	// 
        	this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnJugar.Image = ((System.Drawing.Image)(resources.GetObject("btnJugar.Image")));
        	this.btnJugar.Location = new System.Drawing.Point(50, 55);
        	this.btnJugar.Name = "btnJugar";
        	this.btnJugar.Size = new System.Drawing.Size(100, 30);
        	this.btnJugar.TabIndex = 2;
        	this.btnJugar.Text = "Jugar";
        	this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
        	// 
        	// btnCerrarSesion
        	// 
        	this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
        	this.btnCerrarSesion.Location = new System.Drawing.Point(156, 55);
        	this.btnCerrarSesion.Name = "btnCerrarSesion";
        	this.btnCerrarSesion.Size = new System.Drawing.Size(100, 30);
        	this.btnCerrarSesion.TabIndex = 3;
        	this.btnCerrarSesion.Text = "Cerrar sesión";
        	this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
        	// 
        	// lblRankingModulo
        	// 
        	this.lblRankingModulo.AutoSize = true;
        	this.lblRankingModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.lblRankingModulo.Image = ((System.Drawing.Image)(resources.GetObject("lblRankingModulo.Image")));
        	this.lblRankingModulo.Location = new System.Drawing.Point(479, 77);
        	this.lblRankingModulo.Name = "lblRankingModulo";
        	this.lblRankingModulo.Size = new System.Drawing.Size(174, 20);
        	this.lblRankingModulo.TabIndex = 4;
        	this.lblRankingModulo.Text = "Ranking por módulo:";
        	// 
        	// cmbRankingModulo
        	// 
        	this.cmbRankingModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbRankingModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.cmbRankingModulo.Location = new System.Drawing.Point(689, 77);
        	this.cmbRankingModulo.Name = "cmbRankingModulo";
        	this.cmbRankingModulo.Size = new System.Drawing.Size(200, 21);
        	this.cmbRankingModulo.TabIndex = 5;
        	this.cmbRankingModulo.SelectedIndexChanged += new System.EventHandler(this.cmbRankingModulo_SelectedIndexChanged);
        	// 
        	// dgvRanking
        	// 
        	this.dgvRanking.AllowUserToAddRows = false;
        	this.dgvRanking.AllowUserToDeleteRows = false;
        	this.dgvRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgvRanking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
        	this.dgvRanking.Location = new System.Drawing.Point(36, 124);
        	this.dgvRanking.Name = "dgvRanking";
        	this.dgvRanking.ReadOnly = true;
        	this.dgvRanking.Size = new System.Drawing.Size(500, 200);
        	this.dgvRanking.TabIndex = 6;
        	// 
        	// grpMisEstadisticas
        	// 
        	this.grpMisEstadisticas.BackColor = System.Drawing.Color.Black;
        	this.grpMisEstadisticas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpMisEstadisticas.BackgroundImage")));
        	this.grpMisEstadisticas.Controls.Add(this.lblMiModulo);
        	this.grpMisEstadisticas.Controls.Add(this.lblMisCorrectas);
        	this.grpMisEstadisticas.Controls.Add(this.lblMisIncorrectas);
        	this.grpMisEstadisticas.Controls.Add(this.lblMiPuntaje);
        	this.grpMisEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.grpMisEstadisticas.Location = new System.Drawing.Point(36, 345);
        	this.grpMisEstadisticas.Name = "grpMisEstadisticas";
        	this.grpMisEstadisticas.Size = new System.Drawing.Size(500, 80);
        	this.grpMisEstadisticas.TabIndex = 7;
        	this.grpMisEstadisticas.TabStop = false;
        	this.grpMisEstadisticas.Text = "Mis estadísticas en este módulo";
        	// 
        	// lblMiModulo
        	// 
        	this.lblMiModulo.AutoSize = true;
        	this.lblMiModulo.Location = new System.Drawing.Point(20, 25);
        	this.lblMiModulo.Name = "lblMiModulo";
        	this.lblMiModulo.Size = new System.Drawing.Size(0, 13);
        	this.lblMiModulo.TabIndex = 0;
        	// 
        	// lblMisCorrectas
        	// 
        	this.lblMisCorrectas.AutoSize = true;
        	this.lblMisCorrectas.Location = new System.Drawing.Point(20, 50);
        	this.lblMisCorrectas.Name = "lblMisCorrectas";
        	this.lblMisCorrectas.Size = new System.Drawing.Size(0, 13);
        	this.lblMisCorrectas.TabIndex = 1;
        	// 
        	// lblMisIncorrectas
        	// 
        	this.lblMisIncorrectas.AutoSize = true;
        	this.lblMisIncorrectas.Location = new System.Drawing.Point(200, 50);
        	this.lblMisIncorrectas.Name = "lblMisIncorrectas";
        	this.lblMisIncorrectas.Size = new System.Drawing.Size(0, 13);
        	this.lblMisIncorrectas.TabIndex = 2;
        	// 
        	// lblMiPuntaje
        	// 
        	this.lblMiPuntaje.AutoSize = true;
        	this.lblMiPuntaje.Location = new System.Drawing.Point(380, 50);
        	this.lblMiPuntaje.Name = "lblMiPuntaje";
        	this.lblMiPuntaje.Size = new System.Drawing.Size(0, 13);
        	this.lblMiPuntaje.TabIndex = 3;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(576, 194);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(291, 262);
        	this.pictureBox1.TabIndex = 8;
        	this.pictureBox1.TabStop = false;
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
        	this.pictureBox2.Location = new System.Drawing.Point(692, 194);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(62, 72);
        	this.pictureBox2.TabIndex = 9;
        	this.pictureBox2.TabStop = false;
        	// 
        	// pictureBox3
        	// 
        	this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
        	this.pictureBox3.Location = new System.Drawing.Point(618, 243);
        	this.pictureBox3.Name = "pictureBox3";
        	this.pictureBox3.Size = new System.Drawing.Size(59, 60);
        	this.pictureBox3.TabIndex = 10;
        	this.pictureBox3.TabStop = false;
        	// 
        	// pictureBox4
        	// 
        	this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
        	this.pictureBox4.Location = new System.Drawing.Point(772, 253);
        	this.pictureBox4.Name = "pictureBox4";
        	this.pictureBox4.Size = new System.Drawing.Size(62, 71);
        	this.pictureBox4.TabIndex = 11;
        	this.pictureBox4.TabStop = false;
        	// 
        	// frmJugadorMain
        	// 
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(901, 450);
        	this.Controls.Add(this.pictureBox4);
        	this.Controls.Add(this.pictureBox3);
        	this.Controls.Add(this.pictureBox2);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.lblPuntajeTotal);
        	this.Controls.Add(this.cmbModulosJugar);
        	this.Controls.Add(this.btnJugar);
        	this.Controls.Add(this.btnCerrarSesion);
        	this.Controls.Add(this.lblRankingModulo);
        	this.Controls.Add(this.cmbRankingModulo);
        	this.Controls.Add(this.dgvRanking);
        	this.Controls.Add(this.grpMisEstadisticas);
        	this.Name = "frmJugadorMain";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Jugador";
        	((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
        	this.grpMisEstadisticas.ResumeLayout(false);
        	this.grpMisEstadisticas.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;

        // Declaraciones únicas
        private System.Windows.Forms.Label lblPuntajeTotal;
        private System.Windows.Forms.ComboBox cmbModulosJugar, cmbRankingModulo;
        private System.Windows.Forms.Button btnJugar, btnCerrarSesion;
        private System.Windows.Forms.Label lblRankingModulo;
        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.GroupBox grpMisEstadisticas;
        private System.Windows.Forms.Label lblMiModulo, lblMisCorrectas, lblMisIncorrectas, lblMiPuntaje;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}