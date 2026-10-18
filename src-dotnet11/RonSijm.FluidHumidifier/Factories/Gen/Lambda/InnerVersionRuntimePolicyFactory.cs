// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerVersionRuntimePolicyFactory(Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.VersionTypes.RuntimePolicy>
{

    protected override Humidifier.Lambda.VersionTypes.RuntimePolicy Create()
    {
        var runtimePolicyResult = CreateRuntimePolicy();
        factoryAction?.Invoke(runtimePolicyResult);

        return runtimePolicyResult;
    }

    private Humidifier.Lambda.VersionTypes.RuntimePolicy CreateRuntimePolicy()
    {
        var runtimePolicyResult = new Humidifier.Lambda.VersionTypes.RuntimePolicy();

        return runtimePolicyResult;
    }

} // End Of Class

public static class InnerVersionRuntimePolicyFactoryExtensions
{
}
