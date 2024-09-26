// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderManagedScalingFactory(Action<Humidifier.ECS.CapacityProviderTypes.ManagedScaling> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.ManagedScaling>
{

    protected override Humidifier.ECS.CapacityProviderTypes.ManagedScaling Create()
    {
        var managedScalingResult = CreateManagedScaling();
        factoryAction?.Invoke(managedScalingResult);

        return managedScalingResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.ManagedScaling CreateManagedScaling()
    {
        var managedScalingResult = new Humidifier.ECS.CapacityProviderTypes.ManagedScaling();

        return managedScalingResult;
    }

} // End Of Class

public static class InnerCapacityProviderManagedScalingFactoryExtensions
{
}
