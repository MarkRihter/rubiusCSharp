using Common;
using Lesson4.Exercise2.Vehicles.Water;

namespace Lesson4.Exercise2.Selectors.Water;

public class UBoatSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "UBoat";

    public void Select()
    {
        setVehicle(new UBoat());
    }
}