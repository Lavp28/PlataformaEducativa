/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 18/5/2026
 * Time: 10:09 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PlataformaEducativa.Forms
{
    partial class frmManageModules
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvModulos;
        private System.Windows.Forms.TextBox txtNombreEs, txtNombreEn;
        private System.Windows.Forms.Button btnAgregar, btnActualizar, btnEliminar;
        private System.Windows.Forms.Label lblNombreEs, lblNombreEn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.txtNombreEs = new System.Windows.Forms.TextBox();
            this.txtNombreEn = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombreEs = new System.Windows.Forms.Label();
            this.lblNombreEn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.SuspendLayout();

            // dgvModulos
            this.dgvModulos.AllowUserToAddRows = false;
            this.dgvModulos.AllowUserToDeleteRows = false;
            this.dgvModulos.Location = new System.Drawing.Point(20, 100);
            this.dgvModulos.Size = new System.Drawing.Size(500, 200);
            this.dgvModulos.ReadOnly = true;
            this.dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulos.MultiSelect = false;
            this.dgvModulos.SelectionChanged += new System.EventHandler(this.dgvModulos_SelectionChanged);

            // txtNombreEs
            this.txtNombreEs.Location = new System.Drawing.Point(120, 20);
            this.txtNombreEs.Size = new System.Drawing.Size(180, 20);

            // txtNombreEn
            this.txtNombreEn.Location = new System.Drawing.Point(120, 50);
            this.txtNombreEn.Size = new System.Drawing.Size(180, 20);

            // labels
            this.lblNombreEs.AutoSize = true;
            this.lblNombreEs.Location = new System.Drawing.Point(20, 23);
            this.lblNombreEs.Text = "Nombre (Español):";

            this.lblNombreEn.AutoSize = true;
            this.lblNombreEn.Location = new System.Drawing.Point(20, 53);
            this.lblNombreEn.Text = "Nombre (Inglés):";

            // botones
            this.btnAgregar.Location = new System.Drawing.Point(320, 20);
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnActualizar.Location = new System.Drawing.Point(320, 50);
            this.btnActualizar.Size = new System.Drawing.Size(90, 30);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(420, 20);
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // formulario
            this.ClientSize = new System.Drawing.Size(550, 330);
            this.Controls.Add(this.dgvModulos);
            this.Controls.Add(this.txtNombreEs);
            this.Controls.Add(this.txtNombreEn);
            this.Controls.Add(this.lblNombreEs);
            this.Controls.Add(this.lblNombreEn);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Text = "Gestionar Módulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}