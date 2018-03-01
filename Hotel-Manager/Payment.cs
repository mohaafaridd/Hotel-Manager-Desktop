using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    class Payment : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #region Total Payment
        private decimal totalPayment;

        public decimal TotalPayment
        {
            get { return totalPayment = (bedBill + roomService + leisures + internet) * checkedDays; }
            set
            {
                totalPayment = value;
                NotifyPropertyChanged("TotalPayment");
            }
        }
        #endregion

        #region Beds Payment
        private decimal bedBill;

        public decimal BedBill
        {
            get { return bedBill; }
            set
            {
                bedBill = value;
                NotifyPropertyChanged("TotalPayment");
            }
        }
        #endregion

        #region Room Service Payment
        private decimal roomService;

        public decimal RoomService
        {
            get { return roomService; }
            set
            {
                roomService = value;
                NotifyPropertyChanged("TotalPayment");
            }
        }
        #endregion

        #region Leisures Payment
        private decimal leisures;

        public decimal Leisures
        {
            get { return leisures; }
            set
            {
                leisures = value;
                NotifyPropertyChanged("TotalPayment");
            }
        }
        #endregion

        #region Checked Days
        private int checkedDays;

        public int CheckedDays
        {
            get { return checkedDays = 1; }
            set
            {
                checkedDays = value;
                NotifyPropertyChanged("TotalPayment");
            }
        }
        #endregion

        #region Internet
        private decimal internet;

        public decimal Internet
        {
            get { return internet; }
            set
            {
                internet = value;
                NotifyPropertyChanged("TotalPayment");
            }
        }
        #endregion

    }
}
