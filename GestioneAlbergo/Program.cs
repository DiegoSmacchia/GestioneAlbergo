using System;
using System.Collections.Generic;
using System.IO;

namespace Gestione_Albergo
{
    class Program
    {
        static void Main()
        {
            Albergo albergo = new Albergo(10, 5, 3);
            Gestore gestore = new Gestore();

            ClienteCreator cliCreator = new ClienteCreator();
            List<Cliente> clienti = new List<Cliente>();

            int count = 0;

            string nome;
            FileInfo file = new FileInfo("../../../nomi.txt");
            StreamReader sr = new StreamReader(file.FullName);

            //Creo la lista di clienti tramite il creatore e i nomi presi dal file di testo
            while ((nome = sr.ReadLine()) != null)
            {
                clienti.Add(cliCreator.FactoryMethod(count, nome));
                count++;
            }

            //fino a quando l'albergo è aperto i clienti provano il check-in o si rilassano
            //ed eventualmente effettuano il check-out
            while (albergo.IsAperto())
            {
                foreach (Cliente c in clienti)
                {
                    if (c.GetCamera() == null)
                    {
                        gestore.CheckIn(c, albergo);
                    }
                }
                for (int i = 0; i < clienti.Count; i++)
                {

                    if (clienti[i].GetCamera() != null)
                    {
                        clienti[i].Relax();
                    }

                    if (clienti[i].GetGiorni() == 0)
                    {
                        gestore.CheckOut(clienti[i]);
                        clienti.Remove(clienti[i]);
                    }
                }
                if (clienti.Count == 0)
                {
                    albergo.ChiudiAlbergo();
                }
            }

        }
    }
}
