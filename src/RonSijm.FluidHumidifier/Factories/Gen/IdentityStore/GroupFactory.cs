// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class GroupFactory(string resourceName = null, Action<Humidifier.IdentityStore.Group> factoryAction = null) : ResourceFactory<Humidifier.IdentityStore.Group>(resourceName)
{

    protected override Humidifier.IdentityStore.Group Create()
    {
        var groupResult = CreateGroup();
        factoryAction?.Invoke(groupResult);

        return groupResult;
    }

    private Humidifier.IdentityStore.Group CreateGroup()
    {
        var groupResult = new Humidifier.IdentityStore.Group
        {
            GivenName = InputResourceName,
        };

        return groupResult;
    }

} // End Of Class

public static class GroupFactoryExtensions
{
}
