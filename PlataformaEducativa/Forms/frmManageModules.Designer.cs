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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageModules));
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
        	// 
        	// dgvModulos
        	// 
        	this.dgvModulos.AllowUserToAddRows = false;
        	this.dgvModulos.AllowUserToDeleteRows = false;
        	this.dgvModulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
        	this.dgvModulos.Location = new System.Drawing.Point(108, 154);
        	this.dgvModulos.MultiSelect = false;
        	this.dgvModulos.Name = "dgvModulos";
        	this.dgvModulos.ReadOnly = true;
        	this.dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvModulos.Size = new System.Drawing.Size(500, 200);
        	this.dgvModulos.TabIndex = 0;
        	this.dgvModulos.SelectionChanged += new System.EventHandler(this.dgvModulos_SelectionChanged);
        	// 
        	// txtNombreEs
        	// 
        	this.txtNombreEs.Location = new System.Drawing.Point(225, 71);
        	this.txtNombreEs.Name = "txtNombreEs";
        	this.txtNombreEs.Size = new System.Drawing.Size(180, 20);
        	this.txtNombreEs.TabIndex = 1;
        	// 
        	// txtNombreEn
        	// 
        	this.txtNombreEn.Location = new System.Drawing.Point(225, 107);
        	this.txtNombreEn.Name = "txtNombreEn";
        	this.txtNombreEn.Size = new System.Drawing.Size(180, 20);
        	this.txtNombreEn.TabIndex = 2;
        	// 
        	// btnAgregar
        	// 
        	this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
        	this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnAgregar.Location = new System.Drawing.Point(422, 62);
        	this.btnAgregar.Name = "btnAgregar";
        	this.btnAgregar.Size = new System.Drawing.Size(93, 33);
        	this.btnAgregar.TabIndex = 5;
        	this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        	// 
        	// btnActualizar
        	// 
        	this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
        	this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
        	this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.btnActualizar.Location = new System.Drawing.Point(422, 100);
        	this.btnActualizar.Name = "btnActualizar";
        	this.btnActualizar.Size = new System.Drawing.Size(93, 33);
        	this.btnActualizar.TabIndex = 6;
        	this.btnActualizar.UseVisualStyleBackColor = false;
        	this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
        	// 
        	// btnEliminar
        	// 
        	this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
        	this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnEliminar.Location = new System.Drawing.Point(532, 62);
        	this.btnEliminar.Name = "btnEliminar";
        	this.btnEliminar.Size = new System.Drawing.Size(93, 33);
        	this.btnEliminar.TabIndex = 7;
        	this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
        	// 
        	// lblNombreEs
        	// 
        	this.lblNombreEs.AutoSize = true;
        	this.lblNombreEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.lblNombreEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.lblNombreEs.Image = ((System.Drawing.Image)(resources.GetObject("lblNombreEs.Image")));
        	this.lblNombreEs.Location = new System.Drawing.Point(108, 74);
        	this.lblNombreEs.Name = "lblNombreEs";
        	this.lblNombreEs.Size = new System.Drawing.Size(111, 13);
        	this.lblNombreEs.TabIndex = 3;
        	this.lblNombreEs.Text = "Nombre (Español):";
        	// 
        	// lblNombreEn
        	// 
        	this.lblNombreEn.AutoSize = true;
        	this.lblNombreEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.lblNombreEn.Image = ((System.Drawing.Image)(resources.GetObject("lblNombreEn.Image")));
        	this.lblNombreEn.Location = new System.Drawing.Point(108, 110);
        	this.lblNombreEn.Name = "lblNombreEn";
        	this.lblNombreEn.Size = new System.Drawing.Size(100, 13);
        	this.lblNombreEn.TabIndex = 4;
        	this.lblNombreEn.Text = "Nombre (Inglés):";
        	// 
        	// frmManageModules
        	// 
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(730, 456);
        	this.Controls.Add(this.dgvModulos);
        	this.Controls.Add(this.txtNombreEs);
        	this.Controls.Add(this.txtNombreEn);
        	this.Controls.Add(this.lblNombreEs);
        	this.Controls.Add(this.lblNombreEn);
        	this.Controls.Add(this.btnAgregar);
        	this.Controls.Add(this.btnActualizar);
        	this.Controls.Add(this.btnEliminar);
        	this.Name = "frmManageModules";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "-";
        	((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
    }
}