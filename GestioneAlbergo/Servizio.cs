public class Servizio
{

    private string nome;
    private int prezzo;

    public Servizio(string nome, int prezzo)
    {
        this.nome = nome;
        this.prezzo = prezzo;
    }

    public string GetNome()
    {
        return this.nome;
    }
    public int GetPrezzo()
    {
        return this.prezzo;
    }
}