// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class DelegatedAdminFactory(string resourceName = null, Action<Humidifier.SecurityHub.DelegatedAdmin> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.DelegatedAdmin>(resourceName)
{

    protected override Humidifier.SecurityHub.DelegatedAdmin Create()
    {
        var delegatedAdminResult = CreateDelegatedAdmin();
        factoryAction?.Invoke(delegatedAdminResult);

        return delegatedAdminResult;
    }

    private Humidifier.SecurityHub.DelegatedAdmin CreateDelegatedAdmin()
    {
        var delegatedAdminResult = new Humidifier.SecurityHub.DelegatedAdmin
        {
            GivenName = InputResourceName,
        };

        return delegatedAdminResult;
    }

} // End Of Class

public static class DelegatedAdminFactoryExtensions
{
}
