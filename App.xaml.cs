namespace MAUIListEntry;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        // Set the App window to a sensible (phone like) size during initialization
        if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
        {
            window.Height = 1200;
            window.Width = 600;
        }

        return window;
    }
}
