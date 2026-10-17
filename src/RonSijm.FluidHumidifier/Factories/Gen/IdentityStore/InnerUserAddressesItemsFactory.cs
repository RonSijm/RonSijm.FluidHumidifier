// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class InnerUserAddressesItemsFactory(Action<Humidifier.IdentityStore.UserTypes.AddressesItems> factoryAction = null) : SubResourceFactory<Humidifier.IdentityStore.UserTypes.AddressesItems>
{

    protected override Humidifier.IdentityStore.UserTypes.AddressesItems Create()
    {
        var addressesItemsResult = CreateAddressesItems();
        factoryAction?.Invoke(addressesItemsResult);

        return addressesItemsResult;
    }

    private Humidifier.IdentityStore.UserTypes.AddressesItems CreateAddressesItems()
    {
        var addressesItemsResult = new Humidifier.IdentityStore.UserTypes.AddressesItems();

        return addressesItemsResult;
    }

} // End Of Class

public static class InnerUserAddressesItemsFactoryExtensions
{
}
