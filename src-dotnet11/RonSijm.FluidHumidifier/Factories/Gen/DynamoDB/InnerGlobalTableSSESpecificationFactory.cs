// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableSSESpecificationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.SSESpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.SSESpecification>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.SSESpecification Create()
    {
        var sSESpecificationResult = CreateSSESpecification();
        factoryAction?.Invoke(sSESpecificationResult);

        return sSESpecificationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.SSESpecification CreateSSESpecification()
    {
        var sSESpecificationResult = new Humidifier.DynamoDB.GlobalTableTypes.SSESpecification();

        return sSESpecificationResult;
    }

} // End Of Class

public static class InnerGlobalTableSSESpecificationFactoryExtensions
{
}
