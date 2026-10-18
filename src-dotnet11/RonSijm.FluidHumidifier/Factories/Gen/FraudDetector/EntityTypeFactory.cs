// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class EntityTypeFactory(string resourceName = null, Action<Humidifier.FraudDetector.EntityType> factoryAction = null) : ResourceFactory<Humidifier.FraudDetector.EntityType>(resourceName)
{

    protected override Humidifier.FraudDetector.EntityType Create()
    {
        var entityTypeResult = CreateEntityType();
        factoryAction?.Invoke(entityTypeResult);

        return entityTypeResult;
    }

    private Humidifier.FraudDetector.EntityType CreateEntityType()
    {
        var entityTypeResult = new Humidifier.FraudDetector.EntityType
        {
            GivenName = InputResourceName,
        };

        return entityTypeResult;
    }

} // End Of Class

public static class EntityTypeFactoryExtensions
{
}
