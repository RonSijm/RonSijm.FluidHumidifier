// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactory(Action<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat>
{

    protected override Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat Create()
    {
        var connectionPoolConfigurationInfoFormatResult = CreateConnectionPoolConfigurationInfoFormat();
        factoryAction?.Invoke(connectionPoolConfigurationInfoFormatResult);

        return connectionPoolConfigurationInfoFormatResult;
    }

    private Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat CreateConnectionPoolConfigurationInfoFormat()
    {
        var connectionPoolConfigurationInfoFormatResult = new Humidifier.RDS.DBProxyTargetGroupTypes.ConnectionPoolConfigurationInfoFormat();

        return connectionPoolConfigurationInfoFormatResult;
    }

} // End Of Class

public static class InnerDBProxyTargetGroupConnectionPoolConfigurationInfoFormatFactoryExtensions
{
}
