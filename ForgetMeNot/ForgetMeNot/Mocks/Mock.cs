using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeNot.Model;

namespace ForgetMeNot.Mocks
{
    public partial class Mock
    {
        private List<Preference> GetPreferencesMock()
        {
            List<Preference> preferences = new();
            Preference preference = new Preference
            {
                PreferencePrompt = "Shirt size",
                PreferenceValue = "XXL"
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Pants size",
                PreferenceValue = "40"
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Shoe size",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Favorite books",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Book genres",
                PreferenceValue = "Literary fiction, history, politics"
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "TV Shows",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Music Genres",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Songs",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Clothing",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Hobbies",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Interests",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Pets",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Sports (watch)",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Sports (play)",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Political interests",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Local/Town/City",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Farming",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Gardening",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Favorite Magazines",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Favorite Newspapers",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Favorite Podcasts",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Social Media",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            preference = new()
            {
                PreferencePrompt = "Web Sites",
                PreferenceValue = ""
            };
            preferences.Add(preference);

            return preferences;
        }

    }
}
