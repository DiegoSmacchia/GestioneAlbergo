using System.Collections.Generic;
public interface ICamera
{
    public void Occupa();
    public void Libera();
    public bool IsOccupata();
    public List<Servizio> GetServizi();
    public int GetPrezzo();
    public TipoCamera GetTipo();
}