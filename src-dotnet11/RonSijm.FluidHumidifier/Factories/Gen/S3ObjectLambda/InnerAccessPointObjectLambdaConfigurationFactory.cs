// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3ObjectLambda;

public class InnerAccessPointObjectLambdaConfigurationFactory(Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration>
{

    protected override Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration Create()
    {
        var objectLambdaConfigurationResult = CreateObjectLambdaConfiguration();
        factoryAction?.Invoke(objectLambdaConfigurationResult);

        return objectLambdaConfigurationResult;
    }

    private Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration CreateObjectLambdaConfiguration()
    {
        var objectLambdaConfigurationResult = new Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration();

        return objectLambdaConfigurationResult;
    }

} // End Of Class

public static class InnerAccessPointObjectLambdaConfigurationFactoryExtensions
{
}
