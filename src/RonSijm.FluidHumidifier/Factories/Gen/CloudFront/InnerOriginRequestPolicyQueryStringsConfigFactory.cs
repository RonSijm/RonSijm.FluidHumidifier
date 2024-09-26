// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerOriginRequestPolicyQueryStringsConfigFactory(Action<Humidifier.CloudFront.OriginRequestPolicyTypes.QueryStringsConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.OriginRequestPolicyTypes.QueryStringsConfig>
{

    protected override Humidifier.CloudFront.OriginRequestPolicyTypes.QueryStringsConfig Create()
    {
        var queryStringsConfigResult = CreateQueryStringsConfig();
        factoryAction?.Invoke(queryStringsConfigResult);

        return queryStringsConfigResult;
    }

    private Humidifier.CloudFront.OriginRequestPolicyTypes.QueryStringsConfig CreateQueryStringsConfig()
    {
        var queryStringsConfigResult = new Humidifier.CloudFront.OriginRequestPolicyTypes.QueryStringsConfig();

        return queryStringsConfigResult;
    }

} // End Of Class

public static class InnerOriginRequestPolicyQueryStringsConfigFactoryExtensions
{
}
