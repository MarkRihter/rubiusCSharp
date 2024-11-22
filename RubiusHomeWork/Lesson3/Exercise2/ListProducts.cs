using Common;

namespace Lesson3.Exercise2;

internal class ListProducts(Dictionary<string, Product> products) : ISelectable
{
    public string Name => "List products";

    public void Select()
    {
        List();

        TuiSelector.WaitForInput();
    }

    private void List()
    {
        foreach (var product in products)
        {
            Console.WriteLine(product.Value);
        }
    }
}