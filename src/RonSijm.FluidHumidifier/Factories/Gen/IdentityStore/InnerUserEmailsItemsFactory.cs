// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class InnerUserEmailsItemsFactory(Action<Humidifier.IdentityStore.UserTypes.EmailsItems> factoryAction = null) : SubResourceFactory<Humidifier.IdentityStore.UserTypes.EmailsItems>
{

    protected override Humidifier.IdentityStore.UserTypes.EmailsItems Create()
    {
        var emailsItemsResult = CreateEmailsItems();
        factoryAction?.Invoke(emailsItemsResult);

        return emailsItemsResult;
    }

    private Humidifier.IdentityStore.UserTypes.EmailsItems CreateEmailsItems()
    {
        var emailsItemsResult = new Humidifier.IdentityStore.UserTypes.EmailsItems();

        return emailsItemsResult;
    }

} // End Of Class

public static class InnerUserEmailsItemsFactoryExtensions
{
}
