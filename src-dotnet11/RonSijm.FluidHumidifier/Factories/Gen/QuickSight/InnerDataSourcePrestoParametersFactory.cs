// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourcePrestoParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.PrestoParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.PrestoParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.PrestoParameters Create()
    {
        var prestoParametersResult = CreatePrestoParameters();
        factoryAction?.Invoke(prestoParametersResult);

        return prestoParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.PrestoParameters CreatePrestoParameters()
    {
        var prestoParametersResult = new Humidifier.QuickSight.DataSourceTypes.PrestoParameters();

        return prestoParametersResult;
    }

} // End Of Class

public static class InnerDataSourcePrestoParametersFactoryExtensions
{
}
