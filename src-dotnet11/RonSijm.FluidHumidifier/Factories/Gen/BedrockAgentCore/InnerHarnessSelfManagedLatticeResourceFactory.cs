// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessSelfManagedLatticeResourceFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.SelfManagedLatticeResource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.SelfManagedLatticeResource>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.SelfManagedLatticeResource Create()
    {
        var selfManagedLatticeResourceResult = CreateSelfManagedLatticeResource();
        factoryAction?.Invoke(selfManagedLatticeResourceResult);

        return selfManagedLatticeResourceResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.SelfManagedLatticeResource CreateSelfManagedLatticeResource()
    {
        var selfManagedLatticeResourceResult = new Humidifier.BedrockAgentCore.HarnessTypes.SelfManagedLatticeResource();

        return selfManagedLatticeResourceResult;
    }

} // End Of Class

public static class InnerHarnessSelfManagedLatticeResourceFactoryExtensions
{
}
