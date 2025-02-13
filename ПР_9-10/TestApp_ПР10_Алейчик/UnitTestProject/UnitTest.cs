﻿using System;
using TestApp.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SredneeReturnAndGeneralDiagonal()
        {
            //arrange
            int expected = 5;
            //act
            var quad = new QuadMatrix(Matrix5to5, 5);

            int actual = quad.SredneeElementMatrix();
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Zamena()
        {
            //arrange
            int expected = 5;
            //act
            var quad = new QuadMatrix(Matrix5to5, 5);

            int actual = quad.Zamena();
            //assert
            Assert.AreEqual(expected, actual);
        }



        public int[,] Matrix5to5
        {
            get
            {
                int[,] matr = {
                                 {0, 1, 3, 6, 9},
                                 {5, 0, 3, 1, 9},
                                 {8, 3, 5, 0, 1},
                                 {20, 1, 0, 30, 9},
                                 {4, 1, 3, 9, 5}
                                };
                return matr;
            }
        }
    }
}
