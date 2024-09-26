// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class LifecycleHookFactory(string resourceName = null, Action<Humidifier.AutoScaling.LifecycleHook> factoryAction = null) : ResourceFactory<Humidifier.AutoScaling.LifecycleHook>(resourceName)
{

    protected override Humidifier.AutoScaling.LifecycleHook Create()
    {
        var lifecycleHookResult = CreateLifecycleHook();
        factoryAction?.Invoke(lifecycleHookResult);

        return lifecycleHookResult;
    }

    private Humidifier.AutoScaling.LifecycleHook CreateLifecycleHook()
    {
        var lifecycleHookResult = new Humidifier.AutoScaling.LifecycleHook
        {
            GivenName = InputResourceName,
        };

        return lifecycleHookResult;
    }

} // End Of Class

public static class LifecycleHookFactoryExtensions
{
}
