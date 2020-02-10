using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DungeonCrawler_UserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        static List<string> YouFound = new List<string>();
        static Random rnd = new Random();
        static int x = rnd.Next(0, 950);
        static int y = rnd.Next(0, 500);
        static List<string> ImageNum = new List<string>();

        public UserControl1()
        {
            InitializeComponent();

            YouFound.Add("This room looks empty... Oh, wait.. nope, you're going to have a fight... Geezz two Giant Badger.");
            YouFound.Add("You look around, yep, the room is empty.");
            YouFound.Add("Finally something good, you just found a chest!\r\nAh! It's a Mimic, bad luck.");
            YouFound.Add("As soon as you enter, the room fills with a dim light, you're safe here.\r\nIt looks like a good place to take a short rest.");
            YouFound.Add("This room is completely empty. Not that I wanted, but I had to make some empty rooms to \"make it fair\"");

            ImageNum.Add("img\\tile.png");
            ImageNum.Add("img\\tile2.png");
            ImageNum.Add("img\\tile3.png");
            ImageNum.Add("img\\tile4.png");
            ImageNum.Add("img\\tile5.png");

            Rectangle rect;
            rect = new Rectangle();
            rect.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(@"img\\tile2.png", UriKind.Relative)) };
            rect.Width = 50;
            rect.Height = 50;
            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            canvas.Children.Add(rect);

            textbox.Text = "You ready to start?\r\nUse your arrow keys. Where are you going?\r\nUp? Down? Right? Left?";
        }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Up)
            {


                if (y-50 >= 0)
                {
                    y -= 50;

                    Rectangle rect;
                    rect = new Rectangle();
                    int randImg = rnd.Next(0, ImageNum.Count());
                    string imgUri = ImageNum[randImg].ToString();
                    rect.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(imgUri, UriKind.Relative)) };
                    rect.Width = 50;
                    rect.Height = 50;
                    Canvas.SetLeft(rect, x);
                    Canvas.SetTop(rect, y);
                    canvas.Children.Add(rect);

                    int textSelected = rnd.Next(0, YouFound.Count());

                    textbox.Text = YouFound[textSelected].ToString();
                }
            }
            else if(e.Key == Key.Down)
            {

                if(y+50 <= 500)
                {
                    y += 50;

                    Rectangle rect;
                    rect = new Rectangle();
                    int randImg = rnd.Next(0, ImageNum.Count());
                    string imgUri = ImageNum[randImg].ToString();
                    rect.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(imgUri, UriKind.Relative)) };
                    rect.Width = 50;
                    rect.Height = 50;
                    Canvas.SetLeft(rect, x);
                    Canvas.SetTop(rect, y);
                    canvas.Children.Add(rect);

                    int textSelected = rnd.Next(0, YouFound.Count());

                    textbox.Text = YouFound[textSelected].ToString();
                }
            }
            else if(e.Key == Key.Left)
            {

                if(x-50 >= 0)
                {
                    x -= 50;

                    Rectangle rect;
                    rect = new Rectangle();
                    int randImg = rnd.Next(0, ImageNum.Count());
                    string imgUri = ImageNum[randImg].ToString();
                    rect.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(imgUri, UriKind.Relative)) };
                    rect.Width = 50;
                    rect.Height = 50;
                    Canvas.SetLeft(rect, x);
                    Canvas.SetTop(rect, y);
                    canvas.Children.Add(rect);

                    int textSelected = rnd.Next(0, YouFound.Count());

                    textbox.Text = YouFound[textSelected].ToString();
                }
            }
            else if(e.Key == Key.Right)
            {

                if(x+50 <= 950)
                {
                    x += 50;

                    Rectangle rect;
                    rect = new Rectangle();
                    int randImg = rnd.Next(0, ImageNum.Count());
                    string imgUri = ImageNum[randImg].ToString();
                    rect.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(imgUri, UriKind.Relative)) };
                    rect.Width = 50;
                    rect.Height = 50;
                    Canvas.SetLeft(rect, x);
                    Canvas.SetTop(rect, y);
                    canvas.Children.Add(rect);

                    int textSelected = rnd.Next(0, YouFound.Count());

                    textbox.Text = YouFound[textSelected].ToString();
                }
            }
        }
    }
}
