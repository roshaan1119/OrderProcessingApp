using OrderProcessingApp.Models;
using Xunit;

namespace OrderProcessingApp.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void LoyalCustomer_With_100PlusOrder_GetsDiscount()
        {
            var order = OrderService.CalculateOrder(100, "Loyal");
            Assert.Equal(10, order.Discount);
            Assert.Equal(90, order.FinalAmount);
        }

        [Fact]
        public void NewCustomer_NoDiscount()
        {
            var order = OrderService.CalculateOrder(100, "New");
            Assert.Equal(0, order.Discount);
            Assert.Equal(100, order.FinalAmount);
        }
    }
}