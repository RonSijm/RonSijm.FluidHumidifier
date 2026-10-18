// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class LaunchNotificationConstraintFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.LaunchNotificationConstraint> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.LaunchNotificationConstraint>(resourceName)
{

    protected override Humidifier.ServiceCatalog.LaunchNotificationConstraint Create()
    {
        var launchNotificationConstraintResult = CreateLaunchNotificationConstraint();
        factoryAction?.Invoke(launchNotificationConstraintResult);

        return launchNotificationConstraintResult;
    }

    private Humidifier.ServiceCatalog.LaunchNotificationConstraint CreateLaunchNotificationConstraint()
    {
        var launchNotificationConstraintResult = new Humidifier.ServiceCatalog.LaunchNotificationConstraint
        {
            GivenName = InputResourceName,
        };

        return launchNotificationConstraintResult;
    }

} // End Of Class

public static class LaunchNotificationConstraintFactoryExtensions
{
}
