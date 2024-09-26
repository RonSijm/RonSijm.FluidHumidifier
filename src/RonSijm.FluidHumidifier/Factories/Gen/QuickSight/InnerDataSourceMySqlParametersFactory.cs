// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceMySqlParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.MySqlParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.MySqlParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.MySqlParameters Create()
    {
        var mySqlParametersResult = CreateMySqlParameters();
        factoryAction?.Invoke(mySqlParametersResult);

        return mySqlParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.MySqlParameters CreateMySqlParameters()
    {
        var mySqlParametersResult = new Humidifier.QuickSight.DataSourceTypes.MySqlParameters();

        return mySqlParametersResult;
    }

} // End Of Class

public static class InnerDataSourceMySqlParametersFactoryExtensions
{
}
