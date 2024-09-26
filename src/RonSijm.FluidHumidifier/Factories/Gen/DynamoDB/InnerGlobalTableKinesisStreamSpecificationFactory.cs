// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableKinesisStreamSpecificationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.KinesisStreamSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.KinesisStreamSpecification>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.KinesisStreamSpecification Create()
    {
        var kinesisStreamSpecificationResult = CreateKinesisStreamSpecification();
        factoryAction?.Invoke(kinesisStreamSpecificationResult);

        return kinesisStreamSpecificationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.KinesisStreamSpecification CreateKinesisStreamSpecification()
    {
        var kinesisStreamSpecificationResult = new Humidifier.DynamoDB.GlobalTableTypes.KinesisStreamSpecification();

        return kinesisStreamSpecificationResult;
    }

} // End Of Class

public static class InnerGlobalTableKinesisStreamSpecificationFactoryExtensions
{
}
