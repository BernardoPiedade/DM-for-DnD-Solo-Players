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
    public partial class Pet_Sheet_Edit : Form
    {
        public Pet_Sheet_Edit()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            XmlDocument PetSheetLoad = new XmlDocument();
            PetSheetLoad.Load(filename: "xml\\petsheet.xml");

            XmlNodeList petsheetNameNodeList = PetSheetLoad.GetElementsByTagName("name");
            XmlNodeList petsheetCreatureNodeList = PetSheetLoad.GetElementsByTagName("creature");
            XmlNodeList petsheetSizeNodeList = PetSheetLoad.GetElementsByTagName("size");
            XmlNodeList petsheetAlignmentNodeList = PetSheetLoad.GetElementsByTagName("alignment");
            XmlNodeList petsheetTypeNodeList = PetSheetLoad.GetElementsByTagName("type");
            XmlNodeList petsheetSpeedNodeList = PetSheetLoad.GetElementsByTagName("speed");
            XmlNodeList petsheetAcNodeList = PetSheetLoad.GetElementsByTagName("ac");
            XmlNodeList petsheetStrNodeList = PetSheetLoad.GetElementsByTagName("str");
            XmlNodeList petsheetDexNodeList = PetSheetLoad.GetElementsByTagName("dex");
            XmlNodeList petsheetConNodeList = PetSheetLoad.GetElementsByTagName("con");
            XmlNodeList petsheetIntNodeList = PetSheetLoad.GetElementsByTagName("int");
            XmlNodeList petsheetWisNodeList = PetSheetLoad.GetElementsByTagName("wis");
            XmlNodeList petsheetChaNodeList = PetSheetLoad.GetElementsByTagName("cha");

            foreach (XmlNode node in petsheetNameNodeList)
            {
                Pet_Name_Edit.Text = node.InnerText;
            }

            foreach (XmlNode node in petsheetCreatureNodeList)
            {
                Pet_Creature_Edit.Text = node.InnerText;
            }

            foreach (XmlNode node in petsheetSizeNodeList)
            {
                if(node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_Size_Edit.Value = 0;
                }
                else
                {
                    Pet_Size_Edit.Value = Int32.Parse(node.InnerText);
                }
            }

            foreach (XmlNode node in petsheetAlignmentNodeList)
            {
                Pet_Alignment_Edit.Text = node.InnerText;
            }

            foreach (XmlNode node in petsheetTypeNodeList)
            {
                Pet_Type_Edit.Text = node.InnerText;
            }

            foreach (XmlNode node in petsheetSpeedNodeList)
            {
                if(node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_Speed_Edit.Value = 0;
                }
                else
                {
                    Pet_Speed_Edit.Value = Int32.Parse(node.InnerText);
                }
            }

            foreach (XmlNode node in petsheetAcNodeList)
            {
                if(node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_AC_Edit.Value = 0;
                }
                else
                {
                    Pet_AC_Edit.Value = Int32.Parse(node.InnerText);
                }
            }

            foreach (XmlNode node in petsheetStrNodeList)
            {
                if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_Str_Edit.Value = 0;
                }
                else
                {
                    Pet_Str_Edit.Value = Int32.Parse(node.InnerText);
                }
            }

            foreach (XmlNode node in petsheetDexNodeList)
            {
                if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_Dex_Edit.Value = 0;
                }
                else
                {
                    Pet_Dex_Edit.Value = Int32.Parse(node.InnerText);
                }
            }

            foreach (XmlNode node in petsheetConNodeList)
            {
                if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_Con_Edit.Value = 0;
                }
                else
                {
                    Pet_Con_Edit.Value = Int32.Parse(node.InnerText);
                }
            }

            foreach (XmlNode node in petsheetIntNodeList)
            {
                if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_Int_Edit.Value = 0;
                }
                else
                {
                    Pet_Int_Edit.Value = Int32.Parse(node.InnerText);
                }
            }

            foreach (XmlNode node in petsheetWisNodeList)
            {
                if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_Wis_Edit.Value = 0;
                }
                else
                {
                    Pet_Wis_Edit.Value = Int32.Parse(node.InnerText);
                }
            }

            foreach (XmlNode node in petsheetChaNodeList)
            {
                if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                {
                    Pet_Cha_Edit.Value = 0;
                }
                else
                {
                    Pet_Cha_Edit.Value = Int32.Parse(node.InnerText);
                }
            }
        }

        private void Pet_Sheet_Edit_Save_Click(object sender, EventArgs e)
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

            string name = Pet_Name_Edit.Text;
            string creature = Pet_Creature_Edit.Text;
            string size = Convert.ToString(Pet_Size_Edit.Value);
            string alignment = Pet_Alignment_Edit.Text;
            string type = Pet_Type_Edit.Text;
            string speed = Convert.ToString(Pet_Speed_Edit.Value);
            string ac = Convert.ToString(Pet_AC_Edit.Value);
            string str = Convert.ToString(Pet_Str_Edit.Value);
            string dex = Convert.ToString(Pet_Dex_Edit.Value);
            string con = Convert.ToString(Pet_Con_Edit.Value);
            string petInt = Convert.ToString(Pet_Int_Edit.Value);
            string wis = Convert.ToString(Pet_Wis_Edit.Value);
            string cha = Convert.ToString(Pet_Cha_Edit.Value);

            foreach (XmlNode node in petsheetNameNodeList)
            {
                node.InnerText = name;
            }

            foreach (XmlNode node in petsheetCreatureNodeList)
            {
                node.InnerText = creature;
            }

            foreach (XmlNode node in petsheetSizeNodeList)
            {
                node.InnerText = size;
            }

            foreach (XmlNode node in petsheetAlignmentNodeList)
            {
                node.InnerText = alignment;
            }

            foreach (XmlNode node in petsheetTypeNodeList)
            {
                node.InnerText = type;
            }

            foreach (XmlNode node in petsheetSpeedNodeList)
            {
                node.InnerText = speed;
            }

            foreach (XmlNode node in petsheetAcNodeList)
            {
                node.InnerText = ac;
            }

            foreach (XmlNode node in petsheetStrNodeList)
            {
                node.InnerText = str;
            }

            foreach (XmlNode node in petsheetDexNodeList)
            {
                node.InnerText = dex;
            }

            foreach (XmlNode node in petsheetConNodeList)
            {
                node.InnerText = con;
            }

            foreach (XmlNode node in petsheetIntNodeList)
            {
                node.InnerText = petInt;
            }

            foreach (XmlNode node in petsheetWisNodeList)
            {
                node.InnerText = wis;
            }

            foreach (XmlNode node in petsheetChaNodeList)
            {
                node.InnerText = cha;
            }

            petsheet.Save(filename: "xml\\petsheet.xml");

            new Pet_Sheet().Show();
            this.Close();
        }
    }
}
