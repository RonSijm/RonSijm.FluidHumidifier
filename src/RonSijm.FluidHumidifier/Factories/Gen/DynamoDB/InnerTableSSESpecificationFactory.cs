// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableSSESpecificationFactory(Action<Humidifier.DynamoDB.TableTypes.SSESpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.SSESpecification>
{

    protected override Humidifier.DynamoDB.TableTypes.SSESpecification Create()
    {
        var sSESpecificationResult = CreateSSESpecification();
        factoryAction?.Invoke(sSESpecificationResult);

        return sSESpecificationResult;
    }

    private Humidifier.DynamoDB.TableTypes.SSESpecification CreateSSESpecification()
    {
        var sSESpecificationResult = new Humidifier.DynamoDB.TableTypes.SSESpecification();

        return sSESpecificationResult;
    }

} // End Of Class

public static class InnerTableSSESpecificationFactoryExtensions
{
}
