// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionFirelensConfigurationFactory(Action<Humidifier.ECS.TaskDefinitionTypes.FirelensConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.FirelensConfiguration>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.FirelensConfiguration Create()
    {
        var firelensConfigurationResult = CreateFirelensConfiguration();
        factoryAction?.Invoke(firelensConfigurationResult);

        return firelensConfigurationResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.FirelensConfiguration CreateFirelensConfiguration()
    {
        var firelensConfigurationResult = new Humidifier.ECS.TaskDefinitionTypes.FirelensConfiguration();

        return firelensConfigurationResult;
    }

} // End Of Class

public static class InnerTaskDefinitionFirelensConfigurationFactoryExtensions
{
}
