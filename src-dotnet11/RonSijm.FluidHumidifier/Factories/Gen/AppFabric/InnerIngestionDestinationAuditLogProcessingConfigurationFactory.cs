// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerIngestionDestinationAuditLogProcessingConfigurationFactory(Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration>
{

    protected override Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration Create()
    {
        var auditLogProcessingConfigurationResult = CreateAuditLogProcessingConfiguration();
        factoryAction?.Invoke(auditLogProcessingConfigurationResult);

        return auditLogProcessingConfigurationResult;
    }

    private Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration CreateAuditLogProcessingConfiguration()
    {
        var auditLogProcessingConfigurationResult = new Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration();

        return auditLogProcessingConfigurationResult;
    }

} // End Of Class

public static class InnerIngestionDestinationAuditLogProcessingConfigurationFactoryExtensions
{
}
