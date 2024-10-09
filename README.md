# ShoppingCartApplication

A console-based C# application that is used as a shopping cart system where a customer can place multiple orders. Each order contains number of line items associated with products, and the application calculates the total order cost while keeping the product discounts within the calculations.

## Properties-

- Object-Oriented Design
    Relationships:
   - One-to-Many: A Customer can have multiple Orders.
   - One-to-Many: An Order can have multiple LineItems.
   - Many-to-One: Each LineItem is associated with a single Product.
   
- Encapsulation using certain Methods
   - Product: Includes a method to calculate the discounted price (CalculateDiscountedPrice()).
   - LineItem: Uses CalculateLineItemCost to calculate the total cost while taking the quantity and discounted price.
   - Order: Uses CalculateOrderPrice to sum up the costs of all line items within the order.

- Complete Methodology
   - Create a customer and initialize orders.
   - Add products and line items to the respective orders.
   - Calculate costs and display the information in a structured format.
  
![image](https://github.com/user-attachments/assets/77c96bd2-38f9-4a13-92d3-5fa61dad6562)

Feature-
1. Scalability:
   - The design is modular, allowing for easy extension, such as adding new products, orders, or calculation logic, without modifying existing classes.
