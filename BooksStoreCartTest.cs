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
        //買的書
        private Dictionary<int, int> _books = new Dictionary<int, int>();

        [TestMethod]
        public void 第一集買了一本_其他都沒買_價格應為100()
        {
            // arrange
            _books.Add(1, 1);//key：第1集，value：1本

            var target = new PotterCart();
            // act
            //程式計算的結果
            var actual = target.CalculatePrice(_books);
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
            var actual = target.CalculatePrice(_books);
            //應該得到的結果
            int expected = 190;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三集各買了一本_價格應為_270()
        {
            // arrange
            _books.Add(1, 1);//key：第1集，value：1本
            _books.Add(2, 1);//key：第2集，value：1本
            _books.Add(3, 1);//key：第3集，value：1本

            var target = new PotterCart();
            // act
            //程式計算的結果
            var actual = target.CalculatePrice(_books);
            //應該得到的結果
            int expected = 270;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四集各買了一本_價格應為320()
        {
            // arrange
            _books.Add(1, 1);//key：第1集，value：1本
            _books.Add(2, 1);//key：第2集，value：1本
            _books.Add(3, 1);//key：第3集，value：1本
            _books.Add(4, 1);//key：第4集，value：1本

            var target = new PotterCart();
            // act
            //程式計算的結果
            var actual = target.CalculatePrice(_books);
            //應該得到的結果
            int expected = 320;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四五集各買了一本_價格應為_375()
        {
            // arrange
            _books.Add(1, 1);//key：第1集，value：1本
            _books.Add(2, 1);//key：第2集，value：1本
            _books.Add(3, 1);//key：第3集，value：1本
            _books.Add(4, 1);//key：第4集，value：1本
            _books.Add(5, 1);//key：第5集，value：1本

            var target = new PotterCart();
            // act
            //程式計算的結果
            var actual = target.CalculatePrice(_books);
            //應該得到的結果
            int expected = 375;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}