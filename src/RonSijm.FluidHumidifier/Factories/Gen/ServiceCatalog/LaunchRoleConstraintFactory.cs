// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class LaunchRoleConstraintFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.LaunchRoleConstraint> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.LaunchRoleConstraint>(resourceName)
{

    protected override Humidifier.ServiceCatalog.LaunchRoleConstraint Create()
    {
        var launchRoleConstraintResult = CreateLaunchRoleConstraint();
        factoryAction?.Invoke(launchRoleConstraintResult);

        return launchRoleConstraintResult;
    }

    private Humidifier.ServiceCatalog.LaunchRoleConstraint CreateLaunchRoleConstraint()
    {
        var launchRoleConstraintResult = new Humidifier.ServiceCatalog.LaunchRoleConstraint
        {
            GivenName = InputResourceName,
        };

        return launchRoleConstraintResult;
    }

} // End Of Class

public static class LaunchRoleConstraintFactoryExtensions
{
}
