// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceDataSourceErrorInfoFactory(Action<Humidifier.QuickSight.DataSourceTypes.DataSourceErrorInfo> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.DataSourceErrorInfo>
{

    protected override Humidifier.QuickSight.DataSourceTypes.DataSourceErrorInfo Create()
    {
        var dataSourceErrorInfoResult = CreateDataSourceErrorInfo();
        factoryAction?.Invoke(dataSourceErrorInfoResult);

        return dataSourceErrorInfoResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.DataSourceErrorInfo CreateDataSourceErrorInfo()
    {
        var dataSourceErrorInfoResult = new Humidifier.QuickSight.DataSourceTypes.DataSourceErrorInfo();

        return dataSourceErrorInfoResult;
    }

} // End Of Class

public static class InnerDataSourceDataSourceErrorInfoFactoryExtensions
{
}
