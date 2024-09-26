// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FraudDetector;

public class InnerDetectorEntityTypeFactory(Action<Humidifier.FraudDetector.DetectorTypes.EntityType> factoryAction = null) : SubResourceFactory<Humidifier.FraudDetector.DetectorTypes.EntityType>
{

    protected override Humidifier.FraudDetector.DetectorTypes.EntityType Create()
    {
        var entityTypeResult = CreateEntityType();
        factoryAction?.Invoke(entityTypeResult);

        return entityTypeResult;
    }

    private Humidifier.FraudDetector.DetectorTypes.EntityType CreateEntityType()
    {
        var entityTypeResult = new Humidifier.FraudDetector.DetectorTypes.EntityType();

        return entityTypeResult;
    }

} // End Of Class

public static class InnerDetectorEntityTypeFactoryExtensions
{
}
