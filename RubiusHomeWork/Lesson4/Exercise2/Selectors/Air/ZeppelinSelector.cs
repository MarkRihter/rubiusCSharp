using Common;
using Lesson4.Exercise2.Vehicles.Air;

namespace Lesson4.Exercise2.Selectors.Air;

public class ZeppelinSelector(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Zeppelin";

    public void Select()
    {
        setVehicle(new Zeppelin());
    }
}