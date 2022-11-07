using ForgetMeNot.Services;

namespace ForgetMeNot.View;

public partial class BuddyDetail : ContentPage
{
    private BuddyDetailViewModel vm;
	public BuddyDetail(BuddyDetailViewModel vm)
	{
		this.vm = vm;
		BindingContext = vm;
		InitializeComponent();
	}


}