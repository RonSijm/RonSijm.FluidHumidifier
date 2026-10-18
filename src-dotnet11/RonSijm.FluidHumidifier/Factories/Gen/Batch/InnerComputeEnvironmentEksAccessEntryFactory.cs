// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentEksAccessEntryFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry Create()
    {
        var eksAccessEntryResult = CreateEksAccessEntry();
        factoryAction?.Invoke(eksAccessEntryResult);

        return eksAccessEntryResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry CreateEksAccessEntry()
    {
        var eksAccessEntryResult = new Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry();

        return eksAccessEntryResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentEksAccessEntryFactoryExtensions
{
}
