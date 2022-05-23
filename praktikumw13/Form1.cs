using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace praktikumw13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePickerBdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerBdate.CustomFormat = "dddd ,MMMM dd, yyyy";
        }
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        int counter = 0;
        string temp = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT `player_id`, `team_number`, `player_name`, `nation`,`team_name`, `birthdate`, IF(status = 1, 'Available', 'Not Available') as status FROM player_jesslyn p, nationality n, team t WHERE p.nationality_id = n.nationality_id and t.team_id= p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable isiData = new DataTable();
            sqlAdapter.Fill(isiData);
            textBoxID.Text = isiData.Rows[0][0].ToString();
            textBoxName.Text = isiData.Rows[0][2].ToString();
            dateTimePickerBdate.Text = isiData.Rows[0][5].ToString();
            numericUpDownTNumber.Text = isiData.Rows[counter][1].ToString();

            DataTable nationality = new DataTable();
            sqlQuery = "SELECT `nation`,`nationality_id` FROM  nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(nationality);
            comboBoxNation.DataSource = nationality;
            comboBoxNation.ValueMember = "nation";
            comboBoxNation.SelectedValue= isiData.Rows[counter][3].ToString();

            DataTable team = new DataTable();
            sqlQuery = "SELECT `team_name`,`team_id` FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(team);
            comboBoxTeam.DataSource = team;
            comboBoxTeam.ValueMember = "team_name";
        }
        private void numericUpDownTNumber_ValueChanged(object sender, EventArgs e)
        {
           
        } 
        private void buttonDPrev_Click(object sender, EventArgs e)
        {
            counter = 0;
            sqlQuery = "SELECT `player_id`, `team_number`, `player_name`, `nation`,`team_name`, `birthdate`, IF(status = 1, 'Available', 'Not Available') as status FROM player_jesslyn p, nationality n, team t WHERE p.nationality_id = n.nationality_id and t.team_id= p.team_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable isiData = new DataTable();
                sqlAdapter.Fill(isiData);
                textBoxID.Text = isiData.Rows[counter][0].ToString();
                textBoxName.Text = isiData.Rows[counter][2].ToString();
                comboBoxNation.SelectedValue = isiData.Rows[counter][3].ToString();
                comboBoxTeam.SelectedValue = isiData.Rows[counter][4].ToString();
                dateTimePickerBdate.Text = isiData.Rows[counter][5].ToString();
                numericUpDownTNumber.Text = isiData.Rows[counter][1].ToString();
                labelAvail.Text = isiData.Rows[counter][6].ToString();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if(counter<=0)
            {
                MessageBox.Show("Ini Data Pertama");
            }
            else
            {
                counter--;
                sqlQuery = "SELECT `player_id`, `team_number`, `player_name`, `nation`,`team_name`, `birthdate`, IF(status = 1, 'Available', 'Not Available') as status FROM player_jesslyn p, nationality n, team t WHERE p.nationality_id = n.nationality_id and t.team_id= p.team_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable isiData = new DataTable();
                sqlAdapter.Fill(isiData);
                textBoxID.Text = isiData.Rows[counter][0].ToString();
                textBoxName.Text = isiData.Rows[counter][2].ToString();
                comboBoxNation.SelectedValue = isiData.Rows[counter][3].ToString();
                comboBoxTeam.SelectedValue = isiData.Rows[counter][4].ToString();
                dateTimePickerBdate.Text = isiData.Rows[counter][5].ToString();
                numericUpDownTNumber.Text = isiData.Rows[counter][1].ToString();
                labelAvail.Text = isiData.Rows[counter][6].ToString();
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (counter >= 858)
            {
                MessageBox.Show("Ini Data Terakhir");
            }
            else
            {
                counter++;
                sqlQuery = "SELECT `player_id`, `team_number`, `player_name`, `nation`,`team_name`, `birthdate`, IF(status = 1, 'Available', 'Not Available') as status FROM player_jesslyn p, nationality n, team t WHERE p.nationality_id = n.nationality_id and t.team_id= p.team_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable isiData = new DataTable();
                sqlAdapter.Fill(isiData);
                textBoxID.Text = isiData.Rows[counter][0].ToString();
                textBoxName.Text = isiData.Rows[counter][2].ToString();
                dateTimePickerBdate.Text = isiData.Rows[counter][5].ToString();
                numericUpDownTNumber.Text = isiData.Rows[counter][1].ToString();
                comboBoxNation.SelectedValue = isiData.Rows[counter][3].ToString();
                comboBoxTeam.SelectedValue = isiData.Rows[counter][4].ToString();
                labelAvail.Text = isiData.Rows[counter][6].ToString();
            }
        }

        private void buttonDNext_Click(object sender, EventArgs e)
        {
            counter = 858;
            sqlQuery = "SELECT `player_id`, `team_number`, `player_name`, `nation`,`team_name`, `birthdate`, IF(status = 1, 'Available', 'Not Available') as status FROM player_jesslyn p, nationality n, team t WHERE p.nationality_id = n.nationality_id and t.team_id= p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable isiData = new DataTable();
            sqlAdapter.Fill(isiData);
            textBoxID.Text = isiData.Rows[counter][0].ToString();
            textBoxName.Text = isiData.Rows[counter][2].ToString();
            comboBoxNation.SelectedValue = isiData.Rows[counter][3].ToString();
            comboBoxTeam.SelectedValue = isiData.Rows[counter][4].ToString();
            dateTimePickerBdate.Text = isiData.Rows[counter][5].ToString();
            numericUpDownTNumber.Text = isiData.Rows[counter][1].ToString();
            labelAvail.Text = isiData.Rows[counter][6].ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (labelAvail.Text == "Not Available")
            {
                MessageBox.Show("Team Number sudah dipakai");
            }
            else
            {
                sqlQuery = "update player set team_number = '" + numericUpDownTNumber.Value.ToString() + "', player_name = '" + textBoxName.Text + "', nationality_id = '" + comboBoxNation.SelectedValue.ToString() + "', birthdate = '" + dateTimePickerBdate.Value.ToString("yyyMMdd") + "', team_id = '" + comboBoxTeam.SelectedValue.ToString() + "' where player_id = '" + textBoxID.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Close();
                MessageBox.Show("Data Player bernama " + textBoxName.Text + " berhasil diupdate.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
