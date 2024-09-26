// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class StackSetConstraintFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.StackSetConstraint> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.StackSetConstraint>(resourceName)
{

    protected override Humidifier.ServiceCatalog.StackSetConstraint Create()
    {
        var stackSetConstraintResult = CreateStackSetConstraint();
        factoryAction?.Invoke(stackSetConstraintResult);

        return stackSetConstraintResult;
    }

    private Humidifier.ServiceCatalog.StackSetConstraint CreateStackSetConstraint()
    {
        var stackSetConstraintResult = new Humidifier.ServiceCatalog.StackSetConstraint
        {
            GivenName = InputResourceName,
        };

        return stackSetConstraintResult;
    }

} // End Of Class

public static class StackSetConstraintFactoryExtensions
{
}
