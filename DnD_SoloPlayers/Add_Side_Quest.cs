using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace DnD_SoloPlayers
{
    public partial class Add_Side_Quest : Form
    {
        public Add_Side_Quest()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void SD_Send_Click(object sender, EventArgs e)
        {
            string uID = "";
            string ConnectionString = "Server=sv1.byethost1.org; Port=3306; Database=bxxxirep_UsageTrack; Uid=bxxxirep_UsageTr; Pwd=S%W$Kv&E4j%LqVfaH,";
            string text = Quest_Text.Text;
            string user_name = User_name.Text;

            XmlDocument userid = new XmlDocument();
            userid.Load(filename: "xml\\user\\userId.xml");

            XmlNodeList idX = userid.GetElementsByTagName("userId");

            foreach (XmlNode node in idX)
            {
                uID = node.InnerText;
            }

            if (!text.Equals(""))
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        MySqlCommand send = new MySqlCommand("INSERT INTO quests (quest_text, user_name,user_id,Accepted) VALUES ('" + text + "','" + user_name + "','"+uID+"',0)", conn);
                        send.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Quest sent to database sucessfully!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Couldn't connect with database, please try later.\n\nIf the problem continues, let us know so we can look into it.");
                }
            }
            else if (text.Length < 10)
            {
                MessageBox.Show("That side quest is to short, give us more information.");
            }
            else
            {
                MessageBox.Show("You must write something first!");
            }
        }
    }
}
