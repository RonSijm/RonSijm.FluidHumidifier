// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAlertSNSConfigurationFactory(Action<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration>
{

    protected override Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration Create()
    {
        var sNSConfigurationResult = CreateSNSConfiguration();
        factoryAction?.Invoke(sNSConfigurationResult);

        return sNSConfigurationResult;
    }

    private Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration CreateSNSConfiguration()
    {
        var sNSConfigurationResult = new Humidifier.LookoutMetrics.AlertTypes.SNSConfiguration();

        return sNSConfigurationResult;
    }

} // End Of Class

public static class InnerAlertSNSConfigurationFactoryExtensions
{
}
