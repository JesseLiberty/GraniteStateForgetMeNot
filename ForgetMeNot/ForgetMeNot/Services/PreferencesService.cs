using ForgetMeNot.Api.Domain;
using ForgetMeNot.Api.Dto;
using ForgetMeNot.ApiClient;
using ForgetMeNot.Model;

namespace ForgetMeNot.Services;

public partial class PreferencesService
{
    readonly Client apiClient;

    public PreferencesService(Client apiClient)
    {
        this.apiClient = apiClient;
    }

    public List<Preference> GetPreferences()
    {
        try
        {
            var response = apiClient.GetProfile();
            var responsePreferences = response?.Result?.Preferences;
            var preferences = new List<Preference>();
            if (responsePreferences != null)
            {
                foreach (var responsePreference in responsePreferences)
                {
                    var preference = new Preference();
                    preference.PreferenceValue = responsePreference.PreferenceValue;
                    preference.PreferencePrompt = responsePreference.PreferencePrompt;
                    preferences.Add(preference);

                }
            }

            return preferences;

            //return GetPreferencesMock();

        }
        catch (Exception e)
        {
            Application.Current.MainPage.DisplayAlert("Preferences error",
                "We were unable to get your preferences", "Ok");

            Console.WriteLine(e);
        }

        return null;

    }

    public void Save(List<Preference> preferences)
    {
        var userPreferences = new List<UserPreference>();
        foreach (var preference in preferences)
        {
            var userPreference = new UserPreference()
            {
                PreferencePrompt = preference.PreferencePrompt,
                PreferenceValue = preference.PreferenceValue
            };
            userPreferences.Add(userPreference);
        }

        var profileUpdateRequest = new ProfileUpdateRequest()
        {
            FullName = "Jesse",
            Preferences = userPreferences
        };

        apiClient.UpdateProfile(profileUpdateRequest);
    }

}

