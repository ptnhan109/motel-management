using Motel.App.Pages;

namespace Motel.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("/", typeof(Authenticate));
            Routing.RegisterRoute("/home", typeof(Home));
        }
    }
}