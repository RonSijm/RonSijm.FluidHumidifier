// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceAthenaParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.AthenaParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.AthenaParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.AthenaParameters Create()
    {
        var athenaParametersResult = CreateAthenaParameters();
        factoryAction?.Invoke(athenaParametersResult);

        return athenaParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.AthenaParameters CreateAthenaParameters()
    {
        var athenaParametersResult = new Humidifier.QuickSight.DataSourceTypes.AthenaParameters();

        return athenaParametersResult;
    }

} // End Of Class

public static class InnerDataSourceAthenaParametersFactoryExtensions
{
}
