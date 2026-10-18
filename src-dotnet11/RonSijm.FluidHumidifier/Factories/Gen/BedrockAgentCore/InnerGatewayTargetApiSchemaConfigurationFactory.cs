// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetApiSchemaConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration>
{

    internal InnerGatewayTargetS3ConfigurationFactory S3Factory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration Create()
    {
        var apiSchemaConfigurationResult = CreateApiSchemaConfiguration();
        factoryAction?.Invoke(apiSchemaConfigurationResult);

        return apiSchemaConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration CreateApiSchemaConfiguration()
    {
        var apiSchemaConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration();

        return apiSchemaConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetApiSchemaConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3(this InnerGatewayTargetApiSchemaConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerGatewayTargetS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, T1, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1>(this CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetApiSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1>(this CombinedResult<T1, InnerGatewayTargetApiSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, T1, T2, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetApiSchemaConfigurationFactory, T2, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerGatewayTargetApiSchemaConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetApiSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetApiSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, T1, T2, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetApiSchemaConfigurationFactory, T2, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetApiSchemaConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetApiSchemaConfigurationFactory, T3, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetApiSchemaConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetApiSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetApiSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetApiSchemaConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetApiSchemaConfigurationFactory, T2, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetApiSchemaConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetApiSchemaConfigurationFactory, T3, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetApiSchemaConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetApiSchemaConfigurationFactory, T4, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetApiSchemaConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetApiSchemaConfigurationFactory, InnerGatewayTargetS3ConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetApiSchemaConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
