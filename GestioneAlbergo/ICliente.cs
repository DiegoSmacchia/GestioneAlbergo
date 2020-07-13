public interface ICliente
{
    public string GetNome();
    public int GetBudget();
    public Camera GetCamera();
    public void SetCamera(Camera camera);
    public int GetGiorni();
    public TipoCliente GetTipo();
    public void LiberaCamera();
    public bool Paga(int costo);
    public void Relax();
}