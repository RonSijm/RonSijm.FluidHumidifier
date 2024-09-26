// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourcePostgreSqlParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.PostgreSqlParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.PostgreSqlParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.PostgreSqlParameters Create()
    {
        var postgreSqlParametersResult = CreatePostgreSqlParameters();
        factoryAction?.Invoke(postgreSqlParametersResult);

        return postgreSqlParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.PostgreSqlParameters CreatePostgreSqlParameters()
    {
        var postgreSqlParametersResult = new Humidifier.QuickSight.DataSourceTypes.PostgreSqlParameters();

        return postgreSqlParametersResult;
    }

} // End Of Class

public static class InnerDataSourcePostgreSqlParametersFactoryExtensions
{
}
