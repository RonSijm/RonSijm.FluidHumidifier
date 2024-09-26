// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAlertLambdaConfigurationFactory(Action<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration>
{

    protected override Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration Create()
    {
        var lambdaConfigurationResult = CreateLambdaConfiguration();
        factoryAction?.Invoke(lambdaConfigurationResult);

        return lambdaConfigurationResult;
    }

    private Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration CreateLambdaConfiguration()
    {
        var lambdaConfigurationResult = new Humidifier.LookoutMetrics.AlertTypes.LambdaConfiguration();

        return lambdaConfigurationResult;
    }

} // End Of Class

public static class InnerAlertLambdaConfigurationFactoryExtensions
{
}
