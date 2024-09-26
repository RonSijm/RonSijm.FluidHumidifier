// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdMappingWorkflowIntermediateSourceConfigurationFactory(Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration>
{

    protected override Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration Create()
    {
        var intermediateSourceConfigurationResult = CreateIntermediateSourceConfiguration();
        factoryAction?.Invoke(intermediateSourceConfigurationResult);

        return intermediateSourceConfigurationResult;
    }

    private Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration CreateIntermediateSourceConfiguration()
    {
        var intermediateSourceConfigurationResult = new Humidifier.EntityResolution.IdMappingWorkflowTypes.IntermediateSourceConfiguration();

        return intermediateSourceConfigurationResult;
    }

} // End Of Class

public static class InnerIdMappingWorkflowIntermediateSourceConfigurationFactoryExtensions
{
}
