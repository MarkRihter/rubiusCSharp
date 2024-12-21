using Common;
using Lesson10.Entities;

namespace Lesson10.Actions;

public class Update(ApplicationContext db) : ISelectable
{
    public string Name { get; } = "Update";

    public void Select()
    {
        SearchAndUpdateEquipment();
    }

    private void SearchAndUpdateEquipment()
    {
        InputUtils.ReadNumber(out int id, "Enter id to update: ");

        var equipment = db.Equipments.Find(id);

        if (equipment != null)
        {
            UpdateEquipment(equipment);
        }
        else
        {
            Console.WriteLine("Equipment for given id not found");
        }
    }

    private void UpdateEquipment(Equipment equipment)
    {
        InputUtils.ReadNonEmptyLine(out var name, "Enter new equipment name:");

        equipment.Name = name;
    }
}