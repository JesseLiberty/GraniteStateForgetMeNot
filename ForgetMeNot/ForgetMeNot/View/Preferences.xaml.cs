using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using ForgetMeNot.Services;

namespace ForgetMeNot.View;

public partial class Preferences
{
    private PreferencesViewModel vm;
    public Preferences(PreferencesViewModel vm)
    {

        this.vm = vm;
        BindingContext = vm;
        InitializeComponent();
    }

    public void SavePreferences(object sender, EventArgs e)
    {
        ShowToast();
    }

    private async Task ShowToast()
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        var message = "Your preferences were saved";
        ToastDuration duration = ToastDuration.Short;
        var fontSize = 14;
        var toast = Toast.Make(message, duration, fontSize);
        await toast.Show(cancellationTokenSource.Token);

    }
}