using Common;
using Lesson10.Entities;

namespace Lesson10.Actions;

public class Create(ApplicationContext db) : ISelectable
{
    public string Name { get; } = "Create";

    public void Select()
    {
        CreateAndAddEquipment();

        Console.WriteLine("Changes have been saved");
        TuiSelector.WaitForInput();
    }

    private void CreateAndAddEquipment()
    {
        var equipment = CreateEquipment();

        db.Equipments.Add(equipment);

        db.SaveChanges();
    }

    private Equipment CreateEquipment()
    {
        InputUtils.ReadNonEmptyLine(out var name, "Enter equipment name: ");

        return new Equipment { Name = name };
    }
}