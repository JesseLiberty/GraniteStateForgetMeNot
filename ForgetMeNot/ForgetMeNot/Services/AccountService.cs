using ForgetMeNot.Api.Dto;
using ForgetMeNot.ApiClient;

namespace ForgetMeNot.Services
{
    public class AccountService
    {
        readonly Client apiClient;

        public AccountService(Client apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task CreateAccount(AccountCreateRequest accountCreateRequest)
        {
            await apiClient.CreateAccount(accountCreateRequest);
        }

        public async Task GetNewPassword()
        {

        }

        public async Task Login(LoginRequest request)
        {
            await apiClient.Login(request);
        }

        public bool IsLoggedIn()
        {
            return apiClient.IsAuthenticated;
        }

    }
}
