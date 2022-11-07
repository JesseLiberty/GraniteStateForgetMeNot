using ForgetMeNot.Model;
using ForgetMeNot.Services;

namespace ForgetMeNot.ViewModel;

[ObservableObject]
[QueryProperty(nameof(SelectedBuddy), "SelectedBuddy")]
public partial class BuddyDetailViewModel
{
    [ObservableProperty] private string name;
    [ObservableProperty] private string emailAddress;
    [ObservableProperty] private string code;
    [ObservableProperty] private string? phoneNumber;
    [ObservableProperty] private InvitationStatus status;
    [ObservableProperty] private DateTime buddySince;
    [ObservableProperty] private string buddySinceString;
    [ObservableProperty] private string mailingAddressLine1;
    [ObservableProperty] private string mailingAddressLine2;
    [ObservableProperty] private int id;


    private Buddy selectedBuddy;

    public Buddy SelectedBuddy
    {
        get => selectedBuddy;
        set
        {
            SetProperty(ref selectedBuddy, value);
            Name = value.Name;
            EmailAddress = value.EmailAddress;
            PhoneNumber = value.PhoneNumber;
            Status = value.Status;
            BuddySince = value.BuddySince;
            BuddySinceString = BuddySince.ToString("D");
            MailingAddressLine1 = value.MailingAddressLine1;
            MailingAddressLine2 = value.MailingAddressLine2;
            Id = value.Id;

        }

    }


   

    [RelayCommand]
    private async Task ShowBuddyPreferences()
    {
        await Shell.Current.GoToAsync($"buddypreferences?id={Id}&&buddyname={Name}");

    }

    [RelayCommand]
    private async Task ShowBuddyOccasions()
    {
        try
        {
            await Shell.Current.GoToAsync($"buddyoccasions?id={Id}");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }
}

