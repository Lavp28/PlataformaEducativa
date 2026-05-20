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
        	this.txtOpcionEs1 = new System.Windows.Forms.TextBox();
        	this.txtOpcionEs2 = new System.Windows.Forms.TextBox();
        	this.txtOpcionEs3 = new System.Windows.Forms.TextBox();
        	this.txtOpcionEs4 = new System.Windows.Forms.TextBox();
        	this.txtOpcionEn1 = new System.Windows.Forms.TextBox();
        	this.txtOpcionEn2 = new System.Windows.Forms.TextBox();
        	this.txtOpcionEn3 = new System.Windows.Forms.TextBox();
        	this.txtOpcionEn4 = new System.Windows.Forms.TextBox();
        	this.labelOpcion1 = new System.Windows.Forms.Label();
        	this.labelOpcion2 = new System.Windows.Forms.Label();
        	this.labelOpcion3 = new System.Windows.Forms.Label();
        	this.labelOpcion4 = new System.Windows.Forms.Label();
        	this.rbCorrecta1 = new System.Windows.Forms.RadioButton();
        	this.rbCorrecta2 = new System.Windows.Forms.RadioButton();
        	this.rbCorrecta3 = new System.Windows.Forms.RadioButton();
        	this.rbCorrecta4 = new System.Windows.Forms.RadioButton();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// cmbModulos
        	// 
        	this.cmbModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbModulos.Location = new System.Drawing.Point(120, 12);
        	this.cmbModulos.Name = "cmbModulos";
        	this.cmbModulos.Size = new System.Drawing.Size(200, 21);
        	this.cmbModulos.TabIndex = 0;
        	this.cmbModulos.SelectedIndexChanged += new System.EventHandler(this.cmbModulos_SelectedIndexChanged);
        	// 
        	// dgvPreguntas
        	// 
        	this.dgvPreguntas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
        	this.dgvPreguntas.Location = new System.Drawing.Point(20, 44);
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
        	this.txtPreguntaEs.Location = new System.Drawing.Point(150, 212);
        	this.txtPreguntaEs.Name = "txtPreguntaEs";
        	this.txtPreguntaEs.Size = new System.Drawing.Size(370, 20);
        	this.txtPreguntaEs.TabIndex = 2;
        	// 
        	// txtPreguntaEn
        	// 
        	this.txtPreguntaEn.Location = new System.Drawing.Point(150, 238);
        	this.txtPreguntaEn.Name = "txtPreguntaEn";
        	this.txtPreguntaEn.Size = new System.Drawing.Size(370, 20);
        	this.txtPreguntaEn.TabIndex = 3;
        	// 
        	// txtImagePath
        	// 
        	this.txtImagePath.Location = new System.Drawing.Point(150, 491);
        	this.txtImagePath.Name = "txtImagePath";
        	this.txtImagePath.Size = new System.Drawing.Size(270, 20);
        	this.txtImagePath.TabIndex = 4;
        	// 
        	// btnExaminarImagen
        	// 
        	this.btnExaminarImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExaminarImagen.BackgroundImage")));
        	this.btnExaminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnExaminarImagen.Location = new System.Drawing.Point(430, 489);
        	this.btnExaminarImagen.Name = "btnExaminarImagen";
        	this.btnExaminarImagen.Size = new System.Drawing.Size(90, 23);
        	this.btnExaminarImagen.TabIndex = 5;
        	this.btnExaminarImagen.Click += new System.EventHandler(this.btnExaminarImagen_Click);
        	// 
        	// btnAgregar
        	// 
        	this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
        	this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnAgregar.Location = new System.Drawing.Point(20, 518);
        	this.btnAgregar.Name = "btnAgregar";
        	this.btnAgregar.Size = new System.Drawing.Size(130, 30);
        	this.btnAgregar.TabIndex = 6;
        	this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        	// 
        	// btnActualizar
        	// 
        	this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
        	this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnActualizar.Location = new System.Drawing.Point(160, 518);
        	this.btnActualizar.Name = "btnActualizar";
        	this.btnActualizar.Size = new System.Drawing.Size(130, 30);
        	this.btnActualizar.TabIndex = 7;
        	this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
        	// 
        	// btnEliminar
        	// 
        	this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
        	this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnEliminar.Location = new System.Drawing.Point(300, 518);
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
        	this.labelModulo.Location = new System.Drawing.Point(20, 15);
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
        	this.labelPreguntaEs.Location = new System.Drawing.Point(20, 215);
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
        	this.labelPreguntaEn.Location = new System.Drawing.Point(20, 241);
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
        	this.labelImagen.Location = new System.Drawing.Point(20, 494);
        	this.labelImagen.Name = "labelImagen";
        	this.labelImagen.Size = new System.Drawing.Size(86, 13);
        	this.labelImagen.TabIndex = 12;
        	this.labelImagen.Text = "Imagen (ruta):";
        	// 
        	// txtOpcionEs1
        	// 
        	this.txtOpcionEs1.Location = new System.Drawing.Point(150, 295);
        	this.txtOpcionEs1.Name = "txtOpcionEs1";
        	this.txtOpcionEs1.Size = new System.Drawing.Size(170, 20);
        	this.txtOpcionEs1.TabIndex = 13;
        	// 
        	// txtOpcionEs2
        	// 
        	this.txtOpcionEs2.Location = new System.Drawing.Point(150, 321);
        	this.txtOpcionEs2.Name = "txtOpcionEs2";
        	this.txtOpcionEs2.Size = new System.Drawing.Size(170, 20);
        	this.txtOpcionEs2.TabIndex = 14;
        	// 
        	// txtOpcionEs3
        	// 
        	this.txtOpcionEs3.Location = new System.Drawing.Point(150, 347);
        	this.txtOpcionEs3.Name = "txtOpcionEs3";
        	this.txtOpcionEs3.Size = new System.Drawing.Size(170, 20);
        	this.txtOpcionEs3.TabIndex = 15;
        	// 
        	// txtOpcionEs4
        	// 
        	this.txtOpcionEs4.Location = new System.Drawing.Point(150, 373);
        	this.txtOpcionEs4.Name = "txtOpcionEs4";
        	this.txtOpcionEs4.Size = new System.Drawing.Size(170, 20);
        	this.txtOpcionEs4.TabIndex = 16;
        	// 
        	// txtOpcionEn1
        	// 
        	this.txtOpcionEn1.Location = new System.Drawing.Point(329, 295);
        	this.txtOpcionEn1.Name = "txtOpcionEn1";
        	this.txtOpcionEn1.Size = new System.Drawing.Size(191, 20);
        	this.txtOpcionEn1.TabIndex = 17;
        	// 
        	// txtOpcionEn2
        	// 
        	this.txtOpcionEn2.Location = new System.Drawing.Point(329, 321);
        	this.txtOpcionEn2.Name = "txtOpcionEn2";
        	this.txtOpcionEn2.Size = new System.Drawing.Size(191, 20);
        	this.txtOpcionEn2.TabIndex = 18;
        	// 
        	// txtOpcionEn3
        	// 
        	this.txtOpcionEn3.Location = new System.Drawing.Point(329, 347);
        	this.txtOpcionEn3.Name = "txtOpcionEn3";
        	this.txtOpcionEn3.Size = new System.Drawing.Size(191, 20);
        	this.txtOpcionEn3.TabIndex = 19;
        	// 
        	// txtOpcionEn4
        	// 
        	this.txtOpcionEn4.Location = new System.Drawing.Point(329, 373);
        	this.txtOpcionEn4.Name = "txtOpcionEn4";
        	this.txtOpcionEn4.Size = new System.Drawing.Size(191, 20);
        	this.txtOpcionEn4.TabIndex = 20;
        	// 
        	// labelOpcion1
        	// 
        	this.labelOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.labelOpcion1.Image = ((System.Drawing.Image)(resources.GetObject("labelOpcion1.Image")));
        	this.labelOpcion1.Location = new System.Drawing.Point(20, 298);
        	this.labelOpcion1.Name = "labelOpcion1";
        	this.labelOpcion1.Size = new System.Drawing.Size(108, 13);
        	this.labelOpcion1.TabIndex = 21;
        	this.labelOpcion1.Text = "Opcion 1";
        	// 
        	// labelOpcion2
        	// 
        	this.labelOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.labelOpcion2.Image = ((System.Drawing.Image)(resources.GetObject("labelOpcion2.Image")));
        	this.labelOpcion2.Location = new System.Drawing.Point(20, 324);
        	this.labelOpcion2.Name = "labelOpcion2";
        	this.labelOpcion2.Size = new System.Drawing.Size(108, 13);
        	this.labelOpcion2.TabIndex = 22;
        	this.labelOpcion2.Text = "Opcion 2";
        	// 
        	// labelOpcion3
        	// 
        	this.labelOpcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.labelOpcion3.Image = ((System.Drawing.Image)(resources.GetObject("labelOpcion3.Image")));
        	this.labelOpcion3.Location = new System.Drawing.Point(20, 350);
        	this.labelOpcion3.Name = "labelOpcion3";
        	this.labelOpcion3.Size = new System.Drawing.Size(108, 13);
        	this.labelOpcion3.TabIndex = 23;
        	this.labelOpcion3.Text = "Opcion 3";
        	// 
        	// labelOpcion4
        	// 
        	this.labelOpcion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.labelOpcion4.Image = ((System.Drawing.Image)(resources.GetObject("labelOpcion4.Image")));
        	this.labelOpcion4.Location = new System.Drawing.Point(20, 376);
        	this.labelOpcion4.Name = "labelOpcion4";
        	this.labelOpcion4.Size = new System.Drawing.Size(108, 13);
        	this.labelOpcion4.TabIndex = 24;
        	this.labelOpcion4.Text = "Opcion 4";
        	// 
        	// rbCorrecta1
        	// 
        	this.rbCorrecta1.BackColor = System.Drawing.Color.Transparent;
        	this.rbCorrecta1.Location = new System.Drawing.Point(134, 295);
        	this.rbCorrecta1.Name = "rbCorrecta1";
        	this.rbCorrecta1.Size = new System.Drawing.Size(14, 20);
        	this.rbCorrecta1.TabIndex = 25;
        	this.rbCorrecta1.TabStop = true;
        	this.rbCorrecta1.Text = "rbCorrecta1";
        	this.rbCorrecta1.UseVisualStyleBackColor = false;
        	// 
        	// rbCorrecta2
        	// 
        	this.rbCorrecta2.BackColor = System.Drawing.Color.Transparent;
        	this.rbCorrecta2.Location = new System.Drawing.Point(134, 320);
        	this.rbCorrecta2.Name = "rbCorrecta2";
        	this.rbCorrecta2.Size = new System.Drawing.Size(14, 20);
        	this.rbCorrecta2.TabIndex = 26;
        	this.rbCorrecta2.TabStop = true;
        	this.rbCorrecta2.Text = "rbCorrecta2";
        	this.rbCorrecta2.UseVisualStyleBackColor = false;
        	// 
        	// rbCorrecta3
        	// 
        	this.rbCorrecta3.BackColor = System.Drawing.Color.Transparent;
        	this.rbCorrecta3.Location = new System.Drawing.Point(134, 346);
        	this.rbCorrecta3.Name = "rbCorrecta3";
        	this.rbCorrecta3.Size = new System.Drawing.Size(14, 20);
        	this.rbCorrecta3.TabIndex = 27;
        	this.rbCorrecta3.TabStop = true;
        	this.rbCorrecta3.Text = "rbCorrecta3";
        	this.rbCorrecta3.UseVisualStyleBackColor = false;
        	// 
        	// rbCorrecta4
        	// 
        	this.rbCorrecta4.BackColor = System.Drawing.Color.Transparent;
        	this.rbCorrecta4.Location = new System.Drawing.Point(134, 373);
        	this.rbCorrecta4.Name = "rbCorrecta4";
        	this.rbCorrecta4.Size = new System.Drawing.Size(14, 20);
        	this.rbCorrecta4.TabIndex = 28;
        	this.rbCorrecta4.TabStop = true;
        	this.rbCorrecta4.Text = "rbCorrecta4";
        	this.rbCorrecta4.UseVisualStyleBackColor = false;
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
        	this.label1.Location = new System.Drawing.Point(182, 270);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(108, 13);
        	this.label1.TabIndex = 29;
        	this.label1.Text = "Español";
        	// 
        	// label2
        	// 
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
        	this.label2.Location = new System.Drawing.Point(375, 270);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(108, 13);
        	this.label2.TabIndex = 30;
        	this.label2.Text = "Ingles";
        	// 
        	// frmManageQuestions
        	// 
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(550, 560);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.rbCorrecta4);
        	this.Controls.Add(this.rbCorrecta3);
        	this.Controls.Add(this.rbCorrecta2);
        	this.Controls.Add(this.rbCorrecta1);
        	this.Controls.Add(this.labelOpcion4);
        	this.Controls.Add(this.labelOpcion3);
        	this.Controls.Add(this.labelOpcion2);
        	this.Controls.Add(this.labelOpcion1);
        	this.Controls.Add(this.txtOpcionEn4);
        	this.Controls.Add(this.txtOpcionEn3);
        	this.Controls.Add(this.txtOpcionEn2);
        	this.Controls.Add(this.txtOpcionEn1);
        	this.Controls.Add(this.txtOpcionEs4);
        	this.Controls.Add(this.txtOpcionEs3);
        	this.Controls.Add(this.txtOpcionEs2);
        	this.Controls.Add(this.txtOpcionEs1);
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
        private System.Windows.Forms.TextBox txtOpcionEs1;
        private System.Windows.Forms.TextBox txtOpcionEs2;
        private System.Windows.Forms.TextBox txtOpcionEs3;
        private System.Windows.Forms.TextBox txtOpcionEs4;
        private System.Windows.Forms.TextBox txtOpcionEn1;
        private System.Windows.Forms.TextBox txtOpcionEn2;
        private System.Windows.Forms.TextBox txtOpcionEn3;
        private System.Windows.Forms.TextBox txtOpcionEn4;
        private System.Windows.Forms.Label labelOpcion1;
        private System.Windows.Forms.Label labelOpcion2;
        private System.Windows.Forms.Label labelOpcion3;
        private System.Windows.Forms.Label labelOpcion4;
        private System.Windows.Forms.RadioButton rbCorrecta1;
        private System.Windows.Forms.RadioButton rbCorrecta2;
        private System.Windows.Forms.RadioButton rbCorrecta3;
        private System.Windows.Forms.RadioButton rbCorrecta4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}