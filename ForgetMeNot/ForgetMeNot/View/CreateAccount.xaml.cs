namespace ForgetMeNot.View;

public partial class CreateAccount : ContentPage
{
    private CreateAccountViewModel vm;
	public CreateAccount(CreateAccountViewModel vm)
    {
        this.vm = vm;
        BindingContext = vm;
		InitializeComponent();
	}
}