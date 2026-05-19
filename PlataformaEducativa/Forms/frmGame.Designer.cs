/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 18/5/2026
 * Time: 10:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PlataformaEducativa.Forms
{
    partial class frmGame
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
        	this.lblPregunta = new System.Windows.Forms.Label();
        	this.rbOpcion1 = new System.Windows.Forms.RadioButton();
        	this.rbOpcion2 = new System.Windows.Forms.RadioButton();
        	this.rbOpcion3 = new System.Windows.Forms.RadioButton();
        	this.rbOpcion4 = new System.Windows.Forms.RadioButton();
        	this.btnResponder = new System.Windows.Forms.Button();
        	this.btnCambiarIdioma = new System.Windows.Forms.Button();
        	this.picImagen = new System.Windows.Forms.PictureBox();
        	((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lblPregunta
        	// 
        	this.lblPregunta.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblPregunta.Image = ((System.Drawing.Image)(resources.GetObject("lblPregunta.Image")));
        	this.lblPregunta.Location = new System.Drawing.Point(64, 9);
        	this.lblPregunta.Name = "lblPregunta";
        	this.lblPregunta.Size = new System.Drawing.Size(760, 168);
        	this.lblPregunta.TabIndex = 7;
        	this.lblPregunta.Text = "Pregunta";
        	this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// rbOpcion1
        	// 
        	this.rbOpcion1.BackColor = System.Drawing.Color.Transparent;
        	this.rbOpcion1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
        	this.rbOpcion1.Image = ((System.Drawing.Image)(resources.GetObject("rbOpcion1.Image")));
        	this.rbOpcion1.Location = new System.Drawing.Point(509, 377);
        	this.rbOpcion1.Name = "rbOpcion1";
        	this.rbOpcion1.Size = new System.Drawing.Size(352, 86);
        	this.rbOpcion1.TabIndex = 6;
        	this.rbOpcion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.rbOpcion1.UseVisualStyleBackColor = false;
        	// 
        	// rbOpcion2
        	// 
        	this.rbOpcion2.BackColor = System.Drawing.Color.Transparent;
        	this.rbOpcion2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.rbOpcion2.Image = ((System.Drawing.Image)(resources.GetObject("rbOpcion2.Image")));
        	this.rbOpcion2.Location = new System.Drawing.Point(20, 375);
        	this.rbOpcion2.Name = "rbOpcion2";
        	this.rbOpcion2.Size = new System.Drawing.Size(349, 91);
        	this.rbOpcion2.TabIndex = 5;
        	this.rbOpcion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.rbOpcion2.UseVisualStyleBackColor = false;
        	// 
        	// rbOpcion3
        	// 
        	this.rbOpcion3.BackColor = System.Drawing.Color.Transparent;
        	this.rbOpcion3.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
        	this.rbOpcion3.Image = ((System.Drawing.Image)(resources.GetObject("rbOpcion3.Image")));
        	this.rbOpcion3.Location = new System.Drawing.Point(509, 484);
        	this.rbOpcion3.Name = "rbOpcion3";
        	this.rbOpcion3.Size = new System.Drawing.Size(352, 88);
        	this.rbOpcion3.TabIndex = 4;
        	this.rbOpcion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.rbOpcion3.UseVisualStyleBackColor = false;
        	// 
        	// rbOpcion4
        	// 
        	this.rbOpcion4.BackColor = System.Drawing.Color.Transparent;
        	this.rbOpcion4.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
        	this.rbOpcion4.Image = ((System.Drawing.Image)(resources.GetObject("rbOpcion4.Image")));
        	this.rbOpcion4.Location = new System.Drawing.Point(20, 484);
        	this.rbOpcion4.Name = "rbOpcion4";
        	this.rbOpcion4.Size = new System.Drawing.Size(349, 88);
        	this.rbOpcion4.TabIndex = 3;
        	this.rbOpcion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.rbOpcion4.UseVisualStyleBackColor = false;
        	// 
        	// btnResponder
        	// 
        	this.btnResponder.BackColor = System.Drawing.Color.Transparent;
        	this.btnResponder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResponder.BackgroundImage")));
        	this.btnResponder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        	this.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnResponder.ForeColor = System.Drawing.Color.Black;
        	this.btnResponder.Image = ((System.Drawing.Image)(resources.GetObject("btnResponder.Image")));
        	this.btnResponder.Location = new System.Drawing.Point(54, 603);
        	this.btnResponder.Name = "btnResponder";
        	this.btnResponder.Size = new System.Drawing.Size(72, 50);
        	this.btnResponder.TabIndex = 2;
        	this.btnResponder.UseVisualStyleBackColor = false;
        	this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
        	// 
        	// btnCambiarIdioma
        	// 
        	this.btnCambiarIdioma.BackColor = System.Drawing.Color.Transparent;
        	this.btnCambiarIdioma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambiarIdioma.BackgroundImage")));
        	this.btnCambiarIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnCambiarIdioma.ForeColor = System.Drawing.Color.Black;
        	this.btnCambiarIdioma.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarIdioma.Image")));
        	this.btnCambiarIdioma.Location = new System.Drawing.Point(810, 592);
        	this.btnCambiarIdioma.Name = "btnCambiarIdioma";
        	this.btnCambiarIdioma.Size = new System.Drawing.Size(73, 61);
        	this.btnCambiarIdioma.TabIndex = 1;
        	this.btnCambiarIdioma.UseVisualStyleBackColor = false;
        	this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);
        	// 
        	// picImagen
        	// 
        	this.picImagen.Image = ((System.Drawing.Image)(resources.GetObject("picImagen.Image")));
        	this.picImagen.Location = new System.Drawing.Point(86, 191);
        	this.picImagen.Name = "picImagen";
        	this.picImagen.Size = new System.Drawing.Size(727, 178);
        	this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.picImagen.TabIndex = 0;
        	this.picImagen.TabStop = false;
        	// 
        	// frmGame
        	// 
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(906, 665);
        	this.Controls.Add(this.picImagen);
        	this.Controls.Add(this.btnCambiarIdioma);
        	this.Controls.Add(this.btnResponder);
        	this.Controls.Add(this.rbOpcion4);
        	this.Controls.Add(this.rbOpcion3);
        	this.Controls.Add(this.rbOpcion2);
        	this.Controls.Add(this.rbOpcion1);
        	this.Controls.Add(this.lblPregunta);
        	this.Name = "frmGame";
        	this.Text = "Responder preguntas";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGame_FormClosed);
        	((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
        	this.ResumeLayout(false);

        }

        // Declaración de controles (solo una vez)
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rbOpcion1, rbOpcion2, rbOpcion3, rbOpcion4;
        private System.Windows.Forms.Button btnResponder, btnCambiarIdioma;
        private System.Windows.Forms.PictureBox picImagen;
    }
}