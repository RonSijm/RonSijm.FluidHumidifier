// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class InnerUserPolicyFactory(Action<Humidifier.IAM.UserTypes.Policy> factoryAction = null) : SubResourceFactory<Humidifier.IAM.UserTypes.Policy>
{

    protected override Humidifier.IAM.UserTypes.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.IAM.UserTypes.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.IAM.UserTypes.Policy();

        return policyResult;
    }

} // End Of Class

public static class InnerUserPolicyFactoryExtensions
{
}
