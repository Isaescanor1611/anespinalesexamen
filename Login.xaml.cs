namespace anespinalesexamen;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = "estudiante2024";
        string contrasena = "uisrael2024";
        if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
        {
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            DisplayAlert("Error", "Usuario/Contraseña incorrectos", "Cerrar");
        }
    }
}