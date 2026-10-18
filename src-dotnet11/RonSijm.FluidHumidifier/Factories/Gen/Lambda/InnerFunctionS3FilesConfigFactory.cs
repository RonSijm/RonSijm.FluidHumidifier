// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionS3FilesConfigFactory(Action<Humidifier.Lambda.FunctionTypes.S3FilesConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.S3FilesConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.S3FilesConfig Create()
    {
        var s3FilesConfigResult = CreateS3FilesConfig();
        factoryAction?.Invoke(s3FilesConfigResult);

        return s3FilesConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.S3FilesConfig CreateS3FilesConfig()
    {
        var s3FilesConfigResult = new Humidifier.Lambda.FunctionTypes.S3FilesConfig();

        return s3FilesConfigResult;
    }

} // End Of Class

public static class InnerFunctionS3FilesConfigFactoryExtensions
{
}
