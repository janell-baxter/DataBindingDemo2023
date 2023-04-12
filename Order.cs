using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo2023
{
    public class Order : INotifyPropertyChanged
    {
        public List<Cupcake> Items = new List<Cupcake>();
        public event PropertyChangedEventHandler PropertyChanged;
        private string details = "";
        public string Details
        {
            get { return details; }
            set
            {
                details = value;
                OnPropertyChanged();
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string indexDetails = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(indexDetails));
        }
        public Order()
        {
            OrderDetails();
        }

        public void OrderDetails()
        {
            double total = 0;
            string temp = $"{Environment.NewLine}--------------------{Environment.NewLine}";
            foreach (Cupcake c in Items)
            {
                total += c.Price;
                temp += $"{c.PriceDetail} {c.Name} {Environment.NewLine}";
            }

            Details = $"Total: {total.ToString("c")}" + temp;

        }
    }
}
