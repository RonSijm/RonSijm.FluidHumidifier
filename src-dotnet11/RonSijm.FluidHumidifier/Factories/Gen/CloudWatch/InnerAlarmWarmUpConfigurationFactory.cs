// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmWarmUpConfigurationFactory(Action<Humidifier.CloudWatch.AlarmTypes.WarmUpConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.WarmUpConfiguration>
{

    protected override Humidifier.CloudWatch.AlarmTypes.WarmUpConfiguration Create()
    {
        var warmUpConfigurationResult = CreateWarmUpConfiguration();
        factoryAction?.Invoke(warmUpConfigurationResult);

        return warmUpConfigurationResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.WarmUpConfiguration CreateWarmUpConfiguration()
    {
        var warmUpConfigurationResult = new Humidifier.CloudWatch.AlarmTypes.WarmUpConfiguration();

        return warmUpConfigurationResult;
    }

} // End Of Class

public static class InnerAlarmWarmUpConfigurationFactoryExtensions
{
}
