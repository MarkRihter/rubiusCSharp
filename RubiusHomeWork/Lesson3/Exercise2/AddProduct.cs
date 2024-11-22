using Common;

namespace Lesson3.Exercise2;

internal class AddProduct(Dictionary<string, Product> products) : SingleProductHandler,  ISelectable
{
    public string Name => "Add product";

    public void Select()
    {
        AddOrUpdate();

        TuiSelector.WaitForInput();
    }

    private void AddOrUpdate()
    {
        string name = ReadName();

        if (products.ContainsKey(name))
        {
            Update(name);
        }
        else
        {
            Add(name);
        }
    }

    private void Update(string name)
    {
        Product product = products[name];


        int amount = ReadAmount();

        product.Amount += amount;

        Console.WriteLine("\nProduct updated");
        Console.WriteLine(product);
    }

    private void Add(string name)
    {
        decimal price = ReadPrice();

        int amount = ReadAmount();

        Product product = new Product() { Name = name, Price = price, Amount = amount };

        products.Add(name, product);

        Console.WriteLine("\nProduct added");
        Console.WriteLine(product);
    }

    private decimal ReadPrice()
    {
        InputUtils.ReadNumber(out decimal price, "Enter product price: ");

        return price;
    }

    private int ReadAmount()
    {
        InputUtils.ReadNumber(out int amount, "Enter product amount: ");

        return amount;
    }
}