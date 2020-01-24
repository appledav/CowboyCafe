using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe
{
    class PecosPulledPork
    {
        private double _price = 7.50;
        private int _calories = 894;
        private List<string> _specialInstructions = new List<string>();

        private bool _pickles = true;
        private bool _bread = true;

        public double Price
        {
            get => _price;
        }

        public int Calories
        {
            get => _calories;
        }

        public bool Pickles
        {
            get => _pickles;
            set
            {
                _pickles = value;
            }
        }

        public bool Bread
        {
            get => _bread;
            set
            {
                _bread = value;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                if (!_pickles)
                    _specialInstructions.Add("Hold Pickles");

                if (!_bread)
                    _specialInstructions.Add("Hold Bread");
                return _specialInstructions;
            }
            private set { _specialInstructions = value; }
        }

    }
}
