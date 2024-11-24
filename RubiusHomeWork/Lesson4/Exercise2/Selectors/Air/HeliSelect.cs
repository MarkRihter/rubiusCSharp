using Common;
using Lesson4.Exercise2.Vehicles.Air;

namespace Lesson4.Exercise2.Selectors.Air;

public class HeliSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Heli";

    public void Select()
    {
        setVehicle(new Heli());
    }
}