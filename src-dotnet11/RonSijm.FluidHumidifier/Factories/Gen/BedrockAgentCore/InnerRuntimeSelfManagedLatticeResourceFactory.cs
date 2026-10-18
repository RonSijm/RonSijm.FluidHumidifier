// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeSelfManagedLatticeResourceFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.SelfManagedLatticeResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.SelfManagedLatticeResource>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.SelfManagedLatticeResource Create()
    {
        var selfManagedLatticeResourceResult = CreateSelfManagedLatticeResource();
        factoryAction?.Invoke(selfManagedLatticeResourceResult);

        return selfManagedLatticeResourceResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.SelfManagedLatticeResource CreateSelfManagedLatticeResource()
    {
        var selfManagedLatticeResourceResult = new Humidifier.BedrockAgentCore.RuntimeTypes.SelfManagedLatticeResource();

        return selfManagedLatticeResourceResult;
    }

} // End Of Class

public static class InnerRuntimeSelfManagedLatticeResourceFactoryExtensions
{
}
