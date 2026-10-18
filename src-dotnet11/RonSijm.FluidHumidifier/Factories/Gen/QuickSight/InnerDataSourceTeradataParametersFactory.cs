// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceTeradataParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.TeradataParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.TeradataParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.TeradataParameters Create()
    {
        var teradataParametersResult = CreateTeradataParameters();
        factoryAction?.Invoke(teradataParametersResult);

        return teradataParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.TeradataParameters CreateTeradataParameters()
    {
        var teradataParametersResult = new Humidifier.QuickSight.DataSourceTypes.TeradataParameters();

        return teradataParametersResult;
    }

} // End Of Class

public static class InnerDataSourceTeradataParametersFactoryExtensions
{
}
