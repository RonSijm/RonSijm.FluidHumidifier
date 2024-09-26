// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionEphemeralStorageFactory(Action<Humidifier.Batch.JobDefinitionTypes.EphemeralStorage> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.EphemeralStorage>
{

    protected override Humidifier.Batch.JobDefinitionTypes.EphemeralStorage Create()
    {
        var ephemeralStorageResult = CreateEphemeralStorage();
        factoryAction?.Invoke(ephemeralStorageResult);

        return ephemeralStorageResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.EphemeralStorage CreateEphemeralStorage()
    {
        var ephemeralStorageResult = new Humidifier.Batch.JobDefinitionTypes.EphemeralStorage();

        return ephemeralStorageResult;
    }

} // End Of Class

public static class InnerJobDefinitionEphemeralStorageFactoryExtensions
{
}
