using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeNot.Api.Dto;
using ForgetMeNot.Services;

namespace ForgetMeNot.ViewModel
{
    [ObservableObject]
    public partial class LoginViewModel
    {
        private AccountService accountService;
        [ObservableProperty] private string loginName;
        [ObservableProperty] private string password;

        public LoginViewModel(AccountService accountService)
        {
            this.accountService = accountService;
        }


        [RelayCommand]
        public async Task DoLogin()
        {

            try
            {
                LoginRequest loginRequest = new LoginRequest
                {
                    Username = LoginName,
                    Password = Password
                };

                await accountService.Login(loginRequest);
                if (accountService.IsLoggedIn())
                {
                    Application.Current.MainPage = new AppShell();
                    await Shell.Current.GoToAsync("mainpage");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Login failure",
                        "Your username and password do not match our records", "Ok");
                }

            }
            catch (Exception exception)
            {
                await Application.Current.MainPage.DisplayAlert("Authorization failure",
                    "Your username and password do not match our records", "Ok");

                Console.WriteLine(exception);
            }


        }

        [RelayCommand]
        public async Task ForgotPassword()
        {

        }

        [RelayCommand]
        public async Task DoCreateAccount()
        {
            try
            {
                Application.Current.MainPage = new AppShell();

                await Shell.Current.GoToAsync($"createaccount");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
