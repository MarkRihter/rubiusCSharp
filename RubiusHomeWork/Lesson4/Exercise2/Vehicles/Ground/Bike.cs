using Lesson4.Exercise2.Ground;

namespace Lesson4.Exercise2.Vehicles.Ground;

public class Bike : GroundVehicle
{
    public override string ToString()
    {
        return $"Bike; type: {Type}";
    }
}