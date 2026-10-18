// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionS3FilesVolumeConfigurationFactory(Action<Humidifier.ECS.TaskDefinitionTypes.S3FilesVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.S3FilesVolumeConfiguration>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.S3FilesVolumeConfiguration Create()
    {
        var s3FilesVolumeConfigurationResult = CreateS3FilesVolumeConfiguration();
        factoryAction?.Invoke(s3FilesVolumeConfigurationResult);

        return s3FilesVolumeConfigurationResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.S3FilesVolumeConfiguration CreateS3FilesVolumeConfiguration()
    {
        var s3FilesVolumeConfigurationResult = new Humidifier.ECS.TaskDefinitionTypes.S3FilesVolumeConfiguration();

        return s3FilesVolumeConfigurationResult;
    }

} // End Of Class

public static class InnerTaskDefinitionS3FilesVolumeConfigurationFactoryExtensions
{
}
