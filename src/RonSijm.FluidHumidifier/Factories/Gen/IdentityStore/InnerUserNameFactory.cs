// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class InnerUserNameFactory(Action<Humidifier.IdentityStore.UserTypes.Name> factoryAction = null) : SubResourceFactory<Humidifier.IdentityStore.UserTypes.Name>
{

    protected override Humidifier.IdentityStore.UserTypes.Name Create()
    {
        var nameResult = CreateName();
        factoryAction?.Invoke(nameResult);

        return nameResult;
    }

    private Humidifier.IdentityStore.UserTypes.Name CreateName()
    {
        var nameResult = new Humidifier.IdentityStore.UserTypes.Name();

        return nameResult;
    }

} // End Of Class

public static class InnerUserNameFactoryExtensions
{
}
