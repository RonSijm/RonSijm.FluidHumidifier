// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerTrustStoreRevocationRevocationContentFactory(Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent>
{

    protected override Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent Create()
    {
        var revocationContentResult = CreateRevocationContent();
        factoryAction?.Invoke(revocationContentResult);

        return revocationContentResult;
    }

    private Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent CreateRevocationContent()
    {
        var revocationContentResult = new Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent();

        return revocationContentResult;
    }

} // End Of Class

public static class InnerTrustStoreRevocationRevocationContentFactoryExtensions
{
}
