// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class ModelManifestFactory(string resourceName = null, Action<Humidifier.IoTFleetWise.ModelManifest> factoryAction = null) : ResourceFactory<Humidifier.IoTFleetWise.ModelManifest>(resourceName)
{

    protected override Humidifier.IoTFleetWise.ModelManifest Create()
    {
        var modelManifestResult = CreateModelManifest();
        factoryAction?.Invoke(modelManifestResult);

        return modelManifestResult;
    }

    private Humidifier.IoTFleetWise.ModelManifest CreateModelManifest()
    {
        var modelManifestResult = new Humidifier.IoTFleetWise.ModelManifest
        {
            GivenName = InputResourceName,
        };

        return modelManifestResult;
    }

} // End Of Class

public static class ModelManifestFactoryExtensions
{
}
