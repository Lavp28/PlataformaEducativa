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

            // lblPregunta
            this.lblPregunta.Location = new System.Drawing.Point(20, 20);
            this.lblPregunta.Size = new System.Drawing.Size(450, 60);
            this.lblPregunta.Text = "Pregunta";

            // rbOpcion1
            this.rbOpcion1.Location = new System.Drawing.Point(20, 90);
            this.rbOpcion1.Size = new System.Drawing.Size(200, 20);
            this.rbOpcion2.Location = new System.Drawing.Point(20, 120);
            this.rbOpcion2.Size = new System.Drawing.Size(200, 20);
            this.rbOpcion3.Location = new System.Drawing.Point(20, 150);
            this.rbOpcion3.Size = new System.Drawing.Size(200, 20);
            this.rbOpcion4.Location = new System.Drawing.Point(20, 180);
            this.rbOpcion4.Size = new System.Drawing.Size(200, 20);

            // btnResponder
            this.btnResponder.Location = new System.Drawing.Point(20, 230);
            this.btnResponder.Size = new System.Drawing.Size(100, 30);
            this.btnResponder.Text = "Responder";
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);

            // btnCambiarIdioma
            this.btnCambiarIdioma.Location = new System.Drawing.Point(140, 230);
            this.btnCambiarIdioma.Size = new System.Drawing.Size(100, 30);
            this.btnCambiarIdioma.Text = "English";
            this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);

            // picImagen
            this.picImagen.Location = new System.Drawing.Point(300, 90);
            this.picImagen.Size = new System.Drawing.Size(150, 120);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // frmGame
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.btnCambiarIdioma);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rbOpcion4);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.lblPregunta);
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