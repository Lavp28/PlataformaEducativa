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

            this.txtOpcionEs = new System.Windows.Forms.TextBox[4];
            this.txtOpcionEn = new System.Windows.Forms.TextBox[4];
            this.rbCorrecta = new System.Windows.Forms.RadioButton[4];
            this.labelOpcion = new System.Windows.Forms.Label[4];

            for (int i = 0; i < 4; i++)
            {
                this.txtOpcionEs[i] = new System.Windows.Forms.TextBox();
                this.txtOpcionEn[i] = new System.Windows.Forms.TextBox();
                this.rbCorrecta[i] = new System.Windows.Forms.RadioButton();
                this.labelOpcion[i] = new System.Windows.Forms.Label();
            }

            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
            this.SuspendLayout();

            // cmbModulos
            this.cmbModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulos.Location = new System.Drawing.Point(120, 18);
            this.cmbModulos.Size = new System.Drawing.Size(200, 21);
            this.cmbModulos.SelectedIndexChanged += new System.EventHandler(this.cmbModulos_SelectedIndexChanged);

            // dgvPreguntas
            this.dgvPreguntas.Location = new System.Drawing.Point(20, 50);
            this.dgvPreguntas.Size = new System.Drawing.Size(500, 150);
            this.dgvPreguntas.ReadOnly = true;
            this.dgvPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreguntas.MultiSelect = false;
            this.dgvPreguntas.SelectionChanged += new System.EventHandler(this.dgvPreguntas_SelectionChanged);

            // txtPreguntaEs
            this.txtPreguntaEs.Location = new System.Drawing.Point(150, 218);
            this.txtPreguntaEs.Size = new System.Drawing.Size(370, 20);

            // txtPreguntaEn
            this.txtPreguntaEn.Location = new System.Drawing.Point(150, 248);
            this.txtPreguntaEn.Size = new System.Drawing.Size(370, 20);

            // txtImagePath
            this.txtImagePath.Location = new System.Drawing.Point(150, 278);
            this.txtImagePath.Size = new System.Drawing.Size(270, 20);

            // btnExaminarImagen
            this.btnExaminarImagen.Location = new System.Drawing.Point(430, 276);
            this.btnExaminarImagen.Size = new System.Drawing.Size(90, 23);
            this.btnExaminarImagen.Click += new System.EventHandler(this.btnExaminarImagen_Click);

            // labels de sección
            this.labelModulo.AutoSize = true; this.labelModulo.Location = new System.Drawing.Point(20, 21); this.labelModulo.Text = "Módulo:";
            this.labelPreguntaEs.AutoSize = true; this.labelPreguntaEs.Location = new System.Drawing.Point(20, 221); this.labelPreguntaEs.Text = "Pregunta (Español):";
            this.labelPreguntaEn.AutoSize = true; this.labelPreguntaEn.Location = new System.Drawing.Point(20, 251); this.labelPreguntaEn.Text = "Pregunta (Inglés):";
            this.labelImagen.AutoSize = true; this.labelImagen.Location = new System.Drawing.Point(20, 281); this.labelImagen.Text = "Imagen (ruta):";

            // Opciones
            int yStart = 320;
            for (int i = 0; i < 4; i++)
            {
                int y = yStart + i * 35;
                this.labelOpcion[i].AutoSize = true;
                this.labelOpcion[i].Location = new System.Drawing.Point(20, y + 5);
                this.labelOpcion[i].Text = "Opción " + (i + 1) + ":";

                this.txtOpcionEs[i].Location = new System.Drawing.Point(80, y);
                this.txtOpcionEs[i].Size = new System.Drawing.Size(150, 20);

                this.txtOpcionEn[i].Location = new System.Drawing.Point(240, y);
                this.txtOpcionEn[i].Size = new System.Drawing.Size(150, 20);

                this.rbCorrecta[i].Location = new System.Drawing.Point(400, y + 3);
                this.rbCorrecta[i].Size = new System.Drawing.Size(80, 20);
                this.rbCorrecta[i].Text = "Correcta";

                this.Controls.Add(this.labelOpcion[i]);
                this.Controls.Add(this.txtOpcionEs[i]);
                this.Controls.Add(this.txtOpcionEn[i]);
                this.Controls.Add(this.rbCorrecta[i]);
            }

            // Botones de acción
            this.btnAgregar.Location = new System.Drawing.Point(20, 500);
            this.btnAgregar.Size = new System.Drawing.Size(130, 30);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnActualizar.Location = new System.Drawing.Point(160, 500);
            this.btnActualizar.Size = new System.Drawing.Size(130, 30);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(300, 500);
            this.btnEliminar.Size = new System.Drawing.Size(130, 30);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // Añadir controles al formulario
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

            // frmManageQuestions
            this.ClientSize = new System.Drawing.Size(550, 560);
            this.Text = "Gestionar Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

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