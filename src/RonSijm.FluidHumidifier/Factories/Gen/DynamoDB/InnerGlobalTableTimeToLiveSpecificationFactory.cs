// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableTimeToLiveSpecificationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.TimeToLiveSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.TimeToLiveSpecification>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.TimeToLiveSpecification Create()
    {
        var timeToLiveSpecificationResult = CreateTimeToLiveSpecification();
        factoryAction?.Invoke(timeToLiveSpecificationResult);

        return timeToLiveSpecificationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.TimeToLiveSpecification CreateTimeToLiveSpecification()
    {
        var timeToLiveSpecificationResult = new Humidifier.DynamoDB.GlobalTableTypes.TimeToLiveSpecification();

        return timeToLiveSpecificationResult;
    }

} // End Of Class

public static class InnerGlobalTableTimeToLiveSpecificationFactoryExtensions
{
}
