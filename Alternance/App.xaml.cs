using Alternance.Vues;
namespace Alternance;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Tarification();
	}
}
