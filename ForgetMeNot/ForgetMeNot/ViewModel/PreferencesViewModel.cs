using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ForgetMeNot.Model;
using ForgetMeNot.Services;

namespace ForgetMeNot.ViewModel;

[ObservableObject]
public partial class PreferencesViewModel
{
    [ObservableProperty] private List<Preference> preferences;

    private readonly PreferencesService preferencesService;

    public PreferencesViewModel(PreferencesService preferencesService)
    {
        this.preferencesService = preferencesService;
        Preferences = preferencesService.GetPreferences();
    }

    [RelayCommand]
    private async Task SavePreferencesAsync()
    {
        preferencesService.Save(preferences);
    }
    
}

