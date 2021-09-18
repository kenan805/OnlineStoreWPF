using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreWPF
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
            }
        }

    }
}
