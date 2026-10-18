// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionFirelensConfigurationFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.FirelensConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.FirelensConfiguration>
{

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.FirelensConfiguration Create()
    {
        var firelensConfigurationResult = CreateFirelensConfiguration();
        factoryAction?.Invoke(firelensConfigurationResult);

        return firelensConfigurationResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.FirelensConfiguration CreateFirelensConfiguration()
    {
        var firelensConfigurationResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.FirelensConfiguration();

        return firelensConfigurationResult;
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionFirelensConfigurationFactoryExtensions
{
}
