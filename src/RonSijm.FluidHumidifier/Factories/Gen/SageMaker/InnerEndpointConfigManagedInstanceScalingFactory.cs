// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigManagedInstanceScalingFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling Create()
    {
        var managedInstanceScalingResult = CreateManagedInstanceScaling();
        factoryAction?.Invoke(managedInstanceScalingResult);

        return managedInstanceScalingResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling CreateManagedInstanceScaling()
    {
        var managedInstanceScalingResult = new Humidifier.SageMaker.EndpointConfigTypes.ManagedInstanceScaling();

        return managedInstanceScalingResult;
    }

} // End Of Class

public static class InnerEndpointConfigManagedInstanceScalingFactoryExtensions
{
}
