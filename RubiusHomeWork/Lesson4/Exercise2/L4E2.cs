using Common;
using Lesson4.Exercise2.Ground;
using Lesson4.Exercise2.Selectors.Air;
using Lesson4.Exercise2.Selectors.Ground;
using Lesson4.Exercise2.Selectors.Water;

namespace Lesson4.Exercise2;

public class L4E2 : ISelectable
{
    public string Name { get; } = "Exercise 2";

    public void Select()
    {
        var tuiSelector =
            new TuiSelector([
                new AirVehicleSelect(SetVehicle),
                new GroundVehicleSelect(SetVehicle),
                new WaterVehicleSelect(SetVehicle)
            ]);

        tuiSelector.Run();
    }

    private void SetVehicle(Vehicle vehicle)
    {
        Console.WriteLine(vehicle);

        TuiSelector.WaitForInput();
    }
}