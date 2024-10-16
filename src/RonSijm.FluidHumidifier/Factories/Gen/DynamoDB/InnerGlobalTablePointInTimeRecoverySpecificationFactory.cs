// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTablePointInTimeRecoverySpecificationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.PointInTimeRecoverySpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.PointInTimeRecoverySpecification>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.PointInTimeRecoverySpecification Create()
    {
        var pointInTimeRecoverySpecificationResult = CreatePointInTimeRecoverySpecification();
        factoryAction?.Invoke(pointInTimeRecoverySpecificationResult);

        return pointInTimeRecoverySpecificationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.PointInTimeRecoverySpecification CreatePointInTimeRecoverySpecification()
    {
        var pointInTimeRecoverySpecificationResult = new Humidifier.DynamoDB.GlobalTableTypes.PointInTimeRecoverySpecification();

        return pointInTimeRecoverySpecificationResult;
    }

} // End Of Class

public static class InnerGlobalTablePointInTimeRecoverySpecificationFactoryExtensions
{
}
