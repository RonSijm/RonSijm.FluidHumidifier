// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionFileSystemConfigFactory(Action<Humidifier.Lambda.FunctionTypes.FileSystemConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.FileSystemConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.FileSystemConfig Create()
    {
        var fileSystemConfigResult = CreateFileSystemConfig();
        factoryAction?.Invoke(fileSystemConfigResult);

        return fileSystemConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.FileSystemConfig CreateFileSystemConfig()
    {
        var fileSystemConfigResult = new Humidifier.Lambda.FunctionTypes.FileSystemConfig();

        return fileSystemConfigResult;
    }

} // End Of Class

public static class InnerFunctionFileSystemConfigFactoryExtensions
{
}
