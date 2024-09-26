// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerDetectorCFNKubernetesAuditLogsConfigurationFactory(Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration>
{

    protected override Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration Create()
    {
        var cFNKubernetesAuditLogsConfigurationResult = CreateCFNKubernetesAuditLogsConfiguration();
        factoryAction?.Invoke(cFNKubernetesAuditLogsConfigurationResult);

        return cFNKubernetesAuditLogsConfigurationResult;
    }

    private Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration CreateCFNKubernetesAuditLogsConfiguration()
    {
        var cFNKubernetesAuditLogsConfigurationResult = new Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration();

        return cFNKubernetesAuditLogsConfigurationResult;
    }

} // End Of Class

public static class InnerDetectorCFNKubernetesAuditLogsConfigurationFactoryExtensions
{
}
