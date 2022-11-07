using System.Diagnostics;
using ForgetMeNot.ApiClient;
using ForgetMeNot.Model;

namespace ForgetMeNot.Services;

public class BuddyService 
{


    public BuddyService() 
    {
    }

    public List<Buddy> GetBuddies()
    {
        return GetBuddiesMock();
    }

    public List<Preference> GetBuddyPreferences(int buddyId)
    {
        return GetBuddyPreferencesMock(buddyId);
    }

    public List<Occasion> GetBuddyOccasions(int buddyId)
    {
        return GetBuddyOccasionsMock(buddyId);
    }

    public void SaveOccasion(int buddyId, Occasion occasion)
    {
        Debug.WriteLine("buddyId = " + buddyId);
        Debug.WriteLine("occasion name = " + occasion.Name);
        Debug.WriteLine("occasion date = " + occasion.Date);
        Debug.WriteLine("occasion notification days = " + occasion.NumDaysToNotify);


    }


    public  List<Occasion> GetBuddyOccasionsMock(int buddyId)
{
    if (buddyId == 1)
    {
        List<Occasion> occasions = new()
            {
                new Occasion
                {
                    Name = "Anniversary", Date = new DateTime(2023, 5, 29),
                    NumDaysToNotify = 14
                },
                new Occasion
                {
                    Name = "Birthday", Date = new DateTime(2023, 7, 10), 
                    NumDaysToNotify = 14
                },
            };
        return occasions;
    }

    if (buddyId == 2)
    {
        List<Occasion> occasions = new()
            {
                new Occasion
                {
                    Name = "Anniversary", Date = new DateTime(2022, 12, 15), 
                    NumDaysToNotify = 14
                },
                new Occasion
                {
                    Name = "Birthday", Date = new DateTime(2023, 7, 4), 
                    NumDaysToNotify = 14
                },
            };
        return occasions;
    }

    return null;
}
private  List<Buddy> GetBuddiesMock()
{
    List<Buddy> buddies = new()
        {
            new Buddy
            {
                Name = "Joe",
                Id = 1,
                EmailAddress = "joeshmo67@gmail.com",
                Status = InvitationStatus.Accepted,
                BuddySince = new DateTime(2019,1,10),
                MailingAddressLine1="1461 Shore Parkway",
                MailingAddressLine2=" Brooklyn, NY 11214"
            },
            new Buddy()
            {
                Name = "Rodrigo",
                EmailAddress = "rodrigomjuarez@gmail.com",
                Id = 2,
                Status = InvitationStatus.Accepted,
                BuddySince = new DateTime(2017, 7, 10),
                MailingAddressLine1 = "101 SanFrancisco",
                MailingAddressLine2 = "Mendoza, Argentina"

            },
            new Buddy()
            {
                Name = "Stacey Liberty",
                Id = 3,
                EmailAddress = "stacey@gmail.com",
                Status = InvitationStatus.Sent,
                BuddySince = new DateTime(2022, 8, 10),
                MailingAddressLine1 = "2 Patriot Way, Acton, MA 01720"

            }

        };
    return buddies;
}

private  List<Preference> GetBuddyPreferencesMock(int buddyId)
{

    List<Preference> preferences = new();
    Preference preference = new Preference
    {
        PreferencePrompt = "Shirt size",
        PreferenceValue = "xxl"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Pants size",
        PreferenceValue = "40"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Shoe size",
        PreferenceValue = "12"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Favorite books",
        PreferenceValue = "Ulysses, Hamnet, Let's pretend this never happened, The Road, Zen and the art, Snow Crash"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Book genres",
        PreferenceValue = "Literary fiction, history, politics, philosophy"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "TV Shows",
        PreferenceValue = "Sense8, West Wing, Left Behind"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Music Genres",
        PreferenceValue = "Eclectic but especially Hard Bop, Jazz in general, Classic rock, all sorts of 'classical'"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Hobbies",
        PreferenceValue = "Writing, Photography"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Interests",
        PreferenceValue = ""
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Pets",
        PreferenceValue = "Dog"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Political interests",
        PreferenceValue = ""
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Favorite Magazines",
        PreferenceValue = "The Atlantic"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Favorite Newspapers",
        PreferenceValue = "NYTimes, Washington Post"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Favorite Podcasts",
        PreferenceValue = "Political Gabfest, Hacks On Tap, Pod Save America"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Social Media",
        PreferenceValue = "Facebook, but only friends"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Programming Language",
        PreferenceValue = "C#"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Programming Framework",
        PreferenceValue = ".NeT MAUI"
    };
    CheckPreference(preference, preferences);

    preference = new()
    {
        PreferencePrompt = "Other languages",
        PreferenceValue = "Assembly, ASP.NeT Core, Spanish"
    };
    CheckPreference(preference, preferences);


        return preferences;
}

private  void CheckPreference(Preference preference, List<Preference> preferences)
{
    try
    {
        if (!string.IsNullOrEmpty(preference.PreferenceValue))
            preferences.Add(preference);

    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}
}

