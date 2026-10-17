// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdMappingWorkflowIdMappingIncrementalRunConfigFactory(Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingIncrementalRunConfig> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingIncrementalRunConfig>
{

    protected override Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingIncrementalRunConfig Create()
    {
        var idMappingIncrementalRunConfigResult = CreateIdMappingIncrementalRunConfig();
        factoryAction?.Invoke(idMappingIncrementalRunConfigResult);

        return idMappingIncrementalRunConfigResult;
    }

    private Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingIncrementalRunConfig CreateIdMappingIncrementalRunConfig()
    {
        var idMappingIncrementalRunConfigResult = new Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingIncrementalRunConfig();

        return idMappingIncrementalRunConfigResult;
    }

} // End Of Class

public static class InnerIdMappingWorkflowIdMappingIncrementalRunConfigFactoryExtensions
{
}
