// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetToolSchemaFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema>
{

    internal InnerGatewayTargetS3ConfigurationFactory S3Factory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema Create()
    {
        var toolSchemaResult = CreateToolSchema();
        factoryAction?.Invoke(toolSchemaResult);

        return toolSchemaResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema CreateToolSchema()
    {
        var toolSchemaResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema();

        return toolSchemaResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetToolSchemaFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetToolSchemaFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3(this InnerGatewayTargetToolSchemaFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerGatewayTargetS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerGatewayTargetToolSchemaFactory, T1, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1>(this CombinedResult<InnerGatewayTargetToolSchemaFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetToolSchemaFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1>(this CombinedResult<T1, InnerGatewayTargetToolSchemaFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetToolSchemaFactory, T1, T2, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<InnerGatewayTargetToolSchemaFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetToolSchemaFactory, T2, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerGatewayTargetToolSchemaFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetToolSchemaFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetToolSchemaFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetToolSchemaFactory, T1, T2, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerGatewayTargetToolSchemaFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetToolSchemaFactory, T2, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetToolSchemaFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetToolSchemaFactory, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetToolSchemaFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetToolSchemaFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetToolSchemaFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetToolSchemaFactory, T1, T2, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetToolSchemaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetToolSchemaFactory, T2, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetToolSchemaFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetToolSchemaFactory, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetToolSchemaFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetToolSchemaFactory, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetToolSchemaFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetToolSchemaFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetToolSchemaFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
