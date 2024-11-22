using Common;

namespace Lesson3.Exercise2;

internal class FindProduct(Dictionary<string, Product> products) : SingleProductHandler, ISelectable
{
    public string Name => "Find Product";

    public void Select()
    {
        Find();

        TuiSelector.WaitForInput();
    }

    private void Find()
    {
        string name = ReadName();

        if (products.ContainsKey(name))
        {
            Product product = products[name];

            Console.WriteLine(product);
        }
        else
        {
            Console.WriteLine("No such product");
        }
    }
}