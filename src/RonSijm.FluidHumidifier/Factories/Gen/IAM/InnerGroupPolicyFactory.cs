// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class InnerGroupPolicyFactory(Action<Humidifier.IAM.GroupTypes.Policy> factoryAction = null) : SubResourceFactory<Humidifier.IAM.GroupTypes.Policy>
{

    protected override Humidifier.IAM.GroupTypes.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.IAM.GroupTypes.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.IAM.GroupTypes.Policy();

        return policyResult;
    }

} // End Of Class

public static class InnerGroupPolicyFactoryExtensions
{
}
