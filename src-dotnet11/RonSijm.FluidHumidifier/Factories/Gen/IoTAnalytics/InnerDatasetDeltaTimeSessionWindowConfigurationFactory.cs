// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetDeltaTimeSessionWindowConfigurationFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration Create()
    {
        var deltaTimeSessionWindowConfigurationResult = CreateDeltaTimeSessionWindowConfiguration();
        factoryAction?.Invoke(deltaTimeSessionWindowConfigurationResult);

        return deltaTimeSessionWindowConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration CreateDeltaTimeSessionWindowConfiguration()
    {
        var deltaTimeSessionWindowConfigurationResult = new Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration();

        return deltaTimeSessionWindowConfigurationResult;
    }

} // End Of Class

public static class InnerDatasetDeltaTimeSessionWindowConfigurationFactoryExtensions
{
}
