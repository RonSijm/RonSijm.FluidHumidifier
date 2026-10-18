// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdMappingWorkflowIdMappingRuleBasedPropertiesFactory(Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingRuleBasedProperties> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingRuleBasedProperties>
{

    protected override Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingRuleBasedProperties Create()
    {
        var idMappingRuleBasedPropertiesResult = CreateIdMappingRuleBasedProperties();
        factoryAction?.Invoke(idMappingRuleBasedPropertiesResult);

        return idMappingRuleBasedPropertiesResult;
    }

    private Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingRuleBasedProperties CreateIdMappingRuleBasedProperties()
    {
        var idMappingRuleBasedPropertiesResult = new Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingRuleBasedProperties();

        return idMappingRuleBasedPropertiesResult;
    }

} // End Of Class

public static class InnerIdMappingWorkflowIdMappingRuleBasedPropertiesFactoryExtensions
{
}
