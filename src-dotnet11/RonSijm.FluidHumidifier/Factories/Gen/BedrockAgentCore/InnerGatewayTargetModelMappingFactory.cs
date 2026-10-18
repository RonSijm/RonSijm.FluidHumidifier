// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetModelMappingFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping>
{

    internal InnerGatewayTargetProviderPrefixFactory ProviderPrefixFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping Create()
    {
        var modelMappingResult = CreateModelMapping();
        factoryAction?.Invoke(modelMappingResult);

        return modelMappingResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping CreateModelMapping()
    {
        var modelMappingResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping();

        return modelMappingResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping result)
    {
        base.CreateChildren(result);

        result.ProviderPrefix ??= ProviderPrefixFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetModelMappingFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetModelMappingFactory, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix(this InnerGatewayTargetModelMappingFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null)
    {
        parentFactory.ProviderPrefixFactory = new InnerGatewayTargetProviderPrefixFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderPrefixFactory);
    }

    public static CombinedResult<InnerGatewayTargetModelMappingFactory, T1, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1>(this CombinedResult<InnerGatewayTargetModelMappingFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderPrefix(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetModelMappingFactory, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1>(this CombinedResult<T1, InnerGatewayTargetModelMappingFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderPrefix(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetModelMappingFactory, T1, T2, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2>(this CombinedResult<InnerGatewayTargetModelMappingFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetModelMappingFactory, T2, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2>(this CombinedResult<T1, InnerGatewayTargetModelMappingFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetModelMappingFactory, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetModelMappingFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetModelMappingFactory, T1, T2, T3, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3>(this CombinedResult<InnerGatewayTargetModelMappingFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetModelMappingFactory, T2, T3, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetModelMappingFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetModelMappingFactory, T3, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetModelMappingFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetModelMappingFactory, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetModelMappingFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetModelMappingFactory, T1, T2, T3, T4, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetModelMappingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetModelMappingFactory, T2, T3, T4, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetModelMappingFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetModelMappingFactory, T3, T4, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetModelMappingFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetModelMappingFactory, T4, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetModelMappingFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetModelMappingFactory, InnerGatewayTargetProviderPrefixFactory> WithProviderPrefix<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetModelMappingFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderPrefix(combinedResult.T5, subFactoryAction).T2);
}
