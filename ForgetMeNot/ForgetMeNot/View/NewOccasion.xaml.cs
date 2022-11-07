namespace ForgetMeNot.View;

public partial class NewOccasion : ContentPage
{
    private NewOccasionViewModel viewModel;
    public NewOccasion(NewOccasionViewModel viewModel)
    {
        this.viewModel = viewModel;
        BindingContext = viewModel;
        InitializeComponent();
    }
}