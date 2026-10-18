// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowGoogleAnalyticsSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.GoogleAnalyticsSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.GoogleAnalyticsSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.GoogleAnalyticsSourceProperties Create()
    {
        var googleAnalyticsSourcePropertiesResult = CreateGoogleAnalyticsSourceProperties();
        factoryAction?.Invoke(googleAnalyticsSourcePropertiesResult);

        return googleAnalyticsSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.GoogleAnalyticsSourceProperties CreateGoogleAnalyticsSourceProperties()
    {
        var googleAnalyticsSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.GoogleAnalyticsSourceProperties();

        return googleAnalyticsSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowGoogleAnalyticsSourcePropertiesFactoryExtensions
{
}
