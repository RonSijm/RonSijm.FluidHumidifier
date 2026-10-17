// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobJobManifestLocationFactory(Action<Humidifier.S3.JobTypes.JobManifestLocation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.JobManifestLocation>
{

    protected override Humidifier.S3.JobTypes.JobManifestLocation Create()
    {
        var jobManifestLocationResult = CreateJobManifestLocation();
        factoryAction?.Invoke(jobManifestLocationResult);

        return jobManifestLocationResult;
    }

    private Humidifier.S3.JobTypes.JobManifestLocation CreateJobManifestLocation()
    {
        var jobManifestLocationResult = new Humidifier.S3.JobTypes.JobManifestLocation();

        return jobManifestLocationResult;
    }

} // End Of Class

public static class InnerJobJobManifestLocationFactoryExtensions
{
}
