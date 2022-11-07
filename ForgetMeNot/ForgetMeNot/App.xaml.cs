using System.Runtime.CompilerServices;
using ForgetMeNot.Services;

namespace ForgetMeNot;

public partial class App : Application
{

    public App(LoginViewModel loginViewModel)
	{
		InitializeComponent();

        //MainPage = new AppShell();

        MainPage = new Login(loginViewModel);

    }
    



}

    