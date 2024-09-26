// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolClientAnalyticsConfigurationFactory(Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration>
{

    protected override Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration Create()
    {
        var analyticsConfigurationResult = CreateAnalyticsConfiguration();
        factoryAction?.Invoke(analyticsConfigurationResult);

        return analyticsConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration CreateAnalyticsConfiguration()
    {
        var analyticsConfigurationResult = new Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration();

        return analyticsConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolClientAnalyticsConfigurationFactoryExtensions
{
}
