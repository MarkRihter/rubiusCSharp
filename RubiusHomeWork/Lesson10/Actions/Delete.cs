using Common;

namespace Lesson10.Actions;

public class Delete(ApplicationContext db) : ISelectable
{
    public string Name { get; } = "Delete";

    private TuiSelector TuiSelector { get; } = new(new List<ISelectable>(), () => "Select equipment to delete");

    public void Select()
    {
        SelectAndDeleteEquipment();

        db.SaveChanges();
    }

    private void SelectAndDeleteEquipment()
    {
        TuiSelector.Clear();

        FillSelectorWithSelectables();

        TuiSelector.Run();
    }

    private void FillSelectorWithSelectables()
    {
        foreach (var equipment in db.Equipments.ToList())
        {
            var selectable = new SelectableEquipment(equipment, DeleteEquipment);

            TuiSelector.Add(selectable);
        }
    }

    private void DeleteEquipment(SelectableEquipment selectableEquipment)
    {
        db.Equipments.Remove(selectableEquipment.Equipment);
        TuiSelector.Remove(selectableEquipment);

        Console.WriteLine(
            $"Equipment {selectableEquipment.Equipment.Name} has been deleted");

        TuiSelector.WaitForInput();
    }
}