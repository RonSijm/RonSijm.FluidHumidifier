// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceStarburstParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.StarburstParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.StarburstParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.StarburstParameters Create()
    {
        var starburstParametersResult = CreateStarburstParameters();
        factoryAction?.Invoke(starburstParametersResult);

        return starburstParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.StarburstParameters CreateStarburstParameters()
    {
        var starburstParametersResult = new Humidifier.QuickSight.DataSourceTypes.StarburstParameters();

        return starburstParametersResult;
    }

} // End Of Class

public static class InnerDataSourceStarburstParametersFactoryExtensions
{
}
