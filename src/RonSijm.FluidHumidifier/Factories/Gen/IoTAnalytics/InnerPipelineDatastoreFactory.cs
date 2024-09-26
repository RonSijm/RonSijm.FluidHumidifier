// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineDatastoreFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.Datastore> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.Datastore>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.Datastore Create()
    {
        var datastoreResult = CreateDatastore();
        factoryAction?.Invoke(datastoreResult);

        return datastoreResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.Datastore CreateDatastore()
    {
        var datastoreResult = new Humidifier.IoTAnalytics.PipelineTypes.Datastore();

        return datastoreResult;
    }

} // End Of Class

public static class InnerPipelineDatastoreFactoryExtensions
{
}
