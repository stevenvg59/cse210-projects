public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int CalculateTotalCost()
    {
        int totalPrice = 0;
        
        foreach(Product product in _products)
        {
            //Get the price of each product
            totalPrice += product.GetPrice();
        }

        //If the customer lives in USA..
        if (_customer.LiveInUsa())
        {
            //the shipping cost will be 5 dollars
            totalPrice += 5;
        } else {
            //if not, it will costs 35 dollars
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        int count = 1;
        foreach(Product product in _products)
        {
            //The packing label should list the name and product id of each product in the order
            label += "Product #" + count + ":\n" + " * Name: " + product.GetName() + "\n * Product ID: " + product.GetProductId() + "\n";
            count++;
        }
        return label;
    }

    public string GetShippingLabel()
    {
        //The shipping label should list the name and address of the customer
        string label = "- Customer: " + _customer.GetName() + "\n- Address: " + _customer.DisplayAddress();
        return label;
    }
}