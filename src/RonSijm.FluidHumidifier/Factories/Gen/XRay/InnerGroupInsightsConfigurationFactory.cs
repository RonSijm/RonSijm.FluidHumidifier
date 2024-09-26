// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class InnerGroupInsightsConfigurationFactory(Action<Humidifier.XRay.GroupTypes.InsightsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.XRay.GroupTypes.InsightsConfiguration>
{

    protected override Humidifier.XRay.GroupTypes.InsightsConfiguration Create()
    {
        var insightsConfigurationResult = CreateInsightsConfiguration();
        factoryAction?.Invoke(insightsConfigurationResult);

        return insightsConfigurationResult;
    }

    private Humidifier.XRay.GroupTypes.InsightsConfiguration CreateInsightsConfiguration()
    {
        var insightsConfigurationResult = new Humidifier.XRay.GroupTypes.InsightsConfiguration();

        return insightsConfigurationResult;
    }

} // End Of Class

public static class InnerGroupInsightsConfigurationFactoryExtensions
{
}
