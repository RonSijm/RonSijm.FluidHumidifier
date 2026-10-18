// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class DelegationSetFactory(string resourceName = null, Action<Humidifier.Route53.DelegationSet> factoryAction = null) : ResourceFactory<Humidifier.Route53.DelegationSet>(resourceName)
{

    protected override Humidifier.Route53.DelegationSet Create()
    {
        var delegationSetResult = CreateDelegationSet();
        factoryAction?.Invoke(delegationSetResult);

        return delegationSetResult;
    }

    private Humidifier.Route53.DelegationSet CreateDelegationSet()
    {
        var delegationSetResult = new Humidifier.Route53.DelegationSet
        {
            GivenName = InputResourceName,
        };

        return delegationSetResult;
    }

} // End Of Class

public static class DelegationSetFactoryExtensions
{
}
