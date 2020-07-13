public interface IGestore
{
    public void CheckIn(Cliente cliente, Albergo albergo);
    public void CheckOut(Cliente cliente);
    public void AssegnaCamera(Cliente cliente1, Camera camera);
}
