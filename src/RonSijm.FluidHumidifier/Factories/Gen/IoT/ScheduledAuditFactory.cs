// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class ScheduledAuditFactory(string resourceName = null, Action<Humidifier.IoT.ScheduledAudit> factoryAction = null) : ResourceFactory<Humidifier.IoT.ScheduledAudit>(resourceName)
{

    protected override Humidifier.IoT.ScheduledAudit Create()
    {
        var scheduledAuditResult = CreateScheduledAudit();
        factoryAction?.Invoke(scheduledAuditResult);

        return scheduledAuditResult;
    }

    private Humidifier.IoT.ScheduledAudit CreateScheduledAudit()
    {
        var scheduledAuditResult = new Humidifier.IoT.ScheduledAudit
        {
            GivenName = InputResourceName,
        };

        return scheduledAuditResult;
    }

} // End Of Class

public static class ScheduledAuditFactoryExtensions
{
}
