using System.Collections.Generic;

public class ClienteService
{
    private List<Cliente> clientes = new List<Cliente>();

    public void AgregarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public List<Cliente> ObtenerClientes()
    {
        return clientes;
    }
}
