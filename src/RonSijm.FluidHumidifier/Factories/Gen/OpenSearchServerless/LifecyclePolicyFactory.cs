// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class LifecyclePolicyFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.LifecyclePolicy> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.LifecyclePolicy>(resourceName)
{

    protected override Humidifier.OpenSearchServerless.LifecyclePolicy Create()
    {
        var lifecyclePolicyResult = CreateLifecyclePolicy();
        factoryAction?.Invoke(lifecyclePolicyResult);

        return lifecyclePolicyResult;
    }

    private Humidifier.OpenSearchServerless.LifecyclePolicy CreateLifecyclePolicy()
    {
        var lifecyclePolicyResult = new Humidifier.OpenSearchServerless.LifecyclePolicy
        {
            GivenName = InputResourceName,
        };

        return lifecyclePolicyResult;
    }

} // End Of Class

public static class LifecyclePolicyFactoryExtensions
{
}
