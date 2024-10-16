// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerScheduledQuerySnsConfigurationFactory(Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration>
{

    protected override Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration Create()
    {
        var snsConfigurationResult = CreateSnsConfiguration();
        factoryAction?.Invoke(snsConfigurationResult);

        return snsConfigurationResult;
    }

    private Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration CreateSnsConfiguration()
    {
        var snsConfigurationResult = new Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration();

        return snsConfigurationResult;
    }

} // End Of Class

public static class InnerScheduledQuerySnsConfigurationFactoryExtensions
{
}
