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

            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.grpMisEstadisticas.SuspendLayout();
            this.SuspendLayout();

            // lblPuntajeTotal
            this.lblPuntajeTotal.AutoSize = true;
            this.lblPuntajeTotal.Location = new System.Drawing.Point(50, 20);

            // cmbModulosJugar
            this.cmbModulosJugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulosJugar.Location = new System.Drawing.Point(50, 50);
            this.cmbModulosJugar.Size = new System.Drawing.Size(200, 21);

            // btnJugar
            this.btnJugar.Location = new System.Drawing.Point(50, 90);
            this.btnJugar.Size = new System.Drawing.Size(100, 30);
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);

            // btnCerrarSesion
            this.btnCerrarSesion.Location = new System.Drawing.Point(160, 90);
            this.btnCerrarSesion.Size = new System.Drawing.Size(100, 30);
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            // lblRankingModulo
            this.lblRankingModulo.AutoSize = true;
            this.lblRankingModulo.Location = new System.Drawing.Point(50, 140);

            // cmbRankingModulo
            this.cmbRankingModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRankingModulo.Location = new System.Drawing.Point(180, 137);
            this.cmbRankingModulo.Size = new System.Drawing.Size(200, 21);
            this.cmbRankingModulo.SelectedIndexChanged += new System.EventHandler(this.cmbRankingModulo_SelectedIndexChanged);

            // dgvRanking
            this.dgvRanking.AllowUserToAddRows = false;
            this.dgvRanking.AllowUserToDeleteRows = false;
            this.dgvRanking.Location = new System.Drawing.Point(50, 170);
            this.dgvRanking.Size = new System.Drawing.Size(500, 200);
            this.dgvRanking.ReadOnly = true;
            this.dgvRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // grpMisEstadisticas
            this.grpMisEstadisticas.Location = new System.Drawing.Point(50, 380);
            this.grpMisEstadisticas.Size = new System.Drawing.Size(500, 80);
            this.grpMisEstadisticas.Controls.Add(this.lblMiModulo);
            this.grpMisEstadisticas.Controls.Add(this.lblMisCorrectas);
            this.grpMisEstadisticas.Controls.Add(this.lblMisIncorrectas);
            this.grpMisEstadisticas.Controls.Add(this.lblMiPuntaje);

            this.lblMiModulo.AutoSize = true; this.lblMiModulo.Location = new System.Drawing.Point(20, 25);
            this.lblMisCorrectas.AutoSize = true; this.lblMisCorrectas.Location = new System.Drawing.Point(20, 50);
            this.lblMisIncorrectas.AutoSize = true; this.lblMisIncorrectas.Location = new System.Drawing.Point(200, 50);
            this.lblMiPuntaje.AutoSize = true; this.lblMiPuntaje.Location = new System.Drawing.Point(380, 50);

            // Agregar controles
            this.Controls.Add(this.lblPuntajeTotal);
            this.Controls.Add(this.cmbModulosJugar);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblRankingModulo);
            this.Controls.Add(this.cmbRankingModulo);
            this.Controls.Add(this.dgvRanking);
            this.Controls.Add(this.grpMisEstadisticas);

            // Formulario
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Text = "Jugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.grpMisEstadisticas.ResumeLayout(false);
            this.grpMisEstadisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblPuntajeTotal;
        private System.Windows.Forms.ComboBox cmbModulosJugar, cmbRankingModulo;
        private System.Windows.Forms.Button btnJugar, btnCerrarSesion;
        private System.Windows.Forms.Label lblRankingModulo;
        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.GroupBox grpMisEstadisticas;
        private System.Windows.Forms.Label lblMiModulo, lblMisCorrectas, lblMisIncorrectas, lblMiPuntaje;
    }
}