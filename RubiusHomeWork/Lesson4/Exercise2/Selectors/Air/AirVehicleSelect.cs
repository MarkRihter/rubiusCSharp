using Common;

namespace Lesson4.Exercise2.Selectors.Air;

public class AirVehicleSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Air";

    public void Select()
    {
        var tuiSelector = new TuiSelector((ISelectable[])[
            new HeliSelect(setVehicle),
            new PlaneSelector(setVehicle),
            new ZeppelinSelector(setVehicle),
        ]);

        tuiSelector.Run();
    }
}