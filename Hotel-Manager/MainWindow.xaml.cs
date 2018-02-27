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

namespace Hotel_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Payment PaymentLibrary = new Payment();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = PaymentLibrary;

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PaymentLibrary.BedBill = 0;
            
            if(sender == SingleBedRadio)
                PaymentLibrary.BedBill += Expenses.SingleBed;

            else if(sender == DoubleBedRadio)
                PaymentLibrary.BedBill += Expenses.DoubleBed;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender == mealChkBx)
                PaymentLibrary.RoomService += Expenses.Meals;

            if (sender == cleanChkBx)
                PaymentLibrary.RoomService += Expenses.Cleaning;

            if (sender == swimmingPoolChkBx)
                PaymentLibrary.Leisures += Expenses.SwimmingPool;

            if (sender == privateBeachChkBx)
                PaymentLibrary.Leisures += Expenses.PrivateBeach;

            if (sender == barChkBx)
                PaymentLibrary.Leisures += Expenses.Bar;
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            int days = ((DateTime)ToDate.SelectedDate - (DateTime)FromDate.SelectedDate).Days;
            PaymentLibrary.CheckedDays = ++days;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender == mealChkBx)
                PaymentLibrary.RoomService -= Expenses.Meals;

            if (sender == cleanChkBx)
                PaymentLibrary.RoomService -= Expenses.Cleaning;

            if (sender == swimmingPoolChkBx)
                PaymentLibrary.Leisures -= Expenses.SwimmingPool;

            if (sender == privateBeachChkBx)
                PaymentLibrary.Leisures -= Expenses.PrivateBeach;

            if (sender == barChkBx)
                PaymentLibrary.Leisures -= Expenses.Bar;
        }
    }
}