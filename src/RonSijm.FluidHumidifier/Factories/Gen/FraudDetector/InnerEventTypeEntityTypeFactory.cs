// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class InnerEventTypeEntityTypeFactory(Action<Humidifier.FraudDetector.EventTypeTypes.EntityType> factoryAction = null) : SubResourceFactory<Humidifier.FraudDetector.EventTypeTypes.EntityType>
{

    protected override Humidifier.FraudDetector.EventTypeTypes.EntityType Create()
    {
        var entityTypeResult = CreateEntityType();
        factoryAction?.Invoke(entityTypeResult);

        return entityTypeResult;
    }

    private Humidifier.FraudDetector.EventTypeTypes.EntityType CreateEntityType()
    {
        var entityTypeResult = new Humidifier.FraudDetector.EventTypeTypes.EntityType();

        return entityTypeResult;
    }

} // End Of Class

public static class InnerEventTypeEntityTypeFactoryExtensions
{
}
