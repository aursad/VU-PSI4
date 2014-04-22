using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Core.Decorator;
using App.Core.Decorator.Worker;
using App.Core.Interface;
using App.Core.Models;

namespace DecoratorTest
{
    [TestClass]
    public class Decorator
    {
        [TestMethod]
        public void TestDecodator()
        {
            Restaurant restaurant = new Restaurant("Cili", true);
            IWorker worker = new SimpleWorker("Aurimas", restaurant);
            Bartender bartender = new Bartender(worker);

            Assert.AreEqual(0, bartender.Sell(0));
            Assert.AreEqual(10, bartender.Sell(10));

            bartender.closeRestaurant();
            Assert.IsFalse(restaurant.Working);
        }
    }
}
