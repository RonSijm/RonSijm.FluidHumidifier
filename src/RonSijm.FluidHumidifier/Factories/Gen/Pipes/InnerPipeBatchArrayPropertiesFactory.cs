// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeBatchArrayPropertiesFactory(Action<Humidifier.Pipes.PipeTypes.BatchArrayProperties> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.BatchArrayProperties>
{

    protected override Humidifier.Pipes.PipeTypes.BatchArrayProperties Create()
    {
        var batchArrayPropertiesResult = CreateBatchArrayProperties();
        factoryAction?.Invoke(batchArrayPropertiesResult);

        return batchArrayPropertiesResult;
    }

    private Humidifier.Pipes.PipeTypes.BatchArrayProperties CreateBatchArrayProperties()
    {
        var batchArrayPropertiesResult = new Humidifier.Pipes.PipeTypes.BatchArrayProperties();

        return batchArrayPropertiesResult;
    }

} // End Of Class

public static class InnerPipeBatchArrayPropertiesFactoryExtensions
{
}
