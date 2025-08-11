using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace AplicatieMedicala.Blazor.Menus
{
    public class AplicatieMedicalaMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                context.Menu.AddItem(new ApplicationMenuItem("Acasa", "Acasă", "/"));
                context.Menu.AddItem(new ApplicationMenuItem("Pacienti", "Pacienți", "/pacienti"));
                context.Menu.AddItem(new ApplicationMenuItem("Medici", "Medici", "/medici"));
                context.Menu.AddItem(new ApplicationMenuItem("Specializari", "Specializări", "/specializari"));
                context.Menu.AddItem(new ApplicationMenuItem("Programari", "Programări", "/programari"));
            }

            return Task.CompletedTask;
        }
    }
}
