using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe
{
    class RustlersRibs
    {
        private double _price = 7.50;
        private int _calories = 894;
        private List<string> _specialInstructions = null;

        public double Price
        {
            get => _price;
        }

        public int Calories
        {
            get => _calories;
        }

        public List<string> SpecialInstructions
        {
            get => _specialInstructions;
        }

    }
}
