using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace AplicatieMedicala.Blazor.Menus
{
    public class AplicatieMedicalaMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(
                        "Pacienti",
                        displayName: "Pacienți",
                        url: "/pacienti"
                    )
                );

                context.Menu.AddItem(
                    new ApplicationMenuItem(
                        "Medici",
                        displayName: "Medici",
                        url: "/medici"
                    )
                );

                context.Menu.AddItem(
                    new ApplicationMenuItem(
                        "Specializari",
                        displayName: "Specializări",
                        url: "/specializari"
                    )
                );

                context.Menu.AddItem(
                    new ApplicationMenuItem(
                        "Programari",
                        displayName: "Programări",
                        url: "/programari"
                    )
                );
            }
        }
    }
}
