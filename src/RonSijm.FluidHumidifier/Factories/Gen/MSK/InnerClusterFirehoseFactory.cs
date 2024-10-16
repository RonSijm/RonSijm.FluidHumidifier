// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterFirehoseFactory(Action<Humidifier.MSK.ClusterTypes.Firehose> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.Firehose>
{

    protected override Humidifier.MSK.ClusterTypes.Firehose Create()
    {
        var firehoseResult = CreateFirehose();
        factoryAction?.Invoke(firehoseResult);

        return firehoseResult;
    }

    private Humidifier.MSK.ClusterTypes.Firehose CreateFirehose()
    {
        var firehoseResult = new Humidifier.MSK.ClusterTypes.Firehose();

        return firehoseResult;
    }

} // End Of Class

public static class InnerClusterFirehoseFactoryExtensions
{
}
