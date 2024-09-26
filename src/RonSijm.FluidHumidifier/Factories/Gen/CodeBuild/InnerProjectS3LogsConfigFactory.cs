// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectS3LogsConfigFactory(Action<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig>
{

    protected override Humidifier.CodeBuild.ProjectTypes.S3LogsConfig Create()
    {
        var s3LogsConfigResult = CreateS3LogsConfig();
        factoryAction?.Invoke(s3LogsConfigResult);

        return s3LogsConfigResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.S3LogsConfig CreateS3LogsConfig()
    {
        var s3LogsConfigResult = new Humidifier.CodeBuild.ProjectTypes.S3LogsConfig();

        return s3LogsConfigResult;
    }

} // End Of Class

public static class InnerProjectS3LogsConfigFactoryExtensions
{
}
