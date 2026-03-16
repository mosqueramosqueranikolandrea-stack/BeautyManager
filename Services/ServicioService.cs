using System.Collections.Generic;

public class ServicioService
{
    private List<Servicio> servicios = new List<Servicio>();

    public void AgregarServicio(Servicio servicio)
    {
        servicios.Add(servicio);
    }

    public List<Servicio> ObtenerServicios()
    {
        return servicios;
    }
}
