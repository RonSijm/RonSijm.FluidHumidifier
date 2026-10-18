// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCodeInterpreterCustomVpcConfigFactory(Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig>
{

    protected override Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerCodeInterpreterCustomVpcConfigFactoryExtensions
{
}
