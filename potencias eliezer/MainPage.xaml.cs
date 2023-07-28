namespace potencias_eliezer;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void BtnCalcularSquare_Clicked(object sender, EventArgs e)
    {
        double Cuadrado, Result1;

        Cuadrado = Convert.ToDouble(Entry1.Text);
        Result1 = Math.Pow(Cuadrado, 2);
        ResultadoCuadrado.Text = Result1.ToString();
    }

    private void BtnCalcularCube_Clicked(object sender, EventArgs e)
    {
        double Cubo, Result2;

        Cubo = Convert.ToDouble(Entry2.Text);
        Result2 = Math.Pow(Cubo, 3);
        ResultadoCubo.Text = Result2.ToString();
    }

    private void Close_Clicked(object sender, EventArgs e)
    {
    }

}

