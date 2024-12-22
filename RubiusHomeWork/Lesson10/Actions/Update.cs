using Common;
using Lesson10.Entities;

namespace Lesson10.Actions;

public class Update(ApplicationContext db) : ISelectable
{
    public string Name { get; } = "Update";


    private TuiSelector TuiSelector { get; } = new(new List<ISelectable>(), () => "Select equipment to update");

    public void Select()
    {
        SelectAndUpdateEquipment();

        db.SaveChanges();
    }

    private void SelectAndUpdateEquipment()
    {
        TuiSelector.Clear();

        FillSelectorWithSelectables();

        TuiSelector.Run();
    }

    private void FillSelectorWithSelectables()
    {
        foreach (var equipment in db.Equipments.ToList())
        {
            var selectable = new SelectableEquipment(equipment, UpdateEquipment);

            TuiSelector.Add(selectable);
        }
    }

    private void UpdateEquipment(SelectableEquipment selectableEquipment)
    {
        InputUtils.ReadNonEmptyLine(out var name, "Enter new equipment name: ");

        selectableEquipment.Equipment.Name = name;

        Console.WriteLine("Equipment has been updated");

        TuiSelector.WaitForInput();
    }
}