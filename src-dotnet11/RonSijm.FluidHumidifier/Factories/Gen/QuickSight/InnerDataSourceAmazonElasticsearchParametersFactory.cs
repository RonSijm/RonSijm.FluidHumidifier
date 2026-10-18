// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceAmazonElasticsearchParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.AmazonElasticsearchParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.AmazonElasticsearchParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.AmazonElasticsearchParameters Create()
    {
        var amazonElasticsearchParametersResult = CreateAmazonElasticsearchParameters();
        factoryAction?.Invoke(amazonElasticsearchParametersResult);

        return amazonElasticsearchParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.AmazonElasticsearchParameters CreateAmazonElasticsearchParameters()
    {
        var amazonElasticsearchParametersResult = new Humidifier.QuickSight.DataSourceTypes.AmazonElasticsearchParameters();

        return amazonElasticsearchParametersResult;
    }

} // End Of Class

public static class InnerDataSourceAmazonElasticsearchParametersFactoryExtensions
{
}
