using Common;

namespace Lesson10.Actions;

public class Read(ApplicationContext db) : ISelectable
{
    public string Name { get; } = "Read";

    public void Select()
    {
        ReadAllEquipment();

        TuiSelector.WaitForInput();
    }

    private void ReadAllEquipment()
    {
        var equipmentList = db.Equipments.ToList();

        foreach (var equipment in equipmentList)
        {
            Console.WriteLine(equipment);
        }
    }
}