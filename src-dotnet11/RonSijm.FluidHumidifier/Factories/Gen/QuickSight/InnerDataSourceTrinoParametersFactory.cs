// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceTrinoParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.TrinoParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.TrinoParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.TrinoParameters Create()
    {
        var trinoParametersResult = CreateTrinoParameters();
        factoryAction?.Invoke(trinoParametersResult);

        return trinoParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.TrinoParameters CreateTrinoParameters()
    {
        var trinoParametersResult = new Humidifier.QuickSight.DataSourceTypes.TrinoParameters();

        return trinoParametersResult;
    }

} // End Of Class

public static class InnerDataSourceTrinoParametersFactoryExtensions
{
}
