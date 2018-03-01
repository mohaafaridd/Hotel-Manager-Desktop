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

        /// <summary>
        /// Radio Button controling single and double room beds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PaymentLibrary.BedBill = 0;

            if (sender == SingleBedRadio)
                PaymentLibrary.BedBill += Expenses.SingleBed;

            else if (sender == DoubleBedRadio)
                PaymentLibrary.BedBill += Expenses.DoubleBed;

        }

        /// <summary>
        /// Adds money cost to the total money in case of checking a new feature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Reducing money cost from the total money in case of unchecking the chosen feature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Calculating the days count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            int days = ((DateTime)ToDate.SelectedDate - (DateTime)FromDate.SelectedDate).Days;
            PaymentLibrary.CheckedDays = ++days;
        }

        /// <summary>
        /// Adds the value of internet's money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntegerUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var holder0 = (Xceed.Wpf.Toolkit.IntegerUpDown)sender;

            PaymentLibrary.Internet = (((decimal)holder0.Value) * Expenses.Internet);
        }

        /// <summary>
        /// Adds function to buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDays_Click(object sender, RoutedEventArgs e)
        {
            if (sender == sevenDays)
                ToDate.SelectedDate = FromDate.SelectedDate + TimeSpan.FromDays(7);

            else if(sender == twoWeeks)
                ToDate.SelectedDate = FromDate.SelectedDate + TimeSpan.FromDays(14);

            else if(sender == applyCustom)
            {
                int days = (int)customDays.Value;
                ToDate.SelectedDate = FromDate.SelectedDate + TimeSpan.FromDays(days);
            }
        }
    }
}