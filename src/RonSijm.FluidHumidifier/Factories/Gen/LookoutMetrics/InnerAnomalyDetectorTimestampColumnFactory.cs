// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorTimestampColumnFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn>
{

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn Create()
    {
        var timestampColumnResult = CreateTimestampColumn();
        factoryAction?.Invoke(timestampColumnResult);

        return timestampColumnResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn CreateTimestampColumn()
    {
        var timestampColumnResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn();

        return timestampColumnResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorTimestampColumnFactoryExtensions
{
}
