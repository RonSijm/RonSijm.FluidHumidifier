// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class ConsumableResourceFactory(string resourceName = null, Action<Humidifier.Batch.ConsumableResource> factoryAction = null) : ResourceFactory<Humidifier.Batch.ConsumableResource>(resourceName)
{

    protected override Humidifier.Batch.ConsumableResource Create()
    {
        var consumableResourceResult = CreateConsumableResource();
        factoryAction?.Invoke(consumableResourceResult);

        return consumableResourceResult;
    }

    private Humidifier.Batch.ConsumableResource CreateConsumableResource()
    {
        var consumableResourceResult = new Humidifier.Batch.ConsumableResource
        {
            GivenName = InputResourceName,
        };

        return consumableResourceResult;
    }

} // End Of Class

public static class ConsumableResourceFactoryExtensions
{
}
