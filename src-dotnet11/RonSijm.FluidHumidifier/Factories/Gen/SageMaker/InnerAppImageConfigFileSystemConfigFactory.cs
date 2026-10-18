// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAppImageConfigFileSystemConfigFactory(Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig>
{

    protected override Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig Create()
    {
        var fileSystemConfigResult = CreateFileSystemConfig();
        factoryAction?.Invoke(fileSystemConfigResult);

        return fileSystemConfigResult;
    }

    private Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig CreateFileSystemConfig()
    {
        var fileSystemConfigResult = new Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig();

        return fileSystemConfigResult;
    }

} // End Of Class

public static class InnerAppImageConfigFileSystemConfigFactoryExtensions
{
}
