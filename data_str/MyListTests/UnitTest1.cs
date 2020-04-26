using data;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace data_str
{
    public class Tests
    {
        MyList myList;

        [SetUp]
        public void Setup()
        {
            myList = new MyList();
        }

        [Test]
        public void MyList_test_add_AsssertIsEqual()
        {

            myList.Add(1);
        }
        [Test]
        public void MyList_test_Return_returns_SingleValue1()
        {
            myList.Add(1);

            int result = myList.Get(0);

            Assert.AreEqual(1, result);

        }
        [Test]
        public void MyList_test_Return_returns_SingleValue5()
        {
            myList.Add(5);

            int result = myList.Get(0);

            Assert.AreEqual(5, result);

        }
        [Test]
        public void MyList_test_Add_Multiple_values()
        {
            List<int> expected = new List<int> { 1, 2 };
            List<int> result = new List<int>();

            myList.Add(1);
            myList.Add(2);
            result.Add(myList.Get(1));
            result.Add(myList.Get(2));

            Assert.AreEqual(expected, result);

        }
        [Test]
        public void MyList_test_Add_Multiple_values3()
        {
            List<int> expected = new List<int> { 1, 2, 3 };
            List<int> result = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            result.Add(myList.Get(1));
            result.Add(myList.Get(2));
            result.Add(myList.Get(3));

            Assert.AreEqual(expected, result);

        }
        [Test]
        public void MyList_test_Add_Multiple_values6()
        {
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> result = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            result.Add(myList.Get(1));
            result.Add(myList.Get(2));
            result.Add(myList.Get(3));
            result.Add(myList.Get(4));
            result.Add(myList.Get(5));
            result.Add(myList.Get(6));

            Assert.AreEqual(expected, result);

        }

    }
}