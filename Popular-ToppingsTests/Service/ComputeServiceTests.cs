using Microsoft.VisualStudio.TestTools.UnitTesting;
using Popular_Toppings.Model;
using Popular_Toppings.Service;
using Popular_ToppingsTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popular_Toppings.Service.Tests
{
    [TestClass()]
    public class ComputeServiceTests
    {
        [TestMethod()]
        public void GetAllToppingsTest()
        {

            TestData _testData = new TestData();
            IComputeService _service = new ComputeService(TestData.Pizzas);
            var allToppings = _service.GetAllToppings();
            Assert.AreEqual(2 , allToppings.Count());
        }

        [TestMethod()]
        public void GetAllToppingsTestWhenEmptyPassed()
        {
            var PizzaList = new List<Pizza>() { };
            IComputeService _service = new ComputeService(PizzaList);
            var allToppings = _service.GetAllToppings();
            Assert.AreEqual(0, allToppings.Count());
        }

        [TestMethod()]
        public void GetPopularToppingsTest()
        {
            TestData _testData = new TestData();
            IComputeService _service = new ComputeService(TestData.Pizzas);
            var PopularTopping = _service.GetPopularToppings(_service.GetAllToppings(), 1);
            Assert.AreEqual("pepperoni,sausage", PopularTopping.ToList()[0].toppings);
        }

        [TestMethod()]
        public void GetPopularToppingsTestWhenEmpty()
        {
            var PizzaList = new List<Pizza>() { };
            IComputeService _service = new ComputeService(PizzaList);
            var PopularTopping = _service.GetPopularToppings(_service.GetAllToppings(), 10);
            Assert.AreEqual(0, PopularTopping.Count());
        }

        [TestMethod()]
        public void GetPopularToppingsTestWhenTopIsLargerThanListCount()
        {
            int top = 10;
            TestData _testData = new TestData();
            IComputeService _service = new ComputeService(TestData.Pizzas);
            var PopularTopping = _service.GetPopularToppings(_service.GetAllToppings(), top);
            Assert.AreEqual(2, PopularTopping.Count());
        }
    }
}