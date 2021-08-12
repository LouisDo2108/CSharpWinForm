using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HelloWorld
{
    public partial class FormMain : Form
    {
        private const string connectionString = @"Data Source=LOUIS-LENOVO-LE\SQLEXPRESS;Initial Catalog=CS486_Team12_DB;Integrated Security=True";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            initCBPlaylist();
            initCBSongs();
        }


        private void initCBPlaylist()
        {
            SqlConnection connection = null;
            String query = "Select * from playlists";
            int rowsAffected = -1;

            DataSet dataSet = ExecuteQuery(connection, query, connectionString, CommandType.Text, ref rowsAffected);

            if (rowsAffected > 0 && dataSet.Tables.Count > 0)
            {
                cbPlaylist.DataSource = dataSet.Tables[0];
                cbPlaylist.DisplayMember = "playlistName";
                cbPlaylist.ValueMember = "playlistID";
            }
        }

        private void initCBSongs()
        {
            SqlConnection connection = null;
            String query = "Select * from Songs";
            int rowsAffected = -1;

            DataSet dataSet = ExecuteQuery(connection, query, connectionString, CommandType.Text, ref rowsAffected);

            if (rowsAffected > 0 && dataSet.Tables.Count > 0)
            {
                cbSong.DataSource = dataSet.Tables[0];
                cbSong.DisplayMember = "songName";
                cbSong.ValueMember = "songID";
            }
        }

        private DataSet ExecuteQuery(SqlConnection sqlConnection, string commandText, string connectionString,
        CommandType commandType, ref Int32 rowsAffected, params SqlParameter[] parameters)
        {
            using(sqlConnection = new SqlConnection(connectionString)){
                using(SqlCommand command = new SqlCommand(commandText, sqlConnection)){
                    
                    command.CommandType = commandType;
                    if(parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            if (parameter.Value == null)
                            {
                                parameter.Value = DBNull.Value;
                            }
                        }
                        command.Parameters.AddRange(parameters);
                    }
                    

                    sqlConnection.Open();
                    
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                    DataSet dataset = new DataSet();

                    rowsAffected = sqlDataAdapter.Fill(dataset);

                    sqlConnection.Close();
                    return dataset;
                }
            }
        }

        public Int32 ExecuteNonQuery(String connectionString, String commandText,
          CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, conn))
                {

                    Int32 rowaffected = -1;
                    command.CommandType = commandType;
                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            if (parameter.Value == null)
                            {
                                parameter.Value = DBNull.Value;
                            }
                        }
                        command.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Do you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
                Application.Exit();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutMe formAboutMe = new FormAboutMe();
            formAboutMe.sHoten = "Huynh Tuan Luc";
            formAboutMe.ShowDialog();
        }

        private void clearDataGridView()
        {
            this.playlistdgv.DataSource = null;
            this.playlistdgv.Rows.Clear();
        }

        private void btnNhacTre_Click(object sender, EventArgs e)
        {
            //bool parseOK = Int32.TryParse(cbDepartment.SelectedValue.ToString(), out DepartmentID);
            SqlConnection sqlConnection = null;
            String query = "sp_selectMoiNhat";
            SqlParameter genre = new SqlParameter("@genre", SqlDbType.NVarChar);
            genre.Value = "Nhạc trẻ";
            SqlParameter plalistid = new SqlParameter("@playlistid", SqlDbType.Int);
            plalistid.Value = 1;
            Int32 rowsAffected = -1;

            DataSet dataset = ExecuteQuery(sqlConnection, query, connectionString, CommandType.StoredProcedure, ref rowsAffected, plalistid, genre);
            clearDataGridView();

            if (dataset.Tables.Count > 0)
            {
                defaultOnGenreClick(dataset);
            }
        }

        private void btnTruTinh_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            String query = "sp_selectMoiNhat";
            SqlParameter genre = new SqlParameter("@genre", SqlDbType.NVarChar);
            genre.Value = "Trữ tình";
            SqlParameter plalistid = new SqlParameter("@playlistid", SqlDbType.Int);
            plalistid.Value = 1;
            Int32 rowsAffected = -1;

            DataSet dataset = ExecuteQuery(sqlConnection, query, connectionString, CommandType.StoredProcedure, ref rowsAffected, plalistid, genre);
            clearDataGridView();

            if (dataset.Tables.Count > 0)
            {
                defaultOnGenreClick(dataset);
            }
        }

        private void defaultOnGenreClick(DataSet dataset)
        {
            btnHotNhat.BackColor = Color.Red;
            btnHotNhat.ForeColor = Color.White;
            btnMoiNhat.BackColor = Control.DefaultBackColor;
            btnMoiNhat.ForeColor = Control.DefaultForeColor;
            playlistdgv.DataSource = dataset.Tables[0];
            this.playlistdgv.Sort(this.playlistdgv.Columns["streamCount"], ListSortDirection.Descending);
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            String query = "sp_selectMoiNhat";
            SqlParameter genre = new SqlParameter("@genre", SqlDbType.NVarChar);
            genre.Value = "Pop";
            SqlParameter plalistid = new SqlParameter("@playlistid", SqlDbType.Int);
            plalistid.Value = 1;
            Int32 rowsAffected = -1;

            DataSet dataset = ExecuteQuery(sqlConnection, query, connectionString, CommandType.StoredProcedure, ref rowsAffected, plalistid, genre);
            clearDataGridView();

            if (dataset.Tables.Count > 0)
            {
                defaultOnGenreClick(dataset);
            }
        }

        private void btnRap_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            String query = "sp_selectMoiNhat";
            SqlParameter genre = new SqlParameter("@genre", SqlDbType.NVarChar);
            genre.Value = "R&B/Hip Hop/ Rap";
            SqlParameter plalistid = new SqlParameter("@playlistid", SqlDbType.Int);
            plalistid.Value = 1;
            Int32 rowsAffected = -1;

            DataSet dataset = ExecuteQuery(sqlConnection, query, connectionString, CommandType.StoredProcedure, ref rowsAffected, plalistid, genre);
            clearDataGridView();

            if (dataset.Tables.Count > 0)
            {
                defaultOnGenreClick(dataset);
            }
        }

        private void btnHotNhat_Click(object sender, EventArgs e)
        {
            if (this.btnHotNhat.ForeColor == Color.White && this.btnHotNhat.BackColor == Color.Red)
                return;

            btnHotNhat.BackColor = Color.Red; //Backgrouund color
            btnHotNhat.ForeColor = Color.White; // Text color
            btnMoiNhat.BackColor = Control.DefaultBackColor;
            btnMoiNhat.ForeColor = Control.DefaultForeColor;
            this.playlistdgv.Sort(this.playlistdgv.Columns["streamCount"], ListSortDirection.Descending);
        }

        private void btnMoiNhat_Click(object sender, EventArgs e)
        {
            if (this.btnMoiNhat.ForeColor == Color.White && this.btnMoiNhat.BackColor == Color.Red)
                return;

            btnMoiNhat.BackColor = Color.Red;
            btnMoiNhat.ForeColor = Color.White;
            btnHotNhat.BackColor = Control.DefaultBackColor;
            btnHotNhat.ForeColor = Control.DefaultForeColor;
            this.playlistdgv.Sort(this.playlistdgv.Columns["dateAdded"], ListSortDirection.Descending);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cbPlaylist.SelectedIndex < 0 || cbSong.SelectedIndex < 0)
            {
                MessageBox.Show("Please select all combo boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = null;
            SqlParameter playlistid = new SqlParameter("@playlistid", SqlDbType.Int);
            playlistid.Value = Int32.Parse(cbPlaylist.SelectedValue.ToString()); 
            SqlParameter songid = new SqlParameter("@songid", SqlDbType.Int);
            songid.Value = Int32.Parse(cbSong.SelectedValue.ToString());
            SqlParameter favorites = new SqlParameter("@favorites", SqlDbType.Int);
            favorites.Value = 1;
            string query = "sp_updatePlaylist";

            clearDataGridView();
            try
            {
                int rowAffected = ExecuteNonQuery(connectionString, query, CommandType.StoredProcedure, playlistid, songid, favorites);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCountSong_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            string query = "select dbo.fn_count_songs() as count";
            int rowsAffected = -1;
            DataSet dataset = ExecuteQuery(connection, query, connectionString, CommandType.Text, ref rowsAffected);
            clearDataGridView();

            if(dataset.Tables.Count > 0)
            {
                playlistdgv.DataSource = dataset.Tables[0];
            }
        }
    }
}
