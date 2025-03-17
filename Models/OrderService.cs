namespace OrderProcessingApp.Models
{
    public static class OrderService
    {
        public static Order CalculateOrder(decimal orderAmount, string customerType)
        {
            decimal discount = (orderAmount >= 100 && customerType == "Loyal") ? orderAmount * 0.10m : 0;
            decimal finalAmount = orderAmount - discount;

            return new Order
            {
                OrderAmount = orderAmount,
                CustomerType = customerType,
                Discount = discount,
                FinalAmount = finalAmount
            };
        }
    }
}