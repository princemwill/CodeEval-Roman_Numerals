using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using roman_numerals;

    namespace roman_numeral_tests
    {
        [TestClass]
        public class RomanTest
        {
            [TestMethod]
            public void Test1()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "I";

                //act
                var actual = r.ConvertToRoman(1);
                //assert

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test2()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "II";

                //act
                var actual = r.ConvertToRoman(2);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test3()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "III";

                //act
                var actual = r.ConvertToRoman(3);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test4()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "IV";

                //act
                var actual = r.ConvertToRoman(4);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test5()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "V";

                //act
                var actual = r.ConvertToRoman(5);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test6()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "VI";

                //act
                var actual = r.ConvertToRoman(6);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test7()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "VII";

                //act
                var actual = r.ConvertToRoman(7);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test9()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "IX";

                //act
                var actual = r.ConvertToRoman(9);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test10()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "X";

                //act
                var actual = r.ConvertToRoman(10);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test14()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "XIV";

                //act
                var actual = r.ConvertToRoman(14);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test19()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "XIX";

                //act
                var actual = r.ConvertToRoman(19);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test40()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "XL";

                //act
                var actual = r.ConvertToRoman(40);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test44()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "XLIV";

                //act
                var actual = r.ConvertToRoman(44);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test50()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "L";

                //act
                var actual = r.ConvertToRoman(50);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test90()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "XC";

                //act
                var actual = r.ConvertToRoman(90);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test99()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "XCIX";

                //act
                var actual = r.ConvertToRoman(99);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test100()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "C";

                //act
                var actual = r.ConvertToRoman(100);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test400()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "CD";

                //act
                var actual = r.ConvertToRoman(400);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test500()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "D";

                //act
                var actual = r.ConvertToRoman(500);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test900()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "CM";

                //act
                var actual = r.ConvertToRoman(900);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test999()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "CMXCIX";

                //act
                var actual = r.ConvertToRoman(999);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test1000()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "M";

                //act
                var actual = r.ConvertToRoman(1000);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test3000()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "MMM";

                //act
                var actual = r.ConvertToRoman(3000);

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test3999()
            {
                //arrange
                RomanNum r = new RomanNum();
                var expected = "MMMCMXCIX";

                //act
                var actual = r.ConvertToRoman(3999);

                //assert
                Assert.AreEqual(expected, actual);
            }

        }
    }
