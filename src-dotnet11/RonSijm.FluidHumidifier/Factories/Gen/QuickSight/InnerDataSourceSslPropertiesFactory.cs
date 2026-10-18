// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceSslPropertiesFactory(Action<Humidifier.QuickSight.DataSourceTypes.SslProperties> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.SslProperties>
{

    protected override Humidifier.QuickSight.DataSourceTypes.SslProperties Create()
    {
        var sslPropertiesResult = CreateSslProperties();
        factoryAction?.Invoke(sslPropertiesResult);

        return sslPropertiesResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.SslProperties CreateSslProperties()
    {
        var sslPropertiesResult = new Humidifier.QuickSight.DataSourceTypes.SslProperties();

        return sslPropertiesResult;
    }

} // End Of Class

public static class InnerDataSourceSslPropertiesFactoryExtensions
{
}
