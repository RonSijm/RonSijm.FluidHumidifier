// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationSqlApplicationConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.SqlApplicationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.SqlApplicationConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.SqlApplicationConfiguration Create()
    {
        var sqlApplicationConfigurationResult = CreateSqlApplicationConfiguration();
        factoryAction?.Invoke(sqlApplicationConfigurationResult);

        return sqlApplicationConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.SqlApplicationConfiguration CreateSqlApplicationConfiguration()
    {
        var sqlApplicationConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.SqlApplicationConfiguration();

        return sqlApplicationConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationSqlApplicationConfigurationFactoryExtensions
{
}
