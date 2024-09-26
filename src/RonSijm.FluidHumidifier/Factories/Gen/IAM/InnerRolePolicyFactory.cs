// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class InnerRolePolicyFactory(Action<Humidifier.IAM.RoleTypes.Policy> factoryAction = null) : SubResourceFactory<Humidifier.IAM.RoleTypes.Policy>
{

    protected override Humidifier.IAM.RoleTypes.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.IAM.RoleTypes.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.IAM.RoleTypes.Policy();

        return policyResult;
    }

} // End Of Class

public static class InnerRolePolicyFactoryExtensions
{
}
