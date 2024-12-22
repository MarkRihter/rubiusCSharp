using Common;
using Lesson4.Exercise2.Ground;

namespace Lesson4.Exercise2.Selectors.Ground;

public class GroundVehicleSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Ground";

    public void Select()
    {
        var tuiSelector = new TuiSelector((ISelectable[])[
            new BikeSelect(setVehicle),
            new CarSelect(setVehicle),
            new TruckSelect(setVehicle),
        ]);

        tuiSelector.Run();
    }
}