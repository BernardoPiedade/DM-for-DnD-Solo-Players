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
    public partial class Pet_Sheet : Form
    {

        static int hp = 0;
        

        public Pet_Sheet()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            try
            {
                XmlDocument petsheet = new XmlDocument();
                petsheet.Load(filename: "xml\\petsheet.xml");

                XmlNodeList petsheetNameNodeList = petsheet.GetElementsByTagName("name");
                XmlNodeList petsheetCreatureNodeList = petsheet.GetElementsByTagName("creature");
                XmlNodeList petsheetSizeNodeList = petsheet.GetElementsByTagName("size");
                XmlNodeList petsheetAlignmentNodeList = petsheet.GetElementsByTagName("alignment");
                XmlNodeList petsheetTypeNodeList = petsheet.GetElementsByTagName("type");
                XmlNodeList petsheetSpeedNodeList = petsheet.GetElementsByTagName("speed");
                XmlNodeList petsheetAcNodeList = petsheet.GetElementsByTagName("ac");
                XmlNodeList petsheetStrNodeList = petsheet.GetElementsByTagName("str");
                XmlNodeList petsheetDexNodeList = petsheet.GetElementsByTagName("dex");
                XmlNodeList petsheetConNodeList = petsheet.GetElementsByTagName("con");
                XmlNodeList petsheetIntNodeList = petsheet.GetElementsByTagName("int");
                XmlNodeList petsheetWisNodeList = petsheet.GetElementsByTagName("wis");
                XmlNodeList petsheetChaNodeList = petsheet.GetElementsByTagName("cha");

                string open = "";
                string name = "";
                string creature = "";
                string size = "";
                string alignment = "";
                string type = "";
                string speed = "";
                string ac = "";
                string str = "";
                string dex = "";
                string con = "";
                string petInt = "";
                string wis = "";
                string cha = "";

                if (open.Equals(""))
                {
                    foreach (XmlNode node in petsheetNameNodeList)
                    {
                        name = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetCreatureNodeList)
                    {
                        creature = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetSizeNodeList)
                    {
                        size = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetAlignmentNodeList)
                    {
                        alignment = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetTypeNodeList)
                    {
                        type = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetSpeedNodeList)
                    {
                        speed = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetAcNodeList)
                    {
                        ac = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetStrNodeList)
                    {
                        str = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetDexNodeList)
                    {
                        dex = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetConNodeList)
                    {
                        con = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetIntNodeList)
                    {
                        petInt = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetWisNodeList)
                    {
                        wis = node.InnerText;
                    }

                    foreach (XmlNode node in petsheetChaNodeList)
                    {
                        cha = node.InnerText;
                    }

                    if (name.Length > 0 || creature.Length > 0 || size.Length > 0 || alignment.Length > 0 || type.Length > 0 || speed.Length > 0 || ac.Length > 0 || str.Length > 0 || dex.Length > 0 || con.Length > 0 || petInt.Length > 0 || wis.Length > 0 || cha.Length > 0)
                    {
                        Pet_Name_Label.Text = name;
                        Pet_Creature_Label.Text = creature;
                        Pet_Size_Label.Text = size;
                        Pet_Alignment_Label.Text = alignment;
                        Pet_Type_Label.Text = type;
                        Pet_Speed_Label.Text = speed;
                        Pet_AC_Label.Text = ac;
                        Pet_Str_Label.Text = str;
                        Pet_Dex_Label.Text = dex;
                        Pet_Con_Label.Text = con;
                        Pet_Int_Label.Text = petInt;
                        Pet_Wis_Label.Text = wis;
                        Pet_Cha_Label.Text = cha;
                    }
                    else
                    {
                        Pet_Name_Label.Text = "No name found!";
                        Pet_Creature_Label.Text = "";
                        Pet_Size_Label.Text = "0";
                        Pet_Alignment_Label.Text = "";
                        Pet_Type_Label.Text = "";
                        Pet_Speed_Label.Text = "0";
                        Pet_AC_Label.Text = "0";
                        Pet_Str_Label.Text = "0";
                        Pet_Dex_Label.Text = "0";
                        Pet_Con_Label.Text = "0";
                        Pet_Int_Label.Text = "0";
                        Pet_Wis_Label.Text = "0";
                        Pet_Cha_Label.Text = "0";
                    }
                }
            }
            catch
            {
                Pet_Name_Label.Text = "No name found!";
                Pet_Creature_Label.Text = "";
                Pet_Size_Label.Text = "0";
                Pet_Alignment_Label.Text = "";
                Pet_Type_Label.Text = "";
                Pet_Speed_Label.Text = "0";
                Pet_AC_Label.Text = "0";
                Pet_Str_Label.Text = "0";
                Pet_Dex_Label.Text = "0";
                Pet_Con_Label.Text = "0";
                Pet_Int_Label.Text = "0";
                Pet_Wis_Label.Text = "0";
                Pet_Cha_Label.Text = "0";
            }
            HP_Value.Text = hp.ToString();
        }

        

        private void Pet_Sheet_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
            new Pet_Sheet_Edit().Show();
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
    }
}
