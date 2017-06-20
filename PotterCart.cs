using System;
using System.Collections.Generic;

namespace BooksStore.Models
{
    public class PotterCart
    {
        private Dictionary<int, int> _unitPrice = new Dictionary<int, int>();
        private Dictionary<int, double> _discount = new Dictionary<int, double>();

        public PotterCart()
        {
            _unitPrice.Add(1,100);
            _discount.Add(1,1);
        }

        public PotterCart(Dictionary<int, int> price, Dictionary<int, double> discount)
        {
            _unitPrice = price;
            _discount = discount;
        }

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