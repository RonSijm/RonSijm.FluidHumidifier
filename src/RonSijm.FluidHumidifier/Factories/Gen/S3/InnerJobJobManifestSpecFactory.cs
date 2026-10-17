// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobJobManifestSpecFactory(Action<Humidifier.S3.JobTypes.JobManifestSpec> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.JobManifestSpec>
{

    protected override Humidifier.S3.JobTypes.JobManifestSpec Create()
    {
        var jobManifestSpecResult = CreateJobManifestSpec();
        factoryAction?.Invoke(jobManifestSpecResult);

        return jobManifestSpecResult;
    }

    private Humidifier.S3.JobTypes.JobManifestSpec CreateJobManifestSpec()
    {
        var jobManifestSpecResult = new Humidifier.S3.JobTypes.JobManifestSpec();

        return jobManifestSpecResult;
    }

} // End Of Class

public static class InnerJobJobManifestSpecFactoryExtensions
{
}
