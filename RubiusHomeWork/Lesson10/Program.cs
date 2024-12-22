using Common;
using Lesson10;
using Lesson10.Actions;

using (ApplicationContext db = new ApplicationContext())
{
    var tui = new TuiSelector((ISelectable[])[
        new Search(db),
        new Create(db),
        new Read(db),
        new Update(db),
        new Delete(db)
    ]);

    tui.Run();
}