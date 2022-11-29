using Alternance.VueModeles;

namespace Alternance.Vues;

public partial class Tarification : ContentPage
{
	CalculVueModele vueModele;
	string nom;
	public Tarification()
	{
		InitializeComponent();
		BindingContext = vueModele = new CalculVueModele();
	}

	private void Tel_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		nom = "Telechargement";
		
		Eti.IsChecked = false;
		Pap.IsChecked = false;
		Cd.IsChecked = false;
	}

	private void Eti_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		nom = "Etiquette";
        Tel.IsChecked = false;
        Pap.IsChecked = false;
        Cd.IsChecked = false;
    }

	private void Pap_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		nom = "Papier";
        Eti.IsChecked = false;
        Tel.IsChecked = false;
        Cd.IsChecked = false;
    }

	private void Cd_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		nom = "CD-ROM";
        Eti.IsChecked = false;
        Pap.IsChecked = false;
        Tel.IsChecked = false;
    }

	private void Button_Clicked(object sender, EventArgs e)
	{
		Affichage.Text =""+ vueModele.getLePrix(int.Parse(nbAdresse.Text),nom);
	}
}