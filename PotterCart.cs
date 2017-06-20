using System;
using System.Collections.Generic;

namespace BooksStore.Models
{
    public class PotterCart
    {
        public PotterCart()
        {
        }

        public int CalculatePrice(Dictionary<int, int> books)
        {
            var totalPrice = 0;
            foreach (var book in books)
            {
                totalPrice += book.Value * 100;
            }
            return totalPrice;
        }
    }
}