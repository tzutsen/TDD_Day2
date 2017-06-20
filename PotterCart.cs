using System;
using System.Collections.Generic;

namespace BooksStore.Models
{
    public class PotterCart
    {
        //各集數金額
        private Dictionary<int, int> _unitPrice = new Dictionary<int, int>()
        {
            {1, 100},
            {2, 100},
            {3, 100},
            {4, 100},
            {5, 100}
        };

        //折扣
        private Dictionary<int, double> _discount = new Dictionary<int, double>()
        {
            {1, 1.00},
            {2, 0.95},
            {3, 0.90},
            {4, 0.80},
            {5, 0.75}
        };
        
        public double CalculatePrice(Dictionary<int, int> books)
        {
            var booksCount = 0;
            var priceBeforeDiscount = 0;
            foreach (var book in books)
            {
                priceBeforeDiscount += _unitPrice[book.Key];
                booksCount++;
            }
            double totalPrice = priceBeforeDiscount * _discount[booksCount];
            return totalPrice;
        }
    }
}