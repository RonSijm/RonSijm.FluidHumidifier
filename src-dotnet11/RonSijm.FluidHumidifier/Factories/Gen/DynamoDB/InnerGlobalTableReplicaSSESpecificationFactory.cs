// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableReplicaSSESpecificationFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.ReplicaSSESpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.ReplicaSSESpecification>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.ReplicaSSESpecification Create()
    {
        var replicaSSESpecificationResult = CreateReplicaSSESpecification();
        factoryAction?.Invoke(replicaSSESpecificationResult);

        return replicaSSESpecificationResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.ReplicaSSESpecification CreateReplicaSSESpecification()
    {
        var replicaSSESpecificationResult = new Humidifier.DynamoDB.GlobalTableTypes.ReplicaSSESpecification();

        return replicaSSESpecificationResult;
    }

} // End Of Class

public static class InnerGlobalTableReplicaSSESpecificationFactoryExtensions
{
}
