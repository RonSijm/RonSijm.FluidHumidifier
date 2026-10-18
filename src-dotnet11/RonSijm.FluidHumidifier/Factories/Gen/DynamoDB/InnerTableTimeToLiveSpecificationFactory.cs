// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableTimeToLiveSpecificationFactory(Action<Humidifier.DynamoDB.TableTypes.TimeToLiveSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.TimeToLiveSpecification>
{

    protected override Humidifier.DynamoDB.TableTypes.TimeToLiveSpecification Create()
    {
        var timeToLiveSpecificationResult = CreateTimeToLiveSpecification();
        factoryAction?.Invoke(timeToLiveSpecificationResult);

        return timeToLiveSpecificationResult;
    }

    private Humidifier.DynamoDB.TableTypes.TimeToLiveSpecification CreateTimeToLiveSpecification()
    {
        var timeToLiveSpecificationResult = new Humidifier.DynamoDB.TableTypes.TimeToLiveSpecification();

        return timeToLiveSpecificationResult;
    }

} // End Of Class

public static class InnerTableTimeToLiveSpecificationFactoryExtensions
{
}
