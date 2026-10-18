// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMQuickSetup;

public class LifecycleAutomationFactory(string resourceName = null, Action<Humidifier.SSMQuickSetup.LifecycleAutomation> factoryAction = null) : ResourceFactory<Humidifier.SSMQuickSetup.LifecycleAutomation>(resourceName)
{

    protected override Humidifier.SSMQuickSetup.LifecycleAutomation Create()
    {
        var lifecycleAutomationResult = CreateLifecycleAutomation();
        factoryAction?.Invoke(lifecycleAutomationResult);

        return lifecycleAutomationResult;
    }

    private Humidifier.SSMQuickSetup.LifecycleAutomation CreateLifecycleAutomation()
    {
        var lifecycleAutomationResult = new Humidifier.SSMQuickSetup.LifecycleAutomation
        {
            GivenName = InputResourceName,
        };

        return lifecycleAutomationResult;
    }

} // End Of Class

public static class LifecycleAutomationFactoryExtensions
{
}
