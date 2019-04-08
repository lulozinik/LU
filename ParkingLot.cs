using System;

public class ParkingLot : IParkingLot
{
    private const int capacidad = 100;

    public int CantidadEstacionados
    {
        get
        {
            return value != 0 ? value : null;
        } 
    }

    public int EspaciosDisponibles
    {
        get
        {
            return this.CantidadEstacionados != null ? capacidad - this.CantidadEstacionados : capacidad;
        }
    }

    public int PrecioPorDia {get; set;}

    public void IngresoDetectado ()
    {
        if (this.CantidadEstacionados != capacidad)
            this.CantidadEstacionados += 1;
        else
            throw new Exception("Capacidad máxima alcanzada");
    }

    public void EgresoDetectado()
    {
        this.CantidadEstacionados -= 1;
    }

    public void FacturarEstadia (int precioPorDia)
    {
        int montoTotal = this.CantidadEstacionados != null ? this.CantidadEstacionados * precioPorDia : 0;

        string asunto = "Monto total de las estadías";
        string cuerpo = string.Format("El monto total a cobrar es: ${0}.", montoTotal);
        string destinatario = "encargado@mail.com";

        SerivicioExterno.EnviarMail(asunto, cuerpo, destinatario);
    }
}