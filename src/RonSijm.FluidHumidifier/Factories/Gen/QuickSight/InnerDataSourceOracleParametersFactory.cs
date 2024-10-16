// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceOracleParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.OracleParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.OracleParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.OracleParameters Create()
    {
        var oracleParametersResult = CreateOracleParameters();
        factoryAction?.Invoke(oracleParametersResult);

        return oracleParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.OracleParameters CreateOracleParameters()
    {
        var oracleParametersResult = new Humidifier.QuickSight.DataSourceTypes.OracleParameters();

        return oracleParametersResult;
    }

} // End Of Class

public static class InnerDataSourceOracleParametersFactoryExtensions
{
}
