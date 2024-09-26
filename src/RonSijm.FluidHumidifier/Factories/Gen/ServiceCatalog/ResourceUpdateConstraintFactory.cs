// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class ResourceUpdateConstraintFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.ResourceUpdateConstraint> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.ResourceUpdateConstraint>(resourceName)
{

    protected override Humidifier.ServiceCatalog.ResourceUpdateConstraint Create()
    {
        var resourceUpdateConstraintResult = CreateResourceUpdateConstraint();
        factoryAction?.Invoke(resourceUpdateConstraintResult);

        return resourceUpdateConstraintResult;
    }

    private Humidifier.ServiceCatalog.ResourceUpdateConstraint CreateResourceUpdateConstraint()
    {
        var resourceUpdateConstraintResult = new Humidifier.ServiceCatalog.ResourceUpdateConstraint
        {
            GivenName = InputResourceName,
        };

        return resourceUpdateConstraintResult;
    }

} // End Of Class

public static class ResourceUpdateConstraintFactoryExtensions
{
}
