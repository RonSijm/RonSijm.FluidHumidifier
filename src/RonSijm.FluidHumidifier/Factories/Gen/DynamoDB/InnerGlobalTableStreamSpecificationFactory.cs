// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableStreamSpecificationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.StreamSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.StreamSpecification>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.StreamSpecification Create()
    {
        var streamSpecificationResult = CreateStreamSpecification();
        factoryAction?.Invoke(streamSpecificationResult);

        return streamSpecificationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.StreamSpecification CreateStreamSpecification()
    {
        var streamSpecificationResult = new Humidifier.DynamoDB.GlobalTableTypes.StreamSpecification();

        return streamSpecificationResult;
    }

} // End Of Class

public static class InnerGlobalTableStreamSpecificationFactoryExtensions
{
}
