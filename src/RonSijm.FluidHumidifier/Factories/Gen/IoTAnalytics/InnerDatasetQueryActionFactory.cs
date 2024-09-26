// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetQueryActionFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.QueryAction> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.QueryAction>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.QueryAction Create()
    {
        var queryActionResult = CreateQueryAction();
        factoryAction?.Invoke(queryActionResult);

        return queryActionResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.QueryAction CreateQueryAction()
    {
        var queryActionResult = new Humidifier.IoTAnalytics.DatasetTypes.QueryAction();

        return queryActionResult;
    }

} // End Of Class

public static class InnerDatasetQueryActionFactoryExtensions
{
}
