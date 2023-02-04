using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    class CAbstraction
    {
        IBridge implementacion;
        Dictionary<string, double> productos;
        public CAbstraction(IBridge pImp, Dictionary<string, double> pProd)
        {
            implementacion = pImp;
            productos = pProd;
        }


        public CAbstraction(int pTipo, Dictionary<string, double> pProd)
        {
            if (pTipo == 1)
                implementacion = new CImplementacion();
            if (pTipo == 2)
                implementacion = new CImplementacion2();
            if (pTipo == 3)
                implementacion = new CImplementacion3();

            productos = pProd;
        }

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }
        public void Listar()
        {
            implementacion.ListarProductos(productos);
        }
    }
}
