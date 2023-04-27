namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        var navPage = new NavigationPage(new MainPage())
        {
            BarBackgroundColor = Colors.Red,
            BarTextColor = Colors.Blue
        };
        //MainPage = navPage;
        //MainPage = new FlyoutPageDemo();
        //MainPage = new TabbedPageDemo();
        MainPage = new StackLayoutPageDemo();
    }
}
