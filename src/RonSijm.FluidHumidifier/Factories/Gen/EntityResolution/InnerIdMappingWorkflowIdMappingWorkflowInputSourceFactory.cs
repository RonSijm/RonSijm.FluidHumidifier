// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactory(Action<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource>
{

    protected override Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource Create()
    {
        var idMappingWorkflowInputSourceResult = CreateIdMappingWorkflowInputSource();
        factoryAction?.Invoke(idMappingWorkflowInputSourceResult);

        return idMappingWorkflowInputSourceResult;
    }

    private Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource CreateIdMappingWorkflowInputSource()
    {
        var idMappingWorkflowInputSourceResult = new Humidifier.EntityResolution.IdMappingWorkflowTypes.IdMappingWorkflowInputSource();

        return idMappingWorkflowInputSourceResult;
    }

} // End Of Class

public static class InnerIdMappingWorkflowIdMappingWorkflowInputSourceFactoryExtensions
{
}
