// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class TrustStoreFactory(string resourceName = null, Action<Humidifier.ElasticLoadBalancingV2.TrustStore> factoryAction = null) : ResourceFactory<Humidifier.ElasticLoadBalancingV2.TrustStore>(resourceName)
{

    protected override Humidifier.ElasticLoadBalancingV2.TrustStore Create()
    {
        var trustStoreResult = CreateTrustStore();
        factoryAction?.Invoke(trustStoreResult);

        return trustStoreResult;
    }

    private Humidifier.ElasticLoadBalancingV2.TrustStore CreateTrustStore()
    {
        var trustStoreResult = new Humidifier.ElasticLoadBalancingV2.TrustStore
        {
            GivenName = InputResourceName,
        };

        return trustStoreResult;
    }

} // End Of Class

public static class TrustStoreFactoryExtensions
{
}
