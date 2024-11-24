using Common;

namespace Lesson4.Exercise2.Selectors.Water;

public class WaterVehicleSelect(Action<Vehicle> setVehicle) : ISelectable
{
    public string Name { get; } = "Water";

    public void Select()
    {
        var tuiSelector = new TuiSelector([
            new BoatSelect(setVehicle),
            new HydroBikeSelect(setVehicle),
            new UBoatSelect(setVehicle),
        ]);

        tuiSelector.Run();
    }
}