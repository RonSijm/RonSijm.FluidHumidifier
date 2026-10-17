// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class InnerUserRolesItemsFactory(Action<Humidifier.IdentityStore.UserTypes.RolesItems> factoryAction = null) : SubResourceFactory<Humidifier.IdentityStore.UserTypes.RolesItems>
{

    protected override Humidifier.IdentityStore.UserTypes.RolesItems Create()
    {
        var rolesItemsResult = CreateRolesItems();
        factoryAction?.Invoke(rolesItemsResult);

        return rolesItemsResult;
    }

    private Humidifier.IdentityStore.UserTypes.RolesItems CreateRolesItems()
    {
        var rolesItemsResult = new Humidifier.IdentityStore.UserTypes.RolesItems();

        return rolesItemsResult;
    }

} // End Of Class

public static class InnerUserRolesItemsFactoryExtensions
{
}
