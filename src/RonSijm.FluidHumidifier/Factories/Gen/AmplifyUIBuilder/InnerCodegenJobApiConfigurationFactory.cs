// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerCodegenJobApiConfigurationFactory(Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration>
{

    internal InnerCodegenJobGraphQLRenderConfigFactory GraphQLConfigFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration Create()
    {
        var apiConfigurationResult = CreateApiConfiguration();
        factoryAction?.Invoke(apiConfigurationResult);

        return apiConfigurationResult;
    }

    private Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration CreateApiConfiguration()
    {
        var apiConfigurationResult = new Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration();

        return apiConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration result)
    {
        base.CreateChildren(result);

        result.GraphQLConfig ??= GraphQLConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCodegenJobApiConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCodegenJobApiConfigurationFactory, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig(this InnerCodegenJobApiConfigurationFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null)
    {
        parentFactory.GraphQLConfigFactory = new InnerCodegenJobGraphQLRenderConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GraphQLConfigFactory);
    }

    public static CombinedResult<InnerCodegenJobApiConfigurationFactory, T1, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1>(this CombinedResult<InnerCodegenJobApiConfigurationFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobApiConfigurationFactory, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1>(this CombinedResult<T1, InnerCodegenJobApiConfigurationFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobApiConfigurationFactory, T1, T2, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2>(this CombinedResult<InnerCodegenJobApiConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobApiConfigurationFactory, T2, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2>(this CombinedResult<T1, InnerCodegenJobApiConfigurationFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobApiConfigurationFactory, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2>(this CombinedResult<T1, T2, InnerCodegenJobApiConfigurationFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobApiConfigurationFactory, T1, T2, T3, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3>(this CombinedResult<InnerCodegenJobApiConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobApiConfigurationFactory, T2, T3, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3>(this CombinedResult<T1, InnerCodegenJobApiConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobApiConfigurationFactory, T3, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCodegenJobApiConfigurationFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodegenJobApiConfigurationFactory, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCodegenJobApiConfigurationFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobApiConfigurationFactory, T1, T2, T3, T4, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3, T4>(this CombinedResult<InnerCodegenJobApiConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobApiConfigurationFactory, T2, T3, T4, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCodegenJobApiConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobApiConfigurationFactory, T3, T4, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCodegenJobApiConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodegenJobApiConfigurationFactory, T4, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCodegenJobApiConfigurationFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCodegenJobApiConfigurationFactory, InnerCodegenJobGraphQLRenderConfigFactory> WithGraphQLConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCodegenJobApiConfigurationFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.GraphQLRenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGraphQLConfig(combinedResult.T5, subFactoryAction).T2);
}
