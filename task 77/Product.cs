using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_77
{
    internal class Product
    {
        private double _price;
        private int _count;
        public int No { get; set; }
        public string Name { get; set; }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

    }

}
