using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayTest;


namespace Arraytest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int[] a =  { 1, 2, 3, 4 , 5 };
            int [] aspettativa = {11,12,13,14, 15};

            int[] obtained = ArrayTest.Array.IncrementoArray(a);

            CollectionAssert.AreEqual(aspettativa, obtained);
            
        }
    }
}
