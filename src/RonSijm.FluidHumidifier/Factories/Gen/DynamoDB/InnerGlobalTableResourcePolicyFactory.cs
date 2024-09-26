// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableResourcePolicyFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.DynamoDB.GlobalTableTypes.ResourcePolicy();

        return resourcePolicyResult;
    }

} // End Of Class

public static class InnerGlobalTableResourcePolicyFactoryExtensions
{
}
