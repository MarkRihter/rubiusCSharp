using Common;
using Lesson4.Exercise2.Ground;

namespace Lesson4.Exercise2.Selectors.Ground;

public class TruckSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Truck";

    public void Select()
    {
        setVehicle(new Truck());
    }
}