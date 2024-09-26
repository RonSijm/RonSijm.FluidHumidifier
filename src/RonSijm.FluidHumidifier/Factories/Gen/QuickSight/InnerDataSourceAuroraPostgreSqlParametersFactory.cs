// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceAuroraPostgreSqlParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.AuroraPostgreSqlParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.AuroraPostgreSqlParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.AuroraPostgreSqlParameters Create()
    {
        var auroraPostgreSqlParametersResult = CreateAuroraPostgreSqlParameters();
        factoryAction?.Invoke(auroraPostgreSqlParametersResult);

        return auroraPostgreSqlParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.AuroraPostgreSqlParameters CreateAuroraPostgreSqlParameters()
    {
        var auroraPostgreSqlParametersResult = new Humidifier.QuickSight.DataSourceTypes.AuroraPostgreSqlParameters();

        return auroraPostgreSqlParametersResult;
    }

} // End Of Class

public static class InnerDataSourceAuroraPostgreSqlParametersFactoryExtensions
{
}
