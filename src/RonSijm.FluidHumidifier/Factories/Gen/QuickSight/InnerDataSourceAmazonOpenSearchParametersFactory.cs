// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceAmazonOpenSearchParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.AmazonOpenSearchParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.AmazonOpenSearchParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.AmazonOpenSearchParameters Create()
    {
        var amazonOpenSearchParametersResult = CreateAmazonOpenSearchParameters();
        factoryAction?.Invoke(amazonOpenSearchParametersResult);

        return amazonOpenSearchParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.AmazonOpenSearchParameters CreateAmazonOpenSearchParameters()
    {
        var amazonOpenSearchParametersResult = new Humidifier.QuickSight.DataSourceTypes.AmazonOpenSearchParameters();

        return amazonOpenSearchParametersResult;
    }

} // End Of Class

public static class InnerDataSourceAmazonOpenSearchParametersFactoryExtensions
{
}
