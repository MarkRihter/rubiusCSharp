using Common;
using Lesson4.Exercise2.Vehicles.Water;

namespace Lesson4.Exercise2.Selectors.Water;

public class BoatSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Boat";

    public void Select()
    {
        setVehicle(new Boat());
    }
}