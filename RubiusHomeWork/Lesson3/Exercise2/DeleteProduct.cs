using Common;

namespace Lesson3.Exercise2;

internal class DeleteProduct(Dictionary<string, Product> products) : NameReader, ISelectable
{
    public string Name => "Delete product";

    public void Select()
    {
        Delete();

        TuiSelector.WaitForInput();
    }

    private void Delete()
    {
        string name = ReadName();

        if (products.ContainsKey(name))
        {
            products.Remove(name);

            Console.WriteLine("Product deleted");
        }
        else
        {
            Console.WriteLine("No such product");
        }
    }
}