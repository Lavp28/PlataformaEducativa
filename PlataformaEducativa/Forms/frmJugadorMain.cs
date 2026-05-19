/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 1:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using PlataformaEducativa.DAL;
using PlataformaEducativa.Models;
using MySql.Data.MySqlClient;

namespace PlataformaEducativa.Forms
{
    public partial class frmJugadorMain : Form
    {
        private User _jugador;
        
        // Controles principales
        private ComboBox cmbModulosJugar;
        private Button btnJugar, btnCerrarSesion;
        private Label lblPuntajeTotal;
        
        // Controles para ranking y estadísticas personales
        private Label lblRankingModulo;
        private ComboBox cmbRankingModulo;
        private DataGridView dgvRanking;
        private GroupBox grpMisEstadisticas;
        private Label lblMisCorrectas, lblMisIncorrectas, lblMiPuntaje, lblMiModulo;

        public frmJugadorMain(User jugador)
        {
            InitializeComponent();
            _jugador = jugador;
            CargarPuntajeTotal();
            CargarModulosJugar();
            CargarModulosRanking();
            AplicarIdioma();
        }

        private void InitializeComponent()
        {
            // Controles para jugar
            this.cmbModulosJugar = new ComboBox();
            this.btnJugar = new Button();
            this.btnCerrarSesion = new Button();
            this.lblPuntajeTotal = new Label();
            
            // Controles para ranking y estadísticas
            this.lblRankingModulo = new Label();
            this.cmbRankingModulo = new ComboBox();
            this.dgvRanking = new DataGridView();
            this.grpMisEstadisticas = new GroupBox();
            this.lblMisCorrectas = new Label();
            this.lblMisIncorrectas = new Label();
            this.lblMiPuntaje = new Label();
            this.lblMiModulo = new Label();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.grpMisEstadisticas.SuspendLayout();
            this.SuspendLayout();
            
            // lblPuntajeTotal
            this.lblPuntajeTotal.AutoSize = true;
            this.lblPuntajeTotal.Location = new System.Drawing.Point(50, 20);
            this.lblPuntajeTotal.Text = "Puntuación total: 0";
            
            // cmbModulosJugar (para jugar)
            this.cmbModulosJugar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbModulosJugar.Location = new System.Drawing.Point(50, 50);
            this.cmbModulosJugar.Size = new System.Drawing.Size(200, 21);
            
            // btnJugar
            this.btnJugar.Location = new System.Drawing.Point(50, 90);
            this.btnJugar.Size = new System.Drawing.Size(100, 30);
            this.btnJugar.Text = "Jugar";
            this.btnJugar.Click += new EventHandler(this.btnJugar_Click);
            
            // btnCerrarSesion
            this.btnCerrarSesion.Location = new System.Drawing.Point(160, 90);
            this.btnCerrarSesion.Size = new System.Drawing.Size(100, 30);
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.Click += new EventHandler(this.btnCerrarSesion_Click);
            
            // lblRankingModulo
            this.lblRankingModulo.AutoSize = true;
            this.lblRankingModulo.Location = new System.Drawing.Point(50, 140);
            this.lblRankingModulo.Text = "Ranking por módulo:";
            
            // cmbRankingModulo
            this.cmbRankingModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRankingModulo.Location = new System.Drawing.Point(180, 137);
            this.cmbRankingModulo.Size = new System.Drawing.Size(200, 21);
            this.cmbRankingModulo.SelectedIndexChanged += new EventHandler(this.cmbRankingModulo_SelectedIndexChanged);
            
            // dgvRanking
            this.dgvRanking.AllowUserToAddRows = false;
            this.dgvRanking.AllowUserToDeleteRows = false;
            this.dgvRanking.Location = new System.Drawing.Point(50, 170);
            this.dgvRanking.Size = new System.Drawing.Size(500, 200);
            this.dgvRanking.ReadOnly = true;
            this.dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // GroupBox para estadísticas personales
            this.grpMisEstadisticas.Text = "Mis estadísticas en este módulo";
            this.grpMisEstadisticas.Location = new System.Drawing.Point(50, 380);
            this.grpMisEstadisticas.Size = new System.Drawing.Size(500, 80);
            this.grpMisEstadisticas.TabIndex = 10;
            
            this.lblMiModulo.AutoSize = true;
            this.lblMiModulo.Location = new System.Drawing.Point(20, 25);
            this.lblMiModulo.Text = "Módulo: --";
            
            this.lblMisCorrectas.AutoSize = true;
            this.lblMisCorrectas.Location = new System.Drawing.Point(20, 50);
            this.lblMisCorrectas.Text = "Correctas: 0";
            
            this.lblMisIncorrectas.AutoSize = true;
            this.lblMisIncorrectas.Location = new System.Drawing.Point(200, 50);
            this.lblMisIncorrectas.Text = "Incorrectas: 0";
            
            this.lblMiPuntaje.AutoSize = true;
            this.lblMiPuntaje.Location = new System.Drawing.Point(380, 50);
            this.lblMiPuntaje.Text = "Puntaje: 0";
            
            this.grpMisEstadisticas.Controls.Add(this.lblMiModulo);
            this.grpMisEstadisticas.Controls.Add(this.lblMisCorrectas);
            this.grpMisEstadisticas.Controls.Add(this.lblMisIncorrectas);
            this.grpMisEstadisticas.Controls.Add(this.lblMiPuntaje);
            
            // Añadir controles al formulario
            this.Controls.Add(this.lblPuntajeTotal);
            this.Controls.Add(this.cmbModulosJugar);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblRankingModulo);
            this.Controls.Add(this.cmbRankingModulo);
            this.Controls.Add(this.dgvRanking);
            this.Controls.Add(this.grpMisEstadisticas);
            
            // Configuración del formulario
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Text = "Jugador";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.grpMisEstadisticas.ResumeLayout(false);
            this.grpMisEstadisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CargarPuntajeTotal()
        {
            int score = UserDAL.GetUserScore(_jugador.UserID);
            lblPuntajeTotal.Text = LanguageManager.GetText("jugador_score") + " " + score.ToString();
        }
        
        private void CargarModulosJugar()
        {
            DataTable dt = ModuleDAL.GetAllModules();
            cmbModulosJugar.DisplayMember = "ModuleName_Es";
            cmbModulosJugar.ValueMember = "ModuleID";
            cmbModulosJugar.DataSource = dt;
        }
        
        private void CargarModulosRanking()
        {
            DataTable dt = ModuleDAL.GetAllModules();
            cmbRankingModulo.DisplayMember = "ModuleName_Es";
            cmbRankingModulo.ValueMember = "ModuleID";
            cmbRankingModulo.DataSource = dt;
            if (dt.Rows.Count > 0)
                CargarRanking(Convert.ToInt32(dt.Rows[0]["ModuleID"]));
        }
        
        private void CargarRanking(int moduleId)
        {
            try
            {
                string query = @"
                    SELECT u.Username, 
                           COALESCE(ums.CorrectCount, 0) AS Correctas, 
                           COALESCE(ums.IncorrectCount, 0) AS Incorrectas,
                           COALESCE(ums.Score, 0) AS Puntaje
                    FROM Users u
                    LEFT JOIN UserModuleStats ums ON u.UserID = ums.UserID AND ums.ModuleID = @mod
                    WHERE u.Role = 'Jugador'
                    ORDER BY Puntaje DESC";
                
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mod", moduleId);
                    var da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRanking.DataSource = dt;
                    
                    // Títulos de columnas según idioma
                    if (dgvRanking.Columns["Username"] != null)
                        dgvRanking.Columns["Username"].HeaderText = LanguageManager.GetText("jugador_usuario");
                    if (dgvRanking.Columns["Correctas"] != null)
                        dgvRanking.Columns["Correctas"].HeaderText = LanguageManager.GetText("jugador_correctas");
                    if (dgvRanking.Columns["Incorrectas"] != null)
                        dgvRanking.Columns["Incorrectas"].HeaderText = LanguageManager.GetText("jugador_incorrectas");
                    if (dgvRanking.Columns["Puntaje"] != null)
                        dgvRanking.Columns["Puntaje"].HeaderText = LanguageManager.GetText("jugador_puntaje");
                    
                    ResaltarJugadorActual();
                    CargarMisEstadisticas(moduleId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ranking: " + ex.Message);
            }
        }
        
        private void ResaltarJugadorActual()
        {
            foreach (DataGridViewRow row in dgvRanking.Rows)
            {
                if (row.Cells["Username"].Value != null && row.Cells["Username"].Value.ToString() == _jugador.Username)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    break;
                }
            }
        }
        
        private void CargarMisEstadisticas(int moduleId)
        {
            try
            {
                string query = @"
                    SELECT ModuleID, CorrectCount, IncorrectCount, Score
                    FROM UserModuleStats
                    WHERE UserID = @uid AND ModuleID = @mod";
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", _jugador.UserID);
                    cmd.Parameters.AddWithValue("@mod", moduleId);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int correctas = reader.GetInt32("CorrectCount");
                        int incorrectas = reader.GetInt32("IncorrectCount");
                        int puntaje = reader.GetInt32("Score");
                        lblMisCorrectas.Text = LanguageManager.GetText("jugador_correctas") + ": " + correctas;
                        lblMisIncorrectas.Text = LanguageManager.GetText("jugador_incorrectas") + ": " + incorrectas;
                        lblMiPuntaje.Text = LanguageManager.GetText("jugador_puntaje") + ": " + puntaje;
                        // Mostrar nombre del módulo
                        string nombreModulo = cmbRankingModulo.Text;
                        lblMiModulo.Text = LanguageManager.GetText("module") + ": " + nombreModulo;
                    }
                    else
                    {
                        // Aún no ha jugado en este módulo
                        lblMisCorrectas.Text = LanguageManager.GetText("jugador_correctas") + ": 0";
                        lblMisIncorrectas.Text = LanguageManager.GetText("jugador_incorrectas") + ": 0";
                        lblMiPuntaje.Text = LanguageManager.GetText("jugador_puntaje") + ": 0";
                        lblMiModulo.Text = LanguageManager.GetText("module") + ": " + cmbRankingModulo.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error estadísticas personales: " + ex.Message);
            }
        }
        
        private void cmbRankingModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRankingModulo.SelectedValue != null)
            {
                int moduleId = Convert.ToInt32(cmbRankingModulo.SelectedValue);
                CargarRanking(moduleId);
            }
        }
        
        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (cmbModulosJugar.SelectedValue == null)
            {
                MessageBox.Show(LanguageManager.GetText("select_module_first"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int moduleId = Convert.ToInt32(cmbModulosJugar.SelectedValue);
            frmGame game = new frmGame(_jugador, moduleId);
            game.ShowDialog();
            // Actualizar todo después de jugar
            CargarPuntajeTotal();
            if (cmbRankingModulo.SelectedValue != null)
                CargarRanking(Convert.ToInt32(cmbRankingModulo.SelectedValue));
        }
        
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin login = new FormLogin();
            login.Show();
        }
        
        private void AplicarIdioma()
        {
            this.Text = LanguageManager.GetText("jugador_title") + " " + _jugador.Username;
            CargarPuntajeTotal(); // actualiza el texto
            btnJugar.Text = LanguageManager.GetText("jugador_play");
            btnCerrarSesion.Text = LanguageManager.GetText("admin_logout");
            lblRankingModulo.Text = LanguageManager.GetText("jugador_ranking") + ":";
            grpMisEstadisticas.Text = LanguageManager.GetText("my_stats");
        }
    }
}