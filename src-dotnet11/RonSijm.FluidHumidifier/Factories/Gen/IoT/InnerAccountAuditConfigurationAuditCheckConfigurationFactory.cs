// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerAccountAuditConfigurationAuditCheckConfigurationFactory(Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration>
{

    protected override Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration Create()
    {
        var auditCheckConfigurationResult = CreateAuditCheckConfiguration();
        factoryAction?.Invoke(auditCheckConfigurationResult);

        return auditCheckConfigurationResult;
    }

    private Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration CreateAuditCheckConfiguration()
    {
        var auditCheckConfigurationResult = new Humidifier.IoT.AccountAuditConfigurationTypes.AuditCheckConfiguration();

        return auditCheckConfigurationResult;
    }

} // End Of Class

public static class InnerAccountAuditConfigurationAuditCheckConfigurationFactoryExtensions
{
}
