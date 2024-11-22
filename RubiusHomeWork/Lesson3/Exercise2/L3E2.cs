using Common;

namespace Lesson3.Exercise2;

internal class L3E2 : ISelectable
{
    public string Name => "Exercise 2";

    private Dictionary<string, Product> _products = new();

    public void Select()
    {
        var tuiSelector = new TuiSelector(selectables:
        [
            new AddProduct(_products),
            new ListProducts(_products),
            new DeleteProduct(_products),
            new FindProduct(_products)
        ], footer: RenderTotalPrice);

        tuiSelector.Run();
    }

    private string RenderTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.Value.Price * product.Value.Amount;
        }

        return $"\nTotal price: {totalPrice}";
    }
}