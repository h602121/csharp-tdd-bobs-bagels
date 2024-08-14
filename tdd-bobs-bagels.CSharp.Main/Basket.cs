using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {

        private int _capacity {  get; set; }
        private List<string> _bagels { get; set; }

        public Basket (int capacity, List<string> bagels)
        {
            _capacity = capacity;
            _bagels = bagels;
        }

        public bool AddBagel(string bagel)
        {
            if (_bagels.Contains(bagel) || _bagels.Count >= _capacity) {  return false; }
            
            _bagels.Add(bagel);
            return true;
        }

        public int changeCapacity(int maxCapacity)
        {
            _capacity = maxCapacity;
            return _capacity;
        }

        public bool removeBagel(string bagel)
        {
            if (_bagels.Contains(bagel))
            {
                return true;
            }
            return false;
        }
    }
}
