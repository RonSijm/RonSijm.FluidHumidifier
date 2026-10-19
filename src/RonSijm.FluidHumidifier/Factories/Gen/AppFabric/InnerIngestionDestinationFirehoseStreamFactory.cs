// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerIngestionDestinationFirehoseStreamFactory(Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream>
{

    protected override Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream Create()
    {
        var firehoseStreamResult = CreateFirehoseStream();
        factoryAction?.Invoke(firehoseStreamResult);

        return firehoseStreamResult;
    }

    private Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream CreateFirehoseStream()
    {
        var firehoseStreamResult = new Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream();

        return firehoseStreamResult;
    }

} // End Of Class

public static class InnerIngestionDestinationFirehoseStreamFactoryExtensions
{
}
