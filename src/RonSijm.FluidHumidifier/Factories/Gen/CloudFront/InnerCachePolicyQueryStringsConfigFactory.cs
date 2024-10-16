// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerCachePolicyQueryStringsConfigFactory(Action<Humidifier.CloudFront.CachePolicyTypes.QueryStringsConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.CachePolicyTypes.QueryStringsConfig>
{

    protected override Humidifier.CloudFront.CachePolicyTypes.QueryStringsConfig Create()
    {
        var queryStringsConfigResult = CreateQueryStringsConfig();
        factoryAction?.Invoke(queryStringsConfigResult);

        return queryStringsConfigResult;
    }

    private Humidifier.CloudFront.CachePolicyTypes.QueryStringsConfig CreateQueryStringsConfig()
    {
        var queryStringsConfigResult = new Humidifier.CloudFront.CachePolicyTypes.QueryStringsConfig();

        return queryStringsConfigResult;
    }

} // End Of Class

public static class InnerCachePolicyQueryStringsConfigFactoryExtensions
{
}
