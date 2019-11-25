using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_SoloPlayers
{
    public partial class DB_Roll : Form
    {

        public DB_Roll()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Dice_Roll_Click(object sender, EventArgs e)
        {
            int d4 = Convert.ToInt32(D4_N.Value);
            int d6 = Convert.ToInt32(D6_N.Value);
            int d8 = Convert.ToInt32(D8_N.Value);
            int d10 = Convert.ToInt32(D10_N.Value);
            int d12 = Convert.ToInt32(D12_N.Value);
            int d20 = Convert.ToInt32(D20_N.Value);
            int d100 = Convert.ToInt32(D100_N.Value);
            int plus = Convert.ToInt32(DiceRoll_Plus.Value);
            int minus = Convert.ToInt32(DiceRoll_Minus.Value);

            Random di4 = new Random();
            Random di6 = new Random();
            Random di8 = new Random();
            Random di10 = new Random();
            Random di12 = new Random();
            Random di20 = new Random();
            Random di100 = new Random();

            int sumD4 = 0;
            int sumD6 = 0;
            int sumD8 = 0;
            int sumD10 = 0;
            int sumD12 = 0;
            int sumD20 = 0;
            int sumD100 = 0;

            int[] sumD4Arr = new int[d4];
            int[] sumD6Arr = new int[d6];
            int[] sumD8Arr = new int[d8];
            int[] sumD10Arr = new int[d10];
            int[] sumD12Arr = new int[d12];
            int[] sumD20Arr = new int[d20];
            int[] sumD100Arr = new int[d100];

            //roll d4
            for (int i = 0; i < d4; i++)
            {
                int Di4 = di4.Next(1, 5);
                sumD4Arr[i] = Di4;
                sumD4 += Di4;
            }

            //roll d6
            for(int i = 0;i < d6; i++)
            {
                int Di6 = di6.Next(1, 7);
                sumD6Arr[i] = Di6;
                sumD6 += Di6;
            }

            //roll d8
            for(int i = 0;i < d8; i++)
            {
                int Di8 = di8.Next(1, 9);
                sumD8Arr[i] = Di8;
                sumD8 += Di8;
            }

            //roll d10
            for(int i = 0;i < d10; i++)
            {
                int Di10 = di10.Next(1, 11);
                sumD10Arr[i] = Di10;
                sumD10 += Di10;
            }

            //rol d12
            for(int i = 0;i< d12; i++)
            {
                int Di12 = di12.Next(1, 13);
                sumD12Arr[i] = Di12;
                sumD12 += Di12;
            }

            //roll d20
            for(int i = 0; i < d20; i++)
            {
                int Di20 = di20.Next(1, 21);
                sumD20Arr[i] = Di20;
                sumD20 += Di20;
            }

            //roll d100
            for(int i = 0;i< d100; i++)
            {
                int Di100 = di100.Next(0, 10);
                if(Di100 == 1)
                {
                    Di100 = 0 + 10;
                }
                else if(Di100 == 2)
                {
                    Di100 = 0 + 20;
                }
                else if (Di100 == 3)
                {
                    Di100 = 0 + 30;
                }
                else if (Di100 == 4)
                {
                    Di100 = 0 + 40;
                }
                else if (Di100 == 5)
                {
                    Di100 = 0 + 50;
                }
                else if (Di100 == 6)
                {
                    Di100 = 0 + 60;
                }
                else if (Di100 == 7)
                {
                    Di100 = 0 + 70;
                }
                else if (Di100 == 8)
                {
                    Di100 = 0 + 80;
                }
                else if (Di100 == 9)
                {
                    Di100 = 0 + 90;
                }
                sumD100Arr[i] = Di100;
                sumD100 += Di100;
            }

            List<int> tempList = new List<int>();
            tempList.AddRange(sumD4Arr);
            tempList.AddRange(sumD6Arr);
            tempList.AddRange(sumD8Arr);
            tempList.AddRange(sumD10Arr);
            tempList.AddRange(sumD12Arr);
            tempList.AddRange(sumD20Arr);
            tempList.AddRange(sumD100Arr);

            int[] arr = tempList.ToArray();

            string q = "";

            foreach(int r in arr)
            {
                q = String.Join(" + ", arr);
            }

            int result = sumD4 + sumD6 + sumD8 + sumD10 + sumD12 + sumD20 + sumD100;
            
            string finalresult = "";

            if (plus > 0)
            {
                finalresult = (result + plus).ToString();
                Dice_Values.Text = q + " + (" + plus + ")";
                Result_Label.Text = finalresult.ToString();
            }
            else if(minus > 0)
            {
                finalresult = (result - minus).ToString();
                Dice_Values.Text = q + " - (" + minus + ")";
                Result_Label.Text = finalresult.ToString();
            }
            else
            {
                Dice_Values.Text = q;
                Result_Label.Text = result.ToString();
            } 
        }
    }
}
