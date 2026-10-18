// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderAcceleratorCountRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.AcceleratorCountRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.AcceleratorCountRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.AcceleratorCountRequest Create()
    {
        var acceleratorCountRequestResult = CreateAcceleratorCountRequest();
        factoryAction?.Invoke(acceleratorCountRequestResult);

        return acceleratorCountRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.AcceleratorCountRequest CreateAcceleratorCountRequest()
    {
        var acceleratorCountRequestResult = new Humidifier.ECS.CapacityProviderTypes.AcceleratorCountRequest();

        return acceleratorCountRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderAcceleratorCountRequestFactoryExtensions
{
}
