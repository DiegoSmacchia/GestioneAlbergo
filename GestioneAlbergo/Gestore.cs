using System;

public class Gestore : IGestore
{
    public void CheckIn(Cliente cliente, Albergo albergo)
    {
        Camera[] listaCamere;
        Camera[] listaSuperior;
        Camera[] listaSuite;

        if (!albergo.Pieno())
        {
            //provo ad assegnare una suite al cliente
            listaSuite = albergo.GetSuite();
            if (cliente.GetGiorni() * listaSuite[0].GetPrezzo() <= cliente.GetBudget())
            {
                for (int i = 0; i < listaSuite.Length && cliente.GetCamera() == null; i++)
                {
                    if (!listaSuite[i].IsOccupata())
                    {
                        AssegnaCamera(cliente, listaSuite[i]);
                        Console.WriteLine("Il cliente " + cliente.GetNome() + " ha effettuato il check-in.");
                        Console.WriteLine("Gli è stata assegnata una suite.");
                        cliente.Paga(cliente.GetGiorni() * listaSuite[0].GetPrezzo());
                    }
                }
            }
            //provo ad assegnare una camera superior al cliente
            listaSuperior = albergo.GetCamereSuperior();
            if (cliente.GetCamera() == null &&
                cliente.GetGiorni() * listaSuperior[0].GetPrezzo() <= cliente.GetBudget())
            {
                for (int i = 0; i < listaSuperior.Length && cliente.GetCamera() == null; i++)
                {
                    if (!listaSuperior[i].IsOccupata())
                    {
                        AssegnaCamera(cliente, listaSuperior[i]);
                        Console.WriteLine("Il cliente " + cliente.GetNome() + " ha effettuato il check-in.");
                        Console.WriteLine("Gli è stata assegnata una camera superior.");
                        cliente.Paga(cliente.GetGiorni() * listaSuperior[0].GetPrezzo());
                    }
                }
            }
            //provo ad assegnare una camera semplice al cliente
            listaCamere = albergo.GetCamereNormali();
            if (cliente.GetCamera() == null &&
                cliente.GetGiorni() * listaCamere[0].GetPrezzo() <= cliente.GetBudget())
            {
                for (int i = 0; i < listaCamere.Length && cliente.GetCamera() == null; i++)
                {
                    if (!listaCamere[i].IsOccupata())
                    {
                        AssegnaCamera(cliente, listaCamere[i]);
                        Console.WriteLine("Il cliente " + cliente.GetNome() + " ha effettuato il check-in.");
                        Console.WriteLine("Gli è stata assegnata una camera semplice.");
                        cliente.Paga(cliente.GetGiorni() * listaCamere[0].GetPrezzo());
                    }
                }
            }
        }
        //Stampo a video un eventuale esito negativo del check-in
        if (cliente.GetCamera() == null)
        {
            Console.WriteLine("Il cliente " + cliente.GetNome() + " non è riuscito ad effettuare il check-in.");
        }
    }

    public void CheckOut(Cliente cliente)
    {
        cliente.LiberaCamera();
        Console.WriteLine("Il cliente " + cliente.GetNome() + " ha effettuato il check-out.");
    }

    public void AssegnaCamera(Cliente cliente, Camera camera)
    {
        camera.Occupa();
        cliente.SetCamera(camera);
    }
}