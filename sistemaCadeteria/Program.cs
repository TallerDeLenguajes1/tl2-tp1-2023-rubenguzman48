internal class Program
{
    private static void main(string[] args)
    {
        
        //Interfaz
        string nombreCliente = "", direccionCliente = "", telCliente = "", datosReferenciaDireccionCliente = "";
        string obsPedido = "";
        string operacion = "";
        int nroPedido = 0;

        do
        {
            Console.WriteLine("----------------Sistema de Gestion de Pedidos de Andreani------------");
            Console.WriteLine("a- Hacer un pedido. \n");
            Console.WriteLine("b- Cambiar estado de pedido. \n");
            Console.WriteLine("c- Reasignar pedido a otro cadete. \n");
            Console.WriteLine("d- Salir.\n");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadLine();

            switch(opcion)
            {
                case a: 
                    int idCadete = 0;
                    string idCad = "";
                    nroPedido++;
                    Console.WriteLine("\n-------Datos del cliente-------\n");
                    Console.Write("Nombre: ");
                    nombreCliente = Console.ReadLine();
                    Console.Write("Direccion: ")
                    direccionCliente = Console.ReadLine();
                    Console.Write("Telefono: ");
                    telCliente = Console.ReadLine();
                    Console.Write("Datos de referencia de su direccion: ");
                    datosReferenciaDireccionCliente = Console.ReadLine();
                    Console.WriteLine($"\nN° pedido: {nroPedido}\n");
                    MostrarCantidadDePedidoDeCadetes(andreani);

                    do
                    {
                        Console.Write("Ingresar id del cadete a asignar: ");
                        idCad = Console.ReadLine();
                    }while(!int.TryParse(idCad, out idCadete) || (idCadete < 0 || idCadete > andreani.IdMaximo()));

                    if(andreani.DarAltaPedido(nroPedido, obsPedido, idCadete, nombreCliente, direccionCliente, telCliente, datosReferenciaDireccionCliente))
                    {
                        Console.WriteLine("\nEl pedido fue dado de alta exitosamente!\n");
                    }

                    break;
                case "b":
                    int nroPedidoACambiar;
                    string nro = "";

                    do
                    {
                        Console.Write("\n")
                    }    
            }


        }
    }
}