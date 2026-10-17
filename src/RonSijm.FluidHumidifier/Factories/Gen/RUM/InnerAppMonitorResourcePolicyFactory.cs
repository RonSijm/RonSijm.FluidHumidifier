// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RUM;

public class InnerAppMonitorResourcePolicyFactory(Action<Humidifier.RUM.AppMonitorTypes.ResourcePolicy> factoryAction = null) : SubResourceFactory<Humidifier.RUM.AppMonitorTypes.ResourcePolicy>
{

    protected override Humidifier.RUM.AppMonitorTypes.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.RUM.AppMonitorTypes.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.RUM.AppMonitorTypes.ResourcePolicy();

        return resourcePolicyResult;
    }

} // End Of Class

public static class InnerAppMonitorResourcePolicyFactoryExtensions
{
}
