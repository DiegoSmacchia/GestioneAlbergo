using System;
public class ClienteCreator : IClienteCreator
{

    public Cliente FactoryMethod(int count, string nome)
    {
        TipoCliente tipoCliente;
        Random rnd = new Random();
        if (count % 5 == 0)
        {
            tipoCliente = TipoCliente.Viziato;
        }
        else
        {
            tipoCliente = TipoCliente.Normale;
        }

        return new Cliente(tipoCliente, nome, rnd.Next(350, 1500), rnd.Next(1, 7));
    }
}