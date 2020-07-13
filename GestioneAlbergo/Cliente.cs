using System;
using System.Collections.Generic;

public class Cliente : ICliente
{
    private string nome;
    private int budget;
    private int probServizio;
    private Camera miaCamera;
    private TipoCliente tipo;
    private int giorniVacanza;

    public Cliente(TipoCliente tipoCliente, string nome, int budget, int giorni)
    {
        this.nome = nome;
        this.budget = budget;
        this.giorniVacanza = giorni;
        this.miaCamera = null;
        this.tipo = tipoCliente;

        if (tipoCliente == TipoCliente.Viziato)
        {
            this.probServizio = 100;
        }
        else
        {
            this.probServizio = 40;
        }
    }

    public string GetNome()
    {
        return this.nome;
    }
    public int GetBudget()
    {
        return this.budget;
    }
    public Camera GetCamera()
    {
        return this.miaCamera;
    }

    public void SetCamera(Camera camera)
    {
        this.miaCamera = camera;
    }
    public int GetGiorni()
    {
        return this.giorniVacanza;
    }

    public TipoCliente GetTipo()
    {
        return this.tipo;
    }

    public void LiberaCamera()
    {
        this.miaCamera.Libera();
        this.miaCamera = null;
    }

    public bool Paga(int costo)
    {
        if (this.budget >= costo)
        {
            this.budget -= costo;
            return true;
        }
        return false;
    }

    public void Relax()
    {
        Random rnd = new Random();
        List<Servizio> servizi;
        Servizio servizioRichiesto;
        if (rnd.Next(100) <= this.probServizio)
        {
            //chiedo, se possibile, un servizio
            servizi = this.miaCamera.GetServizi();
            if (servizi.Count > 0)
            {
                //un cliente chiede un servizio, e se può pagarlo, ne usufruisce.
                servizioRichiesto = servizi[rnd.Next(servizi.Count)];
                if (!this.Paga(servizioRichiesto.GetPrezzo()))
                {
                    Console.WriteLine("Il cliente " + this.nome + " non ha potuto permettersi il servizio '" + servizioRichiesto.GetNome() + "'.");
                }
                else
                {
                    Console.WriteLine("Il cliente " + this.nome + " usufruisce del servizio '" + servizioRichiesto.GetNome() + "'.");
                }
            }
        }
        this.giorniVacanza--;
    }
}