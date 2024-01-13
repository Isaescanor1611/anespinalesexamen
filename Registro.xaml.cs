namespace anespinalesexamen;

public partial class Registro : ContentPage
{
    string usuario;
	public Registro(string usuario)
	{
        InitializeComponent();
        lblusuario.Text = "USUARIO CONECTADO: " + usuario;
        this.usuario = usuario;
    }
    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        double MontoI = double.Parse(txtMontoI.Text);

        double pagoMensual  = (((1500 - MontoI) * 1.04) / 4);
        PagoMensualLabel.Text = (pagoMensual.ToString("F2"));

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        String nombre = (txtNombre.Text);
        String apellido = (txtApellido.Text);
        String edad = (txtEdad.Text);
        string pais = pkPais.Items[pkPais.SelectedIndex];
        string ciudad = pkCiudades.Items[pkCiudades.SelectedIndex];
        string montoinicial = (txtMontoI.Text);
        string montomensual = (PagoMensualLabel.Text);
       

        Navigation.PushAsync(new Resumen(usuario, nombre, apellido, edad, pais, ciudad, montoinicial, montomensual));
    }

   
}