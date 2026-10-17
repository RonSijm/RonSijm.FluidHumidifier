// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionLineageSyncScheduleFactory(Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule>
{

    protected override Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule Create()
    {
        var lineageSyncScheduleResult = CreateLineageSyncSchedule();
        factoryAction?.Invoke(lineageSyncScheduleResult);

        return lineageSyncScheduleResult;
    }

    private Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule CreateLineageSyncSchedule()
    {
        var lineageSyncScheduleResult = new Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule();

        return lineageSyncScheduleResult;
    }

} // End Of Class

public static class InnerConnectionLineageSyncScheduleFactoryExtensions
{
}
