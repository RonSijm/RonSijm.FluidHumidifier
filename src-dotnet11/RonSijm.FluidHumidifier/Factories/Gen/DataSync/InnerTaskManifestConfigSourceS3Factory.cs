// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskManifestConfigSourceS3Factory(Action<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3>
{

    protected override Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3 Create()
    {
        var manifestConfigSourceS3Result = CreateManifestConfigSourceS3();
        factoryAction?.Invoke(manifestConfigSourceS3Result);

        return manifestConfigSourceS3Result;
    }

    private Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3 CreateManifestConfigSourceS3()
    {
        var manifestConfigSourceS3Result = new Humidifier.DataSync.TaskTypes.ManifestConfigSourceS3();

        return manifestConfigSourceS3Result;
    }

} // End Of Class

public static class InnerTaskManifestConfigSourceS3FactoryExtensions
{
}
