using Lesson4.Exercise2.Ground;

namespace Lesson4.Exercise2.Vehicles.Ground;

public class Car : GroundVehicle
{
    public override string ToString()
    {
        return $"Car; type: {Type}";
    }
}