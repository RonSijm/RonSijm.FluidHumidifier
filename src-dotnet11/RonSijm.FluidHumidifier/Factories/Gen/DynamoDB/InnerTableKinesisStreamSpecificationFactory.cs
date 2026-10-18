// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableKinesisStreamSpecificationFactory(Action<Humidifier.DynamoDB.TableTypes.KinesisStreamSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.KinesisStreamSpecification>
{

    protected override Humidifier.DynamoDB.TableTypes.KinesisStreamSpecification Create()
    {
        var kinesisStreamSpecificationResult = CreateKinesisStreamSpecification();
        factoryAction?.Invoke(kinesisStreamSpecificationResult);

        return kinesisStreamSpecificationResult;
    }

    private Humidifier.DynamoDB.TableTypes.KinesisStreamSpecification CreateKinesisStreamSpecification()
    {
        var kinesisStreamSpecificationResult = new Humidifier.DynamoDB.TableTypes.KinesisStreamSpecification();

        return kinesisStreamSpecificationResult;
    }

} // End Of Class

public static class InnerTableKinesisStreamSpecificationFactoryExtensions
{
}
