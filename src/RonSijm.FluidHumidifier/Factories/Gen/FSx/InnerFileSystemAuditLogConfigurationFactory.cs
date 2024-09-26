// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemAuditLogConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.AuditLogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.AuditLogConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.AuditLogConfiguration Create()
    {
        var auditLogConfigurationResult = CreateAuditLogConfiguration();
        factoryAction?.Invoke(auditLogConfigurationResult);

        return auditLogConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.AuditLogConfiguration CreateAuditLogConfiguration()
    {
        var auditLogConfigurationResult = new Humidifier.FSx.FileSystemTypes.AuditLogConfiguration();

        return auditLogConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemAuditLogConfigurationFactoryExtensions
{
}
