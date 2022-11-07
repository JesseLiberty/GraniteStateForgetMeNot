using ForgetMeNot.Services;

namespace ForgetMeNot.View;

public partial class BuddyList : ContentPage
{

    private BuddyListViewModel vm;
	public BuddyList(BuddyListViewModel vm)
    {
        this.vm = vm;
        BindingContext = vm;
		InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await vm.Init();
    }
}