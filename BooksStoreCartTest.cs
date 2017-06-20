using Microsoft.VisualStudio.TestTools.UnitTesting;
using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.Models.Tests
{
    [TestClass()]
    public class PotterCartTests
    {
        private Dictionary<int, int> _books = new Dictionary<int, int>();

        [TestMethod]
        public void 第一集買了一本_其他都沒買_價格應為100()
        {
            // arrange
            _books.Add(1, 1);//key：第1集，value：1本

            var target = new PotterCart();
            // act
            //程式計算的結果
            int actual = target.CalculatePrice(_books);
            //應該得到的結果
            int expected = 100;

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void 第一集買了一本_第二集也買了一本_價格應為190()
        {
            // arrange
            _books.Add(1, 1);//key：第1集，value：1本
            _books.Add(2, 1);//key：第2集，value：1本

            var target = new PotterCart();
            // act
            //程式計算的結果
            int actual = target.CalculatePrice(_books);
            //應該得到的結果
            int expected = 190;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}