using Common;

namespace Lesson10.Actions;

public class Search(ApplicationContext db) : ISelectable
{
    public string Name { get; } = "Search";

    public void Select()
    {
        SearchForEquipment();

        TuiSelector.WaitForInput();
    }

    private void SearchForEquipment()
    {
        InputUtils.ReadNumber(out int id, "Enter id to search: ");

        var equipment = db.Equipments.Find(id);

        if (equipment != null)
        {
            Console.WriteLine(equipment);
        }
        else
        {
            Console.WriteLine("Equipment for given id not found");
        }
    }
}