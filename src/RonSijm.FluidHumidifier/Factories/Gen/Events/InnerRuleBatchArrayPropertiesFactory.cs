// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleBatchArrayPropertiesFactory(Action<Humidifier.Events.RuleTypes.BatchArrayProperties> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.BatchArrayProperties>
{

    protected override Humidifier.Events.RuleTypes.BatchArrayProperties Create()
    {
        var batchArrayPropertiesResult = CreateBatchArrayProperties();
        factoryAction?.Invoke(batchArrayPropertiesResult);

        return batchArrayPropertiesResult;
    }

    private Humidifier.Events.RuleTypes.BatchArrayProperties CreateBatchArrayProperties()
    {
        var batchArrayPropertiesResult = new Humidifier.Events.RuleTypes.BatchArrayProperties();

        return batchArrayPropertiesResult;
    }

} // End Of Class

public static class InnerRuleBatchArrayPropertiesFactoryExtensions
{
}
