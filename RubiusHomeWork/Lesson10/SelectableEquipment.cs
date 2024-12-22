using Common;
using Lesson10.Entities;

namespace Lesson10;

public class SelectableEquipment(Equipment equipment, Action<SelectableEquipment> onSelect) : ISelectable
{
    public string Name => Equipment.ToString();

    public Equipment Equipment { get; } = equipment;

    public void Select()
    {
        onSelect(this);
    }
}