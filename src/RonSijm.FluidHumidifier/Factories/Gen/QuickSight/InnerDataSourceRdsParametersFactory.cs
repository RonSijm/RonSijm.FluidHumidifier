// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceRdsParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.RdsParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.RdsParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.RdsParameters Create()
    {
        var rdsParametersResult = CreateRdsParameters();
        factoryAction?.Invoke(rdsParametersResult);

        return rdsParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.RdsParameters CreateRdsParameters()
    {
        var rdsParametersResult = new Humidifier.QuickSight.DataSourceTypes.RdsParameters();

        return rdsParametersResult;
    }

} // End Of Class

public static class InnerDataSourceRdsParametersFactoryExtensions
{
}
