// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerFunctionAwsServiceRequestConfigurationFactory(Action<Humidifier.MediaTailor.FunctionTypes.AwsServiceRequestConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.FunctionTypes.AwsServiceRequestConfiguration>
{

    protected override Humidifier.MediaTailor.FunctionTypes.AwsServiceRequestConfiguration Create()
    {
        var awsServiceRequestConfigurationResult = CreateAwsServiceRequestConfiguration();
        factoryAction?.Invoke(awsServiceRequestConfigurationResult);

        return awsServiceRequestConfigurationResult;
    }

    private Humidifier.MediaTailor.FunctionTypes.AwsServiceRequestConfiguration CreateAwsServiceRequestConfiguration()
    {
        var awsServiceRequestConfigurationResult = new Humidifier.MediaTailor.FunctionTypes.AwsServiceRequestConfiguration();

        return awsServiceRequestConfigurationResult;
    }

} // End Of Class

public static class InnerFunctionAwsServiceRequestConfigurationFactoryExtensions
{
}
