using System;
using System.Collections.Generic;
using System.Linq;

public class Albergo
{
    private List<Camera> camere;
    private bool aperto;
    private CameraCreator cameraCreator = new CameraCreator();

    public Albergo(int numCamereNormali, int numCamereSuperior, int numCamereSuite)
    {
        this.camere = new List<Camera>();

        for (int i = 0; i < numCamereNormali; i++)
        {
            this.camere.Add(cameraCreator.FactoryMethod(TipoCamera.Normale));
        }
        for (int i = 0; i < numCamereSuperior; i++)
        {
            this.camere.Add(cameraCreator.FactoryMethod(TipoCamera.Superior));
        }
        for (int i = 0; i < numCamereSuite; i++)
        {
            this.camere.Add(cameraCreator.FactoryMethod(TipoCamera.Suite));
        }

        this.aperto = true;
    }

    public bool IsAperto()
    {
        return this.aperto;
    }

    public void ChiudiAlbergo()
    {
        Console.WriteLine("L'albergo chiude.");
        this.aperto = false;
    }

    public bool Pieno()
    {
        bool pieno = true;
        foreach (Camera camera in this.camere)
        {
            if (!camera.IsOccupata())
                pieno = false;
        }
        return pieno;
    }

    public Camera[] GetCamereNormali()
    {
        return this.camere.Select(c => c).Where(c => c.GetTipo() == TipoCamera.Normale).ToArray();
    }
    public Camera[] GetCamereSuperior()
    {
        return this.camere.Select(c => c).Where(c => c.GetTipo() == TipoCamera.Superior).ToArray();
    }
    public Camera[] GetSuite()
    {
        return this.camere.Select(c => c).Where(c => c.GetTipo() == TipoCamera.Suite).ToArray();
    }

}