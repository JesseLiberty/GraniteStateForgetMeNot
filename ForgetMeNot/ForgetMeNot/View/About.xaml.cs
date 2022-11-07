namespace ForgetMeNot;

public partial class About : ContentPage
{
    AboutViewModel viewModel => BindingContext as AboutViewModel;



    public About(AboutViewModel viewModel)
    {
        BindingContext = viewModel;
		InitializeComponent();
    }

	protected override async void OnAppearing()
	{
		base.OnAppearing();

	     await viewModel.Init();
	}
}