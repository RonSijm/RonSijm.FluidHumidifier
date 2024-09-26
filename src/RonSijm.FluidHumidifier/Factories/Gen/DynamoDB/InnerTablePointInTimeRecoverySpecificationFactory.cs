// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTablePointInTimeRecoverySpecificationFactory(Action<Humidifier.DynamoDB.TableTypes.PointInTimeRecoverySpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.PointInTimeRecoverySpecification>
{

    protected override Humidifier.DynamoDB.TableTypes.PointInTimeRecoverySpecification Create()
    {
        var pointInTimeRecoverySpecificationResult = CreatePointInTimeRecoverySpecification();
        factoryAction?.Invoke(pointInTimeRecoverySpecificationResult);

        return pointInTimeRecoverySpecificationResult;
    }

    private Humidifier.DynamoDB.TableTypes.PointInTimeRecoverySpecification CreatePointInTimeRecoverySpecification()
    {
        var pointInTimeRecoverySpecificationResult = new Humidifier.DynamoDB.TableTypes.PointInTimeRecoverySpecification();

        return pointInTimeRecoverySpecificationResult;
    }

} // End Of Class

public static class InnerTablePointInTimeRecoverySpecificationFactoryExtensions
{
}
