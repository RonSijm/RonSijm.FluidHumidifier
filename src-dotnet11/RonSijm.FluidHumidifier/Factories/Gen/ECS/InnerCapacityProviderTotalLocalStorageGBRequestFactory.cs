// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderTotalLocalStorageGBRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.TotalLocalStorageGBRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.TotalLocalStorageGBRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.TotalLocalStorageGBRequest Create()
    {
        var totalLocalStorageGBRequestResult = CreateTotalLocalStorageGBRequest();
        factoryAction?.Invoke(totalLocalStorageGBRequestResult);

        return totalLocalStorageGBRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.TotalLocalStorageGBRequest CreateTotalLocalStorageGBRequest()
    {
        var totalLocalStorageGBRequestResult = new Humidifier.ECS.CapacityProviderTypes.TotalLocalStorageGBRequest();

        return totalLocalStorageGBRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderTotalLocalStorageGBRequestFactoryExtensions
{
}
