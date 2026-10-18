// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionConsumableResourcePropertiesFactory(Action<Humidifier.Batch.JobDefinitionTypes.ConsumableResourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.ConsumableResourceProperties>
{

    protected override Humidifier.Batch.JobDefinitionTypes.ConsumableResourceProperties Create()
    {
        var consumableResourcePropertiesResult = CreateConsumableResourceProperties();
        factoryAction?.Invoke(consumableResourcePropertiesResult);

        return consumableResourcePropertiesResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.ConsumableResourceProperties CreateConsumableResourceProperties()
    {
        var consumableResourcePropertiesResult = new Humidifier.Batch.JobDefinitionTypes.ConsumableResourceProperties();

        return consumableResourcePropertiesResult;
    }

} // End Of Class

public static class InnerJobDefinitionConsumableResourcePropertiesFactoryExtensions
{
}
