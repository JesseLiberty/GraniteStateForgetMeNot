using ForgetMeNot.Services;

namespace ForgetMeNot.View;

public partial class BuddyPreferences : ContentPage
{
    private BuddyPreferencesViewModel vm;
    public BuddyPreferences(BuddyPreferencesViewModel vm)
	{
        
        this.vm = vm;
        BindingContext = vm;
        InitializeComponent();
	}

}