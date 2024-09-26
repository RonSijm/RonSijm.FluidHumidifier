// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class SceneFactory(string resourceName = null, Action<Humidifier.IoTTwinMaker.Scene> factoryAction = null) : ResourceFactory<Humidifier.IoTTwinMaker.Scene>(resourceName)
{

    protected override Humidifier.IoTTwinMaker.Scene Create()
    {
        var sceneResult = CreateScene();
        factoryAction?.Invoke(sceneResult);

        return sceneResult;
    }

    private Humidifier.IoTTwinMaker.Scene CreateScene()
    {
        var sceneResult = new Humidifier.IoTTwinMaker.Scene
        {
            GivenName = InputResourceName,
        };

        return sceneResult;
    }

} // End Of Class

public static class SceneFactoryExtensions
{
}
