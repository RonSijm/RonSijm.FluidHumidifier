// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerWarmPoolInstanceReusePolicyFactory(Action<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy>
{

    protected override Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy Create()
    {
        var instanceReusePolicyResult = CreateInstanceReusePolicy();
        factoryAction?.Invoke(instanceReusePolicyResult);

        return instanceReusePolicyResult;
    }

    private Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy CreateInstanceReusePolicy()
    {
        var instanceReusePolicyResult = new Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy();

        return instanceReusePolicyResult;
    }

} // End Of Class

public static class InnerWarmPoolInstanceReusePolicyFactoryExtensions
{
}
