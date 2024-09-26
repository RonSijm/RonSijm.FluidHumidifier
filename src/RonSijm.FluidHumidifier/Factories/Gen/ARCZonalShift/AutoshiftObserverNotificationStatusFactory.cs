// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ARCZonalShift;

public class AutoshiftObserverNotificationStatusFactory(string resourceName = null, Action<Humidifier.ARCZonalShift.AutoshiftObserverNotificationStatus> factoryAction = null) : ResourceFactory<Humidifier.ARCZonalShift.AutoshiftObserverNotificationStatus>(resourceName)
{

    protected override Humidifier.ARCZonalShift.AutoshiftObserverNotificationStatus Create()
    {
        var autoshiftObserverNotificationStatusResult = CreateAutoshiftObserverNotificationStatus();
        factoryAction?.Invoke(autoshiftObserverNotificationStatusResult);

        return autoshiftObserverNotificationStatusResult;
    }

    private Humidifier.ARCZonalShift.AutoshiftObserverNotificationStatus CreateAutoshiftObserverNotificationStatus()
    {
        var autoshiftObserverNotificationStatusResult = new Humidifier.ARCZonalShift.AutoshiftObserverNotificationStatus
        {
            GivenName = InputResourceName,
        };

        return autoshiftObserverNotificationStatusResult;
    }

} // End Of Class

public static class AutoshiftObserverNotificationStatusFactoryExtensions
{
}
