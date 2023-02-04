namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{

            Dictionary<string, double> productos = new Dictionary<string, double>();

            productos.Add("M101", 56.32);
            productos.Add("M234", 23.88);
            productos.Add("C654", 974.56);
            productos.Add("M104", 43.28);
            productos.Add("C345", 785.12);
            productos.Add("D567", 432.56);
            productos.Add("M103", 874.54);
            productos.Add("D903", 23.18);
            productos.Add("C732", 43.12);
            productos.Add("M056", 21.42);

            // Se crea el bridge

            //Pirmera implementacion
            // CAbstraction bridge = new CAbstraction(new CImplementacion(), productos);

            //segunda implementacion 
            //CAbstraction bridge = new CAbstraction(new CImplementacion2(), productos);


            //segunda implementacion 
            //CAbstraction bridge = new CAbstraction(new CImplementacion2(), productos);

            //tercera implementacion 
            //CAbstraction bridge = new CAbstraction(new CImplementacion3(), productos);

            // otra manera de implementas, en donde ahora se ecnuentra 3 podra colocar 1, 2 o 3 dependiendo de la implementacion que desee realizar
           
            CAbstraction bridge = new CAbstraction(3, productos);
           
            bridge.MostrarTotales();
            bridge.Listar();



      
    }
}

