using Common;
using Lesson4.Exercise2.Vehicles.Air;

namespace Lesson4.Exercise2.Selectors.Air;

public class PlaneSelector(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Plane";

    public void Select()
    {
        setVehicle(new Plane());
    }
}