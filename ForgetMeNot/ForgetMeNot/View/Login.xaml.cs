using CommunityToolkit.Maui.Core.Views;

namespace ForgetMeNot.View;

public partial class Login : ContentPage
{
    private LoginViewModel viewModel;

    public Login(LoginViewModel viewModel)
    {
        this.viewModel = viewModel;
        BindingContext = viewModel;
        InitializeComponent();
    }



    

}