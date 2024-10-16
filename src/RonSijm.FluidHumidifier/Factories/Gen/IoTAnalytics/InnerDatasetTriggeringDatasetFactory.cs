// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetTriggeringDatasetFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset Create()
    {
        var triggeringDatasetResult = CreateTriggeringDataset();
        factoryAction?.Invoke(triggeringDatasetResult);

        return triggeringDatasetResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset CreateTriggeringDataset()
    {
        var triggeringDatasetResult = new Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset();

        return triggeringDatasetResult;
    }

} // End Of Class

public static class InnerDatasetTriggeringDatasetFactoryExtensions
{
}
