// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerAccountAuditConfigurationAuditNotificationTargetFactory(Action<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget> factoryAction = null) : SubResourceFactory<Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget>
{

    protected override Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget Create()
    {
        var auditNotificationTargetResult = CreateAuditNotificationTarget();
        factoryAction?.Invoke(auditNotificationTargetResult);

        return auditNotificationTargetResult;
    }

    private Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget CreateAuditNotificationTarget()
    {
        var auditNotificationTargetResult = new Humidifier.IoT.AccountAuditConfigurationTypes.AuditNotificationTarget();

        return auditNotificationTargetResult;
    }

} // End Of Class

public static class InnerAccountAuditConfigurationAuditNotificationTargetFactoryExtensions
{
}
