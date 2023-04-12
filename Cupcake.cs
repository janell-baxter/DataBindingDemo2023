using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DataBindingDemo2023
{
    public class Cupcake
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public BitmapImage Picture { get; set; }
        public double Price = 2.5;
        public string PriceDetail { get; set; }


        public Cupcake(string _name, string _description, string _path)
        {
            Name = _name;
            Description = _description;
            Picture = new BitmapImage(new Uri(_path, UriKind.Relative));
        }
        public Cupcake() { }


    }
}
