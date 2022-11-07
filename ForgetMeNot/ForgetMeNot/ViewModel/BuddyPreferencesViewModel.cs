using ForgetMeNot.Model;
using ForgetMeNot.Services;

namespace ForgetMeNot.ViewModel;

[ObservableObject]
[QueryProperty(nameof(BuddyId), "id")]
[QueryProperty(nameof(BuddyName), "buddyname")]
public partial class BuddyPreferencesViewModel
{
    [ObservableProperty] private List<Preference> buddyPreferences;
    [ObservableProperty] private bool showActivityIndicator;
    [ObservableProperty] private string buddyName;

    private readonly BuddyService buddyService;

    public BuddyPreferencesViewModel(BuddyService buddyService)
    {
        ShowActivityIndicator = true;
        this.buddyService = buddyService;
    }

    private int buddyId;
    public int BuddyId
    {
        get => buddyId;
        set
        {
            SetProperty(ref buddyId, value);
            BuddyPreferences = buddyService.GetBuddyPreferences(buddyId);
            ShowActivityIndicator = false;

        }
    }
}

