using AppRpgEtec.ViewModels.Usuarios;

namespace AppRpgEtec.Views.Usuarios;

public partial class ImagemUsurioView : ContentPage
{

	 ImagemUsuarioViewModel viewModel; 

	public ImagemUsurioView()
	{
		InitializeComponent();

		viewModel = new ImagemUsuarioViewModel();
		Title = "Imagem do Usuario";
		BindingContext = viewModel;
	}
}