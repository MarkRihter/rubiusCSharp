using Common;
using Lesson4.Exercise2.Ground;
using Lesson4.Exercise2.Vehicles.Ground;

namespace Lesson4.Exercise2.Selectors.Ground;

public class CarSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Car";

    public void Select()
    {
        setVehicle(new Car());
    }
}