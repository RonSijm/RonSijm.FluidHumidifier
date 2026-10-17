// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorFirehoseFactory(Action<Humidifier.MSK.ReplicatorTypes.Firehose> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.Firehose>
{

    protected override Humidifier.MSK.ReplicatorTypes.Firehose Create()
    {
        var firehoseResult = CreateFirehose();
        factoryAction?.Invoke(firehoseResult);

        return firehoseResult;
    }

    private Humidifier.MSK.ReplicatorTypes.Firehose CreateFirehose()
    {
        var firehoseResult = new Humidifier.MSK.ReplicatorTypes.Firehose();

        return firehoseResult;
    }

} // End Of Class

public static class InnerReplicatorFirehoseFactoryExtensions
{
}
