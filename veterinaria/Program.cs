/*
cree una aplicativo de veterinaria
clases con propiedades: 
    Mascota: nombre, edad, especie
    Servicio: descripcion, precio
    Boleta: codigo, mascota, servicio1, servicio2, total

Use arreglos estáticos de las clases
Debe tener un menu con estas opciones:
- crear, eliminar, listar Servicios
- crear, eliminar, listar Mascotas
- crear, listar Boletas

Para crear boletas debe seleccionar la Mascota y el Servicio de 
sus respectivos arreglos

Divida entre sus integrantes, el lider consolida y los integrantes uno hace lo de servicios y el otro el de mascotas
Debe tener una rama por integrante, el lider debe tener por lo menos 2 ramas: main y dev. debe trabajar y consolidar en dev
*/

namespace veterinaria {
    public class Program {
        public static Servicio[] listaSer = new Servicio[100];
        public static Mascota[] listaMas = new Mascota[100];
        public static Boleta[] listaBol = new Boleta[100];
        public static void Main(string[] args) {
            int opc=0;
            do {
                Console.WriteLine("... 4-Agrega Boleta ...");
                opc = Convert.ToInt32(Console.ReadLine());
                if (opc == 4) {
                    Console.WriteLine("Ingrese Codigo");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    int x;
                    for (x = 0; x< listaMas.Length; x++) {
                        Console.WriteLine($"{x+1} datos mascota");
                    }
                    Console.WriteLine("Elija nro mascota");
                    Mascota mas1 = listaMas[x - 1];
                    Servicio s1 = listaSer[x - 1]; //no asignar null sino un servicio de la lista como mascota
                    Servicio s2 = listaSer[x - 1]; //no asignar null sino un servicio de la lista como mascota
                    double total = s1.Precio + s2.Precio;
                    Boleta b = new Boleta();
                    b.Codigo = codigo;
                    b.Mascota1 = mas1;
                    b.Servicio1 = s1;
                    b.Servicio2 = s2;
                    b.Total = total;
                    listaBol[z+1] = b;
                }

            } while (opc != 9);
        }
    }
}


