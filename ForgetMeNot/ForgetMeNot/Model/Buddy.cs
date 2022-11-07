﻿namespace ForgetMeNot.Model;


[ObservableObject]
public partial class Buddy 
{
    [ObservableProperty] private int id;
    [ObservableProperty] private string name;
    [ObservableProperty] private string emailAddress;
    [ObservableProperty] private string? phoneNumber;
    [ObservableProperty] private string? mailingAddressLine1;
    [ObservableProperty] private string? mailingAddressLine2;
    [ObservableProperty] private string? website;
    [ObservableProperty] private string? twitter;
    [ObservableProperty] private string? facebook;
    [ObservableProperty] private string? instagram;
    [ObservableProperty] private string? linkedIn;
    [ObservableProperty] private string? venmoName;

    [ObservableProperty] private InvitationStatus status;

    [ObservableProperty] private List<Occasion> occasions;

    [ObservableProperty] private DateTime buddySince;

}

