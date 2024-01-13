namespace anespinalesexamen;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario, string nombre, string apellido, string edad, string pais, string ciudad, string montoinicial, string montomensual)
	{
        InitializeComponent();

        double montoMensual = double.Parse(montomensual);

        double rubrofinal =double.Parse(montoinicial);

        double pagofinal = ((montoMensual*4)+rubrofinal);

        txtPagoF.Text = pagofinal.ToString("F2");

        lblusuario.Text = "USUARIO CONECTADO: " + usuario;
        txtNombre.Text = nombre;
        txtApellido.Text = apellido;
        txtEdad.Text = edad;
        txtPais.Text = pais;
        txtCiudad.Text = ciudad;
        txtMontoI.Text = montoinicial;
        PagoMensualLabel.Text = montomensual;
        
    }

    private void btnSalir_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new Login());
    }
}