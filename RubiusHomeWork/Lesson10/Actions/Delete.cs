using Common;
using Lesson10.Entities;

namespace Lesson10.Actions;

public class Delete(ApplicationContext db) : ISelectable
{
    public string Name { get; } = "Delete";

    public void Select()
    {
        SearchAndDeleteEquipment();

        db.SaveChanges();
    }

    private void SearchAndDeleteEquipment()
    {
        InputUtils.ReadNumber(out int id, "Enter id to delete: ");

        var equipment = db.Equipments.Find(id);

        if (equipment != null)
        {
            DeleteEquipment(equipment);
        }
        else
        {
            Console.WriteLine("Equipment for given id not found");
        }
    }

    private void DeleteEquipment(Equipment equipment)
    {
        db.Equipments.Remove(equipment);
    }
}