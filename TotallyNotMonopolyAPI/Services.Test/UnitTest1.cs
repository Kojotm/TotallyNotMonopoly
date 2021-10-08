using Model;
using NUnit.Framework;
using System;

namespace Services.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
            
        }

        [Test]
        public void TestJsonFile()
        {
            Class1 class1 = new Class1();
            var aux = class1.LoadJson();
            foreach (var item in aux)
            {
                Console.WriteLine("{0}\n{1}", item.name, item.text);
            }
            
            //Assert.Pass();
            
        }
    }
}