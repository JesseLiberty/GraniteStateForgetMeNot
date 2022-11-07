using Preferences = ForgetMeNot.View.Preferences;

namespace ForgetMeNot;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("buddydetail", typeof(BuddyDetail));
        Routing.RegisterRoute("buddylist", typeof(BuddyList));
        Routing.RegisterRoute("buddypreferences",typeof(BuddyPreferences));
        Routing.RegisterRoute("buddyoccasions", typeof(BuddyOccasions));
        Routing.RegisterRoute("about", typeof(About));
        Routing.RegisterRoute("preferences", typeof(Preferences));
        Routing.RegisterRoute("newoccasion", typeof(NewOccasion));
        Routing.RegisterRoute("login", typeof(Login));
        Routing.RegisterRoute("createaccount", typeof(CreateAccount));
        Routing.RegisterRoute("mainpage", typeof(MainPage));

    }


}
