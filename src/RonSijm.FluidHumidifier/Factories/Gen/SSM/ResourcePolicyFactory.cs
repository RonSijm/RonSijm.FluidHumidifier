// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.SSM.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.SSM.ResourcePolicy>(resourceName)
{

    protected override Humidifier.SSM.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.SSM.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.SSM.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
