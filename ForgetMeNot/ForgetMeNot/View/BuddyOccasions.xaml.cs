using ForgetMeNot.Services;

namespace ForgetMeNot.View;

public partial class BuddyOccasions : ContentPage
{
    private BuddyOccasionsViewModel vm;

    public BuddyOccasions(BuddyOccasionsViewModel vm)
	{
        this.vm = vm;
        BindingContext = vm;
        InitializeComponent();
	}
}