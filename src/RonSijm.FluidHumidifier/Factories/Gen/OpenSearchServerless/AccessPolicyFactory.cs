// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class AccessPolicyFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.AccessPolicy> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.AccessPolicy>(resourceName)
{

    protected override Humidifier.OpenSearchServerless.AccessPolicy Create()
    {
        var accessPolicyResult = CreateAccessPolicy();
        factoryAction?.Invoke(accessPolicyResult);

        return accessPolicyResult;
    }

    private Humidifier.OpenSearchServerless.AccessPolicy CreateAccessPolicy()
    {
        var accessPolicyResult = new Humidifier.OpenSearchServerless.AccessPolicy
        {
            GivenName = InputResourceName,
        };

        return accessPolicyResult;
    }

} // End Of Class

public static class AccessPolicyFactoryExtensions
{
}
