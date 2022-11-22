using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTecnicas
{
    public class Hospital
    {
        public double valorFiscal { get; set; }
        public string areaTerreno { get; set; }
        public string direccionExacta { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }
        public int cantidadNiveles { get; set; }
        public string color { get; set; }
        public int cantidadConsultorios { get; set; }
        public string tiposdCirugia { get; set; }
        public string anoConstruccion { get; set; }
        public string imagen { get; set; }
        public Hospital() { }

        public Hospital(double valorFiscal, string areaTerreno, string direcExacta, string provincia, string canton, string distrito, int cantNiveles, string color, int cantConsultorios, string tiposdCirugia, string anoConstruccion, string imagen)
        {
            this.valorFiscal = valorFiscal;
            this.areaTerreno = areaTerreno;
            this.direccionExacta = direcExacta;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.cantidadNiveles = cantNiveles;
            this.color = color;
            this.cantidadConsultorios = cantConsultorios;
            this.tiposdCirugia = tiposdCirugia;
            this.anoConstruccion = anoConstruccion;
            this.imagen = imagen;
        }
    }
}
