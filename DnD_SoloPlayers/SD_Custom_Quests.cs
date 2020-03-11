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

namespace DnD_SoloPlayers
{
    public partial class SD_Custom_Quests : Form
    {
        public SD_Custom_Quests()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Roll_Side_Quest_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=sv1.byethost1.org; Port=3306; Database=bxxxirep_UsageTrack; Uid=bxxxirep_UsageTr; Pwd=S%W$Kv&E4j%LqVfaH,";
            int max = 0;
            string text = "";
            string user_name = "";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (MySqlCommand getMax = new MySqlCommand("SELECT COUNT(id) AS id FROM quests WHERE Accepted = 1", conn))
                    {
                        MySqlDataReader reader = getMax.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                max = reader.GetInt32(reader.GetOrdinal("id"));
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }

                Random rnd = new Random();
                int select = rnd.Next(1,max+1);

                using (MySqlConnection conn2 = new MySqlConnection(ConnectionString))
                {
                    conn2.Open();

                    using (MySqlCommand getSD = new MySqlCommand("SELECT * FROM quests WHERE id = " + select + "", conn2))
                    {
                        MySqlDataReader reader = getSD.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                text = (string)reader["quest_text"];
                                user_name = (string)reader["user_name"];
                            }
                        }
                        reader.Close();
                    }
                    conn2.Close();
                }

                if((user_name.Equals("")) || (user_name.Equals(" ")))
                {
                    user_name = "Anonymous";
                }

                textBox1.Text = text + "\r\n\r\nQuest sent by: "+user_name;
            }
            catch(Exception r)
            {
                MessageBox.Show(r.ToString());
            }
        }

        private void Add_Side_Quest_Click(object sender, EventArgs e) => new Add_Side_Quest().Show();
    }
}
