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

namespace DnD_SoloPlayers
{
    public partial class P_Sheet : Form
    {
        static int hp = 30;

        public P_Sheet()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            try
            {
                XmlDocument playerSheet = new XmlDocument();
                playerSheet.Load(filename: "xml\\playersheet.xml");

                XmlNodeList playerSheetNameNodeList = playerSheet.GetElementsByTagName("name");
                XmlNodeList playerSheetLevelNodeList = playerSheet.GetElementsByTagName("level");
                XmlNodeList playerSheetAcNodeList = playerSheet.GetElementsByTagName("ac");
                XmlNodeList playerSheetClassNodeList = playerSheet.GetElementsByTagName("class");
                XmlNodeList playerSheetRaceNodeList = playerSheet.GetElementsByTagName("race");
                XmlNodeList playerSheetStrNodeList = playerSheet.GetElementsByTagName("str");
                XmlNodeList playerSheetDexNodeList = playerSheet.GetElementsByTagName("dex");
                XmlNodeList playerSheetConNodeList = playerSheet.GetElementsByTagName("con");
                XmlNodeList playerSheetIntNodeList = playerSheet.GetElementsByTagName("int");
                XmlNodeList playerSheetWisNodeList = playerSheet.GetElementsByTagName("wis");
                XmlNodeList playerSheetChaNodeList = playerSheet.GetElementsByTagName("cha");

                string open = "";
                string name = "";
                string level = "";
                string charclass = "";
                string race = "";
                string ac = "";
                string str = "";
                string dex = "";
                string con = "";
                string charint = "";
                string wis = "";
                string cha = "";

                if (open.Equals(""))
                {
                    foreach (XmlNode node in playerSheetNameNodeList)
                    {
                        name = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetLevelNodeList)
                    {
                        level = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetAcNodeList)
                    {
                        ac = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetClassNodeList)
                    {
                        charclass = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetRaceNodeList)
                    {
                        race = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetStrNodeList)
                    {
                        str = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetDexNodeList)
                    {
                        dex = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetConNodeList)
                    {
                        con = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetIntNodeList)
                    {
                        charint = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetWisNodeList)
                    {
                        wis = node.InnerText;
                    }

                    foreach (XmlNode node in playerSheetChaNodeList)
                    {
                        cha = node.InnerText;
                    }

                    if (name.Length > 0 || level.Length > 0 || ac.Length > 0 || charclass.Length > 0 || race.Length > 0 || str.Length > 0 || dex.Length > 0 || con.Length > 0 || charint.Length > 0 || wis.Length > 0 || cha.Length > 0)
                    {
                        PS_Name_Label.Text = name;
                        PS_LvL_Label.Text = level;
                        PS_AC_Label.Text = ac;
                        PS_Class_Label.Text = charclass;
                        Race_Value.Text = race;
                        PS_Str_Label.Text = str;
                        PS_Dex_Label.Text = dex;
                        PS_Con_Label.Text = con;
                        PS_Int_Label.Text = charint;
                        PS_Wis_Label.Text = wis;
                        PS_Cha_Label.Text = cha;
                    }
                    else
                    {
                        PS_Name_Label.Text = "No name found!";
                        PS_LvL_Label.Text = "0";
                        PS_AC_Label.Text = "0";
                        PS_Class_Label.Text = "No class found!";
                        Race_Value.Text = "No race found!";
                        PS_Str_Label.Text = "0";
                        PS_Dex_Label.Text = "0";
                        PS_Con_Label.Text = "0";
                        PS_Int_Label.Text = "0";
                        PS_Wis_Label.Text = "0";
                        PS_Cha_Label.Text = "0";
                    }

                }
            }
            catch
            {
                PS_Name_Label.Text = "No name found";
                PS_LvL_Label.Text = "0";
                PS_AC_Label.Text = "0";
                PS_Class_Label.Text = "No class found!";
                Race_Value.Text = "No race found!";
            }

            HP_Value.Text = hp.ToString();
        }

        private void HP_M_5_Click(object sender, EventArgs e)
        {
            hp -= 5;
            HP_Value.Text = hp.ToString();
        }

        private void HP_M_1_Click(object sender, EventArgs e)
        {
            hp -= 1;
            HP_Value.Text = hp.ToString();
        }

        private void HP_P_1_Click(object sender, EventArgs e)
        {
            hp += 1;
            HP_Value.Text = hp.ToString();
        }

        private void HP_P_5_Click(object sender, EventArgs e)
        {
            hp += 5;
            HP_Value.Text = hp.ToString();
        }

        private void PS_Edit_Button_Click(object sender, EventArgs e) => new PS_Edit().Show();

        private void Generate_PlayerSheet_Click(object sender, EventArgs e)
        {
            PS_Name_Label.Text = CharNameList.SelectCharNameList();
            PS_LvL_Label.Text = "1";
            PS_AC_Label.Text = "10";
            PS_Class_Label.Text = CharNameList.SelectCharClassList();
            Race_Value.Text = CharNameList.SelectCharRaceList();

            //roll stats

            int[] arr = new int[6];
            Random stat = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int newStat = stat.Next(3, 19);

                arr[i] = newStat;
            }

            //set stats
            PS_Str_Label.Text = arr[0].ToString();
            PS_Dex_Label.Text = arr[1].ToString();
            PS_Con_Label.Text = arr[2].ToString();
            PS_Int_Label.Text = arr[3].ToString();
            PS_Wis_Label.Text = arr[4].ToString();
            PS_Cha_Label.Text = arr[5].ToString();

            hp = 0;
            HP_Value.Text = hp.ToString();

            XmlDocument playerSheet = new XmlDocument();
            playerSheet.Load(filename: "xml\\playersheet.xml");

            XmlNodeList playerSheetNameNodeList = playerSheet.GetElementsByTagName("name");
            XmlNodeList playerSheetLevelNodeList = playerSheet.GetElementsByTagName("level");
            XmlNodeList playerSheetAcNodeList = playerSheet.GetElementsByTagName("ac");
            XmlNodeList playerSheetClassNodeList = playerSheet.GetElementsByTagName("class");
            XmlNodeList playerSheetRaceNodeList = playerSheet.GetElementsByTagName("race");
            XmlNodeList playerSheetStrNodeList = playerSheet.GetElementsByTagName("str");
            XmlNodeList playerSheetDexNodeList = playerSheet.GetElementsByTagName("dex");
            XmlNodeList playerSheetConNodeList = playerSheet.GetElementsByTagName("con");
            XmlNodeList playerSheetIntNodeList = playerSheet.GetElementsByTagName("int");
            XmlNodeList playerSheetWisNodeList = playerSheet.GetElementsByTagName("wis");
            XmlNodeList playerSheetChaNodeList = playerSheet.GetElementsByTagName("cha");

            string name = PS_Name_Label.Text;
            string level = PS_LvL_Label.Text;
            string charclass = PS_Class_Label.Text;
            string race = Race_Value.Text;
            string ac = PS_AC_Label.Text;
            string str = arr[0].ToString();
            string dex = arr[1].ToString();
            string con = arr[2].ToString();
            string charint = arr[3].ToString();
            string wis = arr[4].ToString();
            string cha = arr[5].ToString();

            foreach (XmlNode node in playerSheetNameNodeList)
            {
                node.InnerText = name;
            }

            foreach (XmlNode node in playerSheetLevelNodeList)
            {
                node.InnerText = level;
            }

            foreach (XmlNode node in playerSheetAcNodeList)
            {
                node.InnerText = ac;
            }

            foreach (XmlNode node in playerSheetClassNodeList)
            {
                node.InnerText = charclass;
            }

            foreach (XmlNode node in playerSheetRaceNodeList)
            {
                node.InnerText = race;
            }

            foreach (XmlNode node in playerSheetStrNodeList)
            {
                node.InnerText = str;
            }

            foreach (XmlNode node in playerSheetDexNodeList)
            {
                node.InnerText = dex;
            }

            foreach (XmlNode node in playerSheetConNodeList)
            {
                node.InnerText = con;
            }

            foreach (XmlNode node in playerSheetIntNodeList)
            {
                node.InnerText = charint;
            }

            foreach (XmlNode node in playerSheetWisNodeList)
            {
                node.InnerText = wis;
            }

            foreach (XmlNode node in playerSheetChaNodeList)
            {
                node.InnerText = cha;
            }

            playerSheet.Save(filename: "xml\\playersheet.xml");

        }
    }
}
