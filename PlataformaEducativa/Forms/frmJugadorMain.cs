using System;
using System.Data;
using System.Windows.Forms;
using PlataformaEducativa.DAL;
using PlataformaEducativa.Models;

namespace PlataformaEducativa.Forms
{
    public partial class frmJugadorMain : Form
    {
        private User _jugador;

        public frmJugadorMain(User jugador)
        {
            InitializeComponent();
            _jugador = jugador;
            CargarPuntajeTotal();
            CargarModulosJugar();
            CargarModulosRanking();
            AplicarIdioma();
        }

        private void CargarPuntajeTotal()
        {
            int score = UserDAL.GetUserScore(_jugador.UserID);
            lblPuntajeTotal.Text = LanguageManager.GetText("jugador_score") + " " + score;
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
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mod", moduleId);
                    var da = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRanking.DataSource = dt;
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
                if (row.Cells["Username"].Value.ToString() == _jugador.Username)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
        }

        private void CargarMisEstadisticas(int moduleId)
        {
            try
            {
                string query = "SELECT CorrectCount, IncorrectCount, Score FROM UserModuleStats WHERE UserID = @uid AND ModuleID = @mod";
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", _jugador.UserID);
                    cmd.Parameters.AddWithValue("@mod", moduleId);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblMisCorrectas.Text = LanguageManager.GetText("jugador_correctas") + ": " + reader.GetInt32("CorrectCount");
                        lblMisIncorrectas.Text = LanguageManager.GetText("jugador_incorrectas") + ": " + reader.GetInt32("IncorrectCount");
                        lblMiPuntaje.Text = LanguageManager.GetText("jugador_puntaje") + ": " + reader.GetInt32("Score");
                    }
                    else
                    {
                        lblMisCorrectas.Text = LanguageManager.GetText("jugador_correctas") + ": 0";
                        lblMisIncorrectas.Text = LanguageManager.GetText("jugador_incorrectas") + ": 0";
                        lblMiPuntaje.Text = LanguageManager.GetText("jugador_puntaje") + ": 0";
                    }
                    lblMiModulo.Text = LanguageManager.GetText("module") + ": " + cmbRankingModulo.Text;
                }
            }
            catch { }
        }

        private void cmbRankingModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRankingModulo.SelectedValue != null)
                CargarRanking(Convert.ToInt32(cmbRankingModulo.SelectedValue));
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (cmbModulosJugar.SelectedValue == null)
            {
                MessageBox.Show(LanguageManager.GetText("select_module_first"));
                return;
            }
            int moduleId = Convert.ToInt32(cmbModulosJugar.SelectedValue);
            frmGame game = new frmGame(_jugador, moduleId);
            game.ShowDialog();
            CargarPuntajeTotal();
            if (cmbRankingModulo.SelectedValue != null)
                CargarRanking(Convert.ToInt32(cmbRankingModulo.SelectedValue));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }

        private void AplicarIdioma()
        {
            this.Text = LanguageManager.GetText("jugador_title") + " " + _jugador.Username;
            btnJugar.Text = LanguageManager.GetText("jugador_play");
            btnCerrarSesion.Text = LanguageManager.GetText("admin_logout");
            lblRankingModulo.Text = LanguageManager.GetText("jugador_ranking") + ":";
            grpMisEstadisticas.Text = LanguageManager.GetText("my_stats");
            CargarPuntajeTotal();
        }
    }
}