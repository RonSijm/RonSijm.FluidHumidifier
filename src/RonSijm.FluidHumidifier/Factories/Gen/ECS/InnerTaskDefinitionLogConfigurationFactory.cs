// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionLogConfigurationFactory(Action<Humidifier.ECS.TaskDefinitionTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.LogConfiguration>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.ECS.TaskDefinitionTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerTaskDefinitionLogConfigurationFactoryExtensions
{
}
