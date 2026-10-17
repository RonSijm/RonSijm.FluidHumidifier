// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class InnerUserPhoneNumbersItemsFactory(Action<Humidifier.IdentityStore.UserTypes.PhoneNumbersItems> factoryAction = null) : SubResourceFactory<Humidifier.IdentityStore.UserTypes.PhoneNumbersItems>
{

    protected override Humidifier.IdentityStore.UserTypes.PhoneNumbersItems Create()
    {
        var phoneNumbersItemsResult = CreatePhoneNumbersItems();
        factoryAction?.Invoke(phoneNumbersItemsResult);

        return phoneNumbersItemsResult;
    }

    private Humidifier.IdentityStore.UserTypes.PhoneNumbersItems CreatePhoneNumbersItems()
    {
        var phoneNumbersItemsResult = new Humidifier.IdentityStore.UserTypes.PhoneNumbersItems();

        return phoneNumbersItemsResult;
    }

} // End Of Class

public static class InnerUserPhoneNumbersItemsFactoryExtensions
{
}
