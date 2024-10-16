// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class ManagedPolicyFactory(string resourceName = null, Action<Humidifier.IAM.ManagedPolicy> factoryAction = null) : ResourceFactory<Humidifier.IAM.ManagedPolicy>(resourceName)
{

    protected override Humidifier.IAM.ManagedPolicy Create()
    {
        var managedPolicyResult = CreateManagedPolicy();
        factoryAction?.Invoke(managedPolicyResult);

        return managedPolicyResult;
    }

    private Humidifier.IAM.ManagedPolicy CreateManagedPolicy()
    {
        var managedPolicyResult = new Humidifier.IAM.ManagedPolicy
        {
            GivenName = InputResourceName,
        };

        return managedPolicyResult;
    }

} // End Of Class

public static class ManagedPolicyFactoryExtensions
{
}
