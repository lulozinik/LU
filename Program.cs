using System;

namespace Lagash
{
    class Program
    {
        static void Main()
        {
            ParkingLot test = new ParkingLot();
            test.IngresoDetectado();
            Console.Write("Cantidad de autos estacionados: {0}\n", test.CantidadEstacionados);
            Console.Write("Espacios disponibles: {0}", test.EspaciosDisponibles);
        }
    }
}
