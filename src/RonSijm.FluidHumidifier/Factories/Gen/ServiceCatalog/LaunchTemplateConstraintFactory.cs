// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class LaunchTemplateConstraintFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.LaunchTemplateConstraint> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.LaunchTemplateConstraint>(resourceName)
{

    protected override Humidifier.ServiceCatalog.LaunchTemplateConstraint Create()
    {
        var launchTemplateConstraintResult = CreateLaunchTemplateConstraint();
        factoryAction?.Invoke(launchTemplateConstraintResult);

        return launchTemplateConstraintResult;
    }

    private Humidifier.ServiceCatalog.LaunchTemplateConstraint CreateLaunchTemplateConstraint()
    {
        var launchTemplateConstraintResult = new Humidifier.ServiceCatalog.LaunchTemplateConstraint
        {
            GivenName = InputResourceName,
        };

        return launchTemplateConstraintResult;
    }

} // End Of Class

public static class LaunchTemplateConstraintFactoryExtensions
{
}
