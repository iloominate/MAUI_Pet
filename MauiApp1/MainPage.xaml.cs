namespace MauiApp1;

public partial class MainPage : ContentPage
{
	string translatedNumber;
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnTranslate(object sender, EventArgs e)
	{
		string enteredNumber = PhoneNumberText.Text;
		translatedNumber = Core.PhoneTranslator.ToNumber(enteredNumber);

		if (!string.IsNullOrEmpty(translatedNumber))
		{
			CallButton.IsEnabled = true;
			CallButton.Text = "Call " + translatedNumber;
		} else
		{
			CallButton.IsEnabled=false;
			CallButton.Text = "Call";
		}

	
	}

    async void OnCall(object sender, EventArgs e)
    {
        if (await this.DisplayAlert(
            "Dial a Number",
            "Would you like to call " + translatedNumber + "?",
            "Yes",
            "No"))
        {
            //
        }
    }


}

