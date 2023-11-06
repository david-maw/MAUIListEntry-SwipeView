namespace MAUIListEntry;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        for (int i = 0; i < 200; i++)
        {
            Items.Add("Item " + i);
        }
	}
    public List<String> Items { get; private set; } = new List<String>();
 }

