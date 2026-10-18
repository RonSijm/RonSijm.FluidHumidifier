// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerLogAlarmWarmUpConfigurationFactory(Action<Humidifier.CloudWatch.LogAlarmTypes.WarmUpConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.LogAlarmTypes.WarmUpConfiguration>
{

    protected override Humidifier.CloudWatch.LogAlarmTypes.WarmUpConfiguration Create()
    {
        var warmUpConfigurationResult = CreateWarmUpConfiguration();
        factoryAction?.Invoke(warmUpConfigurationResult);

        return warmUpConfigurationResult;
    }

    private Humidifier.CloudWatch.LogAlarmTypes.WarmUpConfiguration CreateWarmUpConfiguration()
    {
        var warmUpConfigurationResult = new Humidifier.CloudWatch.LogAlarmTypes.WarmUpConfiguration();

        return warmUpConfigurationResult;
    }

} // End Of Class

public static class InnerLogAlarmWarmUpConfigurationFactoryExtensions
{
}
