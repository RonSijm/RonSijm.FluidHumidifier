// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCapacityProviderInstanceRequirementsFactory(Action<Humidifier.Lambda.CapacityProviderTypes.InstanceRequirements> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CapacityProviderTypes.InstanceRequirements>
{

    protected override Humidifier.Lambda.CapacityProviderTypes.InstanceRequirements Create()
    {
        var instanceRequirementsResult = CreateInstanceRequirements();
        factoryAction?.Invoke(instanceRequirementsResult);

        return instanceRequirementsResult;
    }

    private Humidifier.Lambda.CapacityProviderTypes.InstanceRequirements CreateInstanceRequirements()
    {
        var instanceRequirementsResult = new Humidifier.Lambda.CapacityProviderTypes.InstanceRequirements();

        return instanceRequirementsResult;
    }

} // End Of Class

public static class InnerCapacityProviderInstanceRequirementsFactoryExtensions
{
}
