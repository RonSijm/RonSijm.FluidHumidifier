// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration>
{

    protected override Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration Create()
    {
        var fieldPriorityDedupeStrategyConfigurationResult = CreateFieldPriorityDedupeStrategyConfiguration();
        factoryAction?.Invoke(fieldPriorityDedupeStrategyConfigurationResult);

        return fieldPriorityDedupeStrategyConfigurationResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration CreateFieldPriorityDedupeStrategyConfiguration()
    {
        var fieldPriorityDedupeStrategyConfigurationResult = new Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration();

        return fieldPriorityDedupeStrategyConfigurationResult;
    }

} // End Of Class

public static class InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactoryExtensions
{
}
