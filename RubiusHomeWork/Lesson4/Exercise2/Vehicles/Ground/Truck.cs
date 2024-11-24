using Lesson4.Exercise2.Vehicles.Ground;

namespace Lesson4.Exercise2.Ground;

public class Truck : GroundVehicle
{
    public override string ToString()
    {
        return $"Truck; type: {Type}";
    }
}