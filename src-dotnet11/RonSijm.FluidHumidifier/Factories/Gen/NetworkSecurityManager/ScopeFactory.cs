// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class ScopeFactory(string resourceName = null, Action<Humidifier.NetworkSecurityManager.Scope> factoryAction = null) : ResourceFactory<Humidifier.NetworkSecurityManager.Scope>(resourceName)
{

    protected override Humidifier.NetworkSecurityManager.Scope Create()
    {
        var scopeResult = CreateScope();
        factoryAction?.Invoke(scopeResult);

        return scopeResult;
    }

    private Humidifier.NetworkSecurityManager.Scope CreateScope()
    {
        var scopeResult = new Humidifier.NetworkSecurityManager.Scope
        {
            GivenName = InputResourceName,
        };

        return scopeResult;
    }

} // End Of Class

public static class ScopeFactoryExtensions
{
}
