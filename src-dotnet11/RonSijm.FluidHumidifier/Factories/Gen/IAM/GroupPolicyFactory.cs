// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class GroupPolicyFactory(string resourceName = null, Action<Humidifier.IAM.GroupPolicy> factoryAction = null) : ResourceFactory<Humidifier.IAM.GroupPolicy>(resourceName)
{

    protected override Humidifier.IAM.GroupPolicy Create()
    {
        var groupPolicyResult = CreateGroupPolicy();
        factoryAction?.Invoke(groupPolicyResult);

        return groupPolicyResult;
    }

    private Humidifier.IAM.GroupPolicy CreateGroupPolicy()
    {
        var groupPolicyResult = new Humidifier.IAM.GroupPolicy
        {
            GivenName = InputResourceName,
        };

        return groupPolicyResult;
    }

} // End Of Class

public static class GroupPolicyFactoryExtensions
{
}
