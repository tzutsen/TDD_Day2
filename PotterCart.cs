using System;
using System.Collections.Generic;
using System.Linq;

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
            double totalPrice=0;
            for (int i = books.Min(n => n.Value); i <= books.Max(n => n.Value); i++)
            {
                var priceBeforeDiscount = 0;
                int booksCount = 0;
                foreach (var book in books)
                { 
                    if (book.Value - i >= 0)
                    {
                        priceBeforeDiscount += _unitPrice[book.Key];
                        booksCount ++;
                    }
                }

                totalPrice += priceBeforeDiscount * _discount[booksCount];
            }
            return totalPrice;
        }
    }
}