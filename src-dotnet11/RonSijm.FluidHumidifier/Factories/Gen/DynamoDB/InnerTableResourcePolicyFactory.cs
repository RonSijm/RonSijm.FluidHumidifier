// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableResourcePolicyFactory(Action<Humidifier.DynamoDB.TableTypes.ResourcePolicy> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.ResourcePolicy>
{

    protected override Humidifier.DynamoDB.TableTypes.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.DynamoDB.TableTypes.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.DynamoDB.TableTypes.ResourcePolicy();

        return resourcePolicyResult;
    }

} // End Of Class

public static class InnerTableResourcePolicyFactoryExtensions
{
}
