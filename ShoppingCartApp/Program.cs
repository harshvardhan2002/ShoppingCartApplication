using ShoppingCartApp.Model;

namespace ShoppingCartApp
{
    internal class Program
    {
        const int ORDER_NUMBER = 1;
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Harshvardhan");

            var order1 = new Order(1001, DateTime.Now);
            var order2 = new Order(1002, DateTime.Now);

            var product1 = new Product(101, "abc", 100.00, 10);
            var product2 = new Product(102, "xyz", 4000.0, 20);
            var product3 = new Product(103, "lmn", 2000.0, 15);

            var lineItem1 = new LineItem(1, 2, product1);
            var lineItem2 = new LineItem(2, 3, product2);
            order1.LineItems.Add(lineItem1);
            order1.LineItems.Add(lineItem2);

            var lineItem3=new LineItem(3, 4, product3);
            order2.LineItems.Add(lineItem3);
            var lineItem4= new LineItem(4, 3, product3);
            order2.LineItems.Add(lineItem4);

            customer.OrderList.Add(order1);
            customer.OrderList.Add(order2);

            Console.WriteLine("Customer Id: " + customer.CustomerId);
            Console.WriteLine("Customer Name: " + customer.CustomerName);
            Console.WriteLine("Order Count: " + customer.OrderList.Count);
            Console.WriteLine();

            int orderNumber = ORDER_NUMBER;
            foreach (var order in customer.OrderList)
            {
                Console.WriteLine("Order Number: " + orderNumber);
                Console.WriteLine("Order Id: " + order.OrderId);
                Console.WriteLine("Order Date: " + order.OrderDate);
                Console.WriteLine();
                PriceDisplay(order);
                orderNumber++;
            }


            static void PriceDisplay(Order order)
            {
                foreach (var lineItem in order.LineItems)
                {
                    var product = lineItem.Product;
                    double unitCostAfterDiscount = product.CalculateDiscountedPrice();
                    double totalLineItemCost = lineItem.CalculateLineItemCost();
                    double totalCost = order.CalculateOrderPrice();

                    Console.WriteLine($"LineItemId: {lineItem.LineItemId}, ProductId: {product.ProductId}, ProductName: {product.ProductName}, " +
                        $"Quantity {lineItem.QuantityItem}, UnitPrice {product.ProductPrice}, Discount {product.DiscountPercentage}, " +
                        $"UnitCostAfterDiscount {unitCostAfterDiscount}, TotalLineItemCost{totalLineItemCost}, Order Cost {totalCost}\n");
                    
                }
            }
        }
    }
}
