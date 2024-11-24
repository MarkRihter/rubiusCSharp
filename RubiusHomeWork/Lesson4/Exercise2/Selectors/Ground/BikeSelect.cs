using Common;
using Lesson4.Exercise2.Ground;
using Lesson4.Exercise2.Vehicles.Ground;

namespace Lesson4.Exercise2.Selectors.Ground;

public class BikeSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Bike";

    public void Select()
    {
        setVehicle(new Bike());
    }
}