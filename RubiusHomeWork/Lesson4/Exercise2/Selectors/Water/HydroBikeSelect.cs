using Common;
using Lesson4.Exercise2.Vehicles.Water;

namespace Lesson4.Exercise2.Selectors.Water;

public class HydroBikeSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "HydroBike";

    public void Select()
    {
        setVehicle(new HydroBike());
    }
}