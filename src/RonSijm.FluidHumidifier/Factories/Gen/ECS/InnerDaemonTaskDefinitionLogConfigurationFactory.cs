// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionLogConfigurationFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.LogConfiguration>
{

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionLogConfigurationFactoryExtensions
{
}
