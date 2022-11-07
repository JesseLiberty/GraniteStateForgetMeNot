using ForgetMeNot.Model;
using ForgetMeNot.Services;
using System.Net.Mail;
using System.Xml.Linq;

namespace ForgetMeNot.ViewModel;

[ObservableObject]
[QueryProperty(nameof(BuddyId), "id")]
public partial class BuddyOccasionsViewModel
{
    [ObservableProperty] private List<Occasion> occasions;
    private readonly BuddyService buddyService;

    public BuddyOccasionsViewModel(BuddyService buddyService)
    {
        this.buddyService = buddyService;
    }


    private int buddyId;

    public int BuddyId
    {
        get => buddyId;
        set
        {
            SetProperty(ref buddyId, value);
            Occasions = buddyService.GetBuddyOccasions(buddyId);
        }
    }


     [RelayCommand]
    public async Task AddOccasion()
    {
        await Shell.Current.GoToAsync($"newoccasion?id={BuddyId}");

    }
}

