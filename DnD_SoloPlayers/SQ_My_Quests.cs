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
using System.Xml.Linq;

namespace DnD_SoloPlayers
{
    public partial class SQ_My_Quests : Form
    {
        
        List<string> questsList = new List<string>();

        public SQ_My_Quests()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);


            XmlDocument quests = new XmlDocument();
            quests.Load(filename: "xml\\my_quests.xml");

            XmlNodeList questNodeList = quests.GetElementsByTagName("quest");

            

            foreach (XmlNode node in questNodeList)
            {
                questsList.Add((node.InnerText).ToString());
            }

            foreach(string n in questsList)
            {
                listBox1.Items.Add(n.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>=0)
                textBox1.Text = questsList.ElementAt(listBox1.SelectedIndex);
        }

        private void Complete_Quest_B_Click(object sender, EventArgs e)
        {

            XmlDocument quests = new XmlDocument();
            quests.Load(filename: "xml\\my_quests.xml");

            // remove from xml
            quests.DocumentElement.RemoveChild(quests.DocumentElement.ChildNodes[listBox1.SelectedIndex]);


            // remove from list box
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            // remove from text box
            textBox1.Text = "";
            
            quests.Save(filename: "xml\\my_quests.xml");
        }
    }
}
