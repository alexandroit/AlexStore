using AlexStore.Domain.StoreContext.Entities;
using AlexStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlexStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("Alexandro", "Paixao Marques");
            var document = new Document(1234567890);
            var email = new Email("test@alexandroit.com");
            var c = new Customer(name, document, email, "+1 438 992 5049");
            var order = new Order(c);
            var laptop = new Product("Laptop 16GB", "16GB RAM", "image1.png", 1760.59M, 9);
            var chair = new Product("Chair", "Chair", "image2.png", 1760.59M, 9);
            var desk = new Product("Desk", "Desk", "image3.png", 1760.59M, 9);
            var printer = new Product("Printer", "Printer", "image4.png", 1760.59M, 9);
            /*order.AddItem(new OrderItem(laptop, 3));
            order.AddItem(new OrderItem(chair, 3));
            order.AddItem(new OrderItem(desk, 3));
            order.AddItem(new OrderItem(printer, 3));*/

            //send Ordem
            order.Place();
            var valid = order.Valid;
            //pay
            order.Pay();

            //shipp
            order.Ship();

            //cancel
            order.Cancel();
        }
    }
}
