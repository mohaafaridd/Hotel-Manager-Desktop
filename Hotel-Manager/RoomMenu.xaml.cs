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
using System.Windows.Shapes;

namespace Hotel_Manager
{
    /// <summary>
    /// Interaction logic for RoomMenu.xaml
    /// </summary>
    public partial class RoomMenu : Window
    {
        List<Button> btnList = new List<Button>();

        public RoomMenu()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            object resource = Application.Current.FindResource("Room");

            int roomStarting = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Button b = new Button();
                    b.Style = (Style)resource;
                    b.Name = $"R{roomStarting++}";

                    btnList.Add(b);

                    b.Click += Button_Click;
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    grid.Children.Add(b);
                }
            }


            //for (int i = 0; i < 128; i++)
            //{
            //    if (RoomAvailability.slots[i] == MarkType.Free)
            //        btnList[i].Background = Brushes.Green;
            //}

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            RoomNumber.Text = btn.Name;
        }
    }
}
