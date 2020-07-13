public class CameraCreator : ICameraCreator
{

    public Camera FactoryMethod(TipoCamera tipoCamera)
    {
        return new Camera(tipoCamera);
    }

}