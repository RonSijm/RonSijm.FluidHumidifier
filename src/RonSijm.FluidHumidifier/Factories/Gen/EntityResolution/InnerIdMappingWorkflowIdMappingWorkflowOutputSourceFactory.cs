// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactory(Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource>
{

    protected override Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource Create()
    {
        var idMappingWorkflowOutputSourceResult = CreateIdMappingWorkflowOutputSource();
        factoryAction?.Invoke(idMappingWorkflowOutputSourceResult);

        return idMappingWorkflowOutputSourceResult;
    }

    private Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource CreateIdMappingWorkflowOutputSource()
    {
        var idMappingWorkflowOutputSourceResult = new Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowOutputSource();

        return idMappingWorkflowOutputSourceResult;
    }

} // End Of Class

public static class InnerIdMappingWorkflowIdMappingWorkflowOutputSourceFactoryExtensions
{
}
