using AlexStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlexStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "Alexandro", 
                "Paixao Marques", 
                "123456",
                "email@email.com", 
                "123456",
                "123 rue example");
            var order = new Order(c);
            //order.AddItem();
        }
    }
}
