/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 18/5/2026
 * Time: 10:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PlataformaEducativa.Forms
{
    partial class frmManageQuestions
    {
        private System.ComponentModel.IContainer components = null;

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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageQuestions));
        	this.cmbModulos = new System.Windows.Forms.ComboBox();
        	this.dgvPreguntas = new System.Windows.Forms.DataGridView();
        	this.txtPreguntaEs = new System.Windows.Forms.TextBox();
        	this.txtPreguntaEn = new System.Windows.Forms.TextBox();
        	this.txtImagePath = new System.Windows.Forms.TextBox();
        	this.btnExaminarImagen = new System.Windows.Forms.Button();
        	this.btnAgregar = new System.Windows.Forms.Button();
        	this.btnActualizar = new System.Windows.Forms.Button();
        	this.btnEliminar = new System.Windows.Forms.Button();
        	this.labelModulo = new System.Windows.Forms.Label();
        	this.labelPreguntaEs = new System.Windows.Forms.Label();
        	this.labelPreguntaEn = new System.Windows.Forms.Label();
        	this.labelImagen = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// cmbModulos
        	// 
        	this.cmbModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbModulos.Location = new System.Drawing.Point(120, 18);
        	this.cmbModulos.Name = "cmbModulos";
        	this.cmbModulos.Size = new System.Drawing.Size(200, 21);
        	this.cmbModulos.TabIndex = 0;
        	this.cmbModulos.SelectedIndexChanged += new System.EventHandler(this.cmbModulos_SelectedIndexChanged);
        	// 
        	// dgvPreguntas
        	// 
        	this.dgvPreguntas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
        	this.dgvPreguntas.Location = new System.Drawing.Point(20, 50);
        	this.dgvPreguntas.MultiSelect = false;
        	this.dgvPreguntas.Name = "dgvPreguntas";
        	this.dgvPreguntas.ReadOnly = true;
        	this.dgvPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvPreguntas.Size = new System.Drawing.Size(500, 150);
        	this.dgvPreguntas.TabIndex = 1;
        	this.dgvPreguntas.SelectionChanged += new System.EventHandler(this.dgvPreguntas_SelectionChanged);
        	// 
        	// txtPreguntaEs
        	// 
        	this.txtPreguntaEs.Location = new System.Drawing.Point(150, 218);
        	this.txtPreguntaEs.Name = "txtPreguntaEs";
        	this.txtPreguntaEs.Size = new System.Drawing.Size(370, 20);
        	this.txtPreguntaEs.TabIndex = 2;
        	// 
        	// txtPreguntaEn
        	// 
        	this.txtPreguntaEn.Location = new System.Drawing.Point(150, 248);
        	this.txtPreguntaEn.Name = "txtPreguntaEn";
        	this.txtPreguntaEn.Size = new System.Drawing.Size(370, 20);
        	this.txtPreguntaEn.TabIndex = 3;
        	// 
        	// txtImagePath
        	// 
        	this.txtImagePath.Location = new System.Drawing.Point(150, 278);
        	this.txtImagePath.Name = "txtImagePath";
        	this.txtImagePath.Size = new System.Drawing.Size(270, 20);
        	this.txtImagePath.TabIndex = 4;
        	// 
        	// btnExaminarImagen
        	// 
        	this.btnExaminarImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExaminarImagen.BackgroundImage")));
        	this.btnExaminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnExaminarImagen.Location = new System.Drawing.Point(430, 276);
        	this.btnExaminarImagen.Name = "btnExaminarImagen";
        	this.btnExaminarImagen.Size = new System.Drawing.Size(90, 23);
        	this.btnExaminarImagen.TabIndex = 5;
        	this.btnExaminarImagen.Click += new System.EventHandler(this.btnExaminarImagen_Click);
        	// 
        	// btnAgregar
        	// 
        	this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
        	this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnAgregar.Location = new System.Drawing.Point(20, 500);
        	this.btnAgregar.Name = "btnAgregar";
        	this.btnAgregar.Size = new System.Drawing.Size(130, 30);
        	this.btnAgregar.TabIndex = 6;
        	this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        	// 
        	// btnActualizar
        	// 
        	this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
        	this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnActualizar.Location = new System.Drawing.Point(160, 500);
        	this.btnActualizar.Name = "btnActualizar";
        	this.btnActualizar.Size = new System.Drawing.Size(130, 30);
        	this.btnActualizar.TabIndex = 7;
        	this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
        	// 
        	// btnEliminar
        	// 
        	this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
        	this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnEliminar.Location = new System.Drawing.Point(300, 500);
        	this.btnEliminar.Name = "btnEliminar";
        	this.btnEliminar.Size = new System.Drawing.Size(130, 30);
        	this.btnEliminar.TabIndex = 8;
        	this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
        	// 
        	// labelModulo
        	// 
        	this.labelModulo.AutoSize = true;
        	this.labelModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.labelModulo.Image = ((System.Drawing.Image)(resources.GetObject("labelModulo.Image")));
        	this.labelModulo.Location = new System.Drawing.Point(20, 21);
        	this.labelModulo.Name = "labelModulo";
        	this.labelModulo.Size = new System.Drawing.Size(52, 13);
        	this.labelModulo.TabIndex = 9;
        	this.labelModulo.Text = "Módulo:";
        	// 
        	// labelPreguntaEs
        	// 
        	this.labelPreguntaEs.AutoSize = true;
        	this.labelPreguntaEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.labelPreguntaEs.Image = ((System.Drawing.Image)(resources.GetObject("labelPreguntaEs.Image")));
        	this.labelPreguntaEs.Location = new System.Drawing.Point(20, 221);
        	this.labelPreguntaEs.Name = "labelPreguntaEs";
        	this.labelPreguntaEs.Size = new System.Drawing.Size(119, 13);
        	this.labelPreguntaEs.TabIndex = 10;
        	this.labelPreguntaEs.Text = "Pregunta (Español):";
        	// 
        	// labelPreguntaEn
        	// 
        	this.labelPreguntaEn.AutoSize = true;
        	this.labelPreguntaEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.labelPreguntaEn.Image = ((System.Drawing.Image)(resources.GetObject("labelPreguntaEn.Image")));
        	this.labelPreguntaEn.Location = new System.Drawing.Point(20, 251);
        	this.labelPreguntaEn.Name = "labelPreguntaEn";
        	this.labelPreguntaEn.Size = new System.Drawing.Size(108, 13);
        	this.labelPreguntaEn.TabIndex = 11;
        	this.labelPreguntaEn.Text = "Pregunta (Inglés):";
        	// 
        	// labelImagen
        	// 
        	this.labelImagen.AutoSize = true;
        	this.labelImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.labelImagen.Image = ((System.Drawing.Image)(resources.GetObject("labelImagen.Image")));
        	this.labelImagen.Location = new System.Drawing.Point(20, 281);
        	this.labelImagen.Name = "labelImagen";
        	this.labelImagen.Size = new System.Drawing.Size(86, 13);
        	this.labelImagen.TabIndex = 12;
        	this.labelImagen.Text = "Imagen (ruta):";
        	// 
        	// frmManageQuestions
        	// 
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(550, 560);
        	this.Controls.Add(this.cmbModulos);
        	this.Controls.Add(this.dgvPreguntas);
        	this.Controls.Add(this.txtPreguntaEs);
        	this.Controls.Add(this.txtPreguntaEn);
        	this.Controls.Add(this.txtImagePath);
        	this.Controls.Add(this.btnExaminarImagen);
        	this.Controls.Add(this.btnAgregar);
        	this.Controls.Add(this.btnActualizar);
        	this.Controls.Add(this.btnEliminar);
        	this.Controls.Add(this.labelModulo);
        	this.Controls.Add(this.labelPreguntaEs);
        	this.Controls.Add(this.labelPreguntaEn);
        	this.Controls.Add(this.labelImagen);
        	this.Name = "frmManageQuestions";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Gestionar Preguntas";
        	((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        // Declaración de controles (para que el diseñador los reconozca)
        private System.Windows.Forms.ComboBox cmbModulos;
        private System.Windows.Forms.DataGridView dgvPreguntas;
        private System.Windows.Forms.TextBox txtPreguntaEs, txtPreguntaEn, txtImagePath;
        private System.Windows.Forms.Button btnExaminarImagen, btnAgregar, btnActualizar, btnEliminar;
        private System.Windows.Forms.Label labelModulo, labelPreguntaEs, labelPreguntaEn, labelImagen;
        private System.Windows.Forms.TextBox[] txtOpcionEs;
        private System.Windows.Forms.TextBox[] txtOpcionEn;
        private System.Windows.Forms.RadioButton[] rbCorrecta;
        private System.Windows.Forms.Label[] labelOpcion;
    }
}