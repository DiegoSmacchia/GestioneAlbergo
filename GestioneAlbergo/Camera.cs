using System.Collections.Generic;
public class Camera : ICamera
{
    private int costoPerNotte;
    private List<Servizio> serviziDisponibili;
    private bool occupata;
    private TipoCamera tipo;

    public Camera(TipoCamera tipoCamera)
    {
        this.costoPerNotte = 50;
        this.serviziDisponibili = new List<Servizio>
        {
            new Servizio("bibita al frigo bar", 3),
            new Servizio("Noleggio biciclette", 15),
            new Servizio("Ristorante", 30)
        };

        this.tipo = tipoCamera;

        switch (tipoCamera)
        {
            case TipoCamera.Superior:
                this.costoPerNotte = 120;
                this.serviziDisponibili.Add(new Servizio("Servizio in camera", 45));
                break;

            case TipoCamera.Suite:
                this.costoPerNotte = 250;
                this.serviziDisponibili.Add(new Servizio("Servizio in camera", 45));
                this.serviziDisponibili.Add(new Servizio("SPA", 10));
                this.serviziDisponibili.Add(new Servizio("Accesso in piscina", 7));
                break;
        }

        this.occupata = false;
    }

    public void Occupa()
    {
        this.occupata = true;
    }
    public void Libera()
    {
        this.occupata = false;
    }
    public bool IsOccupata()
    {
        return this.occupata;
    }
    public List<Servizio> GetServizi()
    {
        return this.serviziDisponibili;
    }
    public int GetPrezzo()
    {
        return this.costoPerNotte;
    }

    public TipoCamera GetTipo()
    {
        return this.tipo;
    }

}