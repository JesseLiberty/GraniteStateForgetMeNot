using ForgetMeNot.Services;

namespace ForgetMeNot.ViewModel
{
    [ObservableObject]
    public partial class AboutViewModel
    {
        private readonly UtilService utilService;

        [ObservableProperty] private string apiVersion;

        public AboutViewModel(UtilService utilService)
        {
            this.utilService = utilService;
        }

        public async Task Init()
        {
            try
            {
                ApiVersion = await utilService.ApiVersion();
            }
            catch (Exception)
            {
                // TODO: logging
                ApiVersion = "Not Available";
            }
        }
    }
}
