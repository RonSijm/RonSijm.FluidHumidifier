// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonDaemonAlarmConfigurationFactory(Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration>
{

    protected override Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration Create()
    {
        var daemonAlarmConfigurationResult = CreateDaemonAlarmConfiguration();
        factoryAction?.Invoke(daemonAlarmConfigurationResult);

        return daemonAlarmConfigurationResult;
    }

    private Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration CreateDaemonAlarmConfiguration()
    {
        var daemonAlarmConfigurationResult = new Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration();

        return daemonAlarmConfigurationResult;
    }

} // End Of Class

public static class InnerDaemonDaemonAlarmConfigurationFactoryExtensions
{
}
