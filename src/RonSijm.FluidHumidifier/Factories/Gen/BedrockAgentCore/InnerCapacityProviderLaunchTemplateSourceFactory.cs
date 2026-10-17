// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderLaunchTemplateSourceFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchTemplateSource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchTemplateSource>
{

    internal InnerCapacityProviderLaunchParametersFactory LaunchParametersFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchTemplateSource Create()
    {
        var launchTemplateSourceResult = CreateLaunchTemplateSource();
        factoryAction?.Invoke(launchTemplateSourceResult);

        return launchTemplateSourceResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchTemplateSource CreateLaunchTemplateSource()
    {
        var launchTemplateSourceResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchTemplateSource();

        return launchTemplateSourceResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchTemplateSource result)
    {
        base.CreateChildren(result);

        result.LaunchParameters ??= LaunchParametersFactory?.Build();
    }

} // End Of Class

public static class InnerCapacityProviderLaunchTemplateSourceFactoryExtensions
{
    public static CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters(this InnerCapacityProviderLaunchTemplateSourceFactory parentFactory, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null)
    {
        parentFactory.LaunchParametersFactory = new InnerCapacityProviderLaunchParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchParametersFactory);
    }

    public static CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, T1, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1>(this CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderLaunchTemplateSourceFactory, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1>(this CombinedResult<T1, InnerCapacityProviderLaunchTemplateSourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, T1, T2, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2>(this CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderLaunchTemplateSourceFactory, T2, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2>(this CombinedResult<T1, InnerCapacityProviderLaunchTemplateSourceFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderLaunchTemplateSourceFactory, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2>(this CombinedResult<T1, T2, InnerCapacityProviderLaunchTemplateSourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, T1, T2, T3, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3>(this CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderLaunchTemplateSourceFactory, T2, T3, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3>(this CombinedResult<T1, InnerCapacityProviderLaunchTemplateSourceFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderLaunchTemplateSourceFactory, T3, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapacityProviderLaunchTemplateSourceFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderLaunchTemplateSourceFactory, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapacityProviderLaunchTemplateSourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, T1, T2, T3, T4, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3, T4>(this CombinedResult<InnerCapacityProviderLaunchTemplateSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderLaunchTemplateSourceFactory, T2, T3, T4, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapacityProviderLaunchTemplateSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderLaunchTemplateSourceFactory, T3, T4, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapacityProviderLaunchTemplateSourceFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderLaunchTemplateSourceFactory, T4, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapacityProviderLaunchTemplateSourceFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCapacityProviderLaunchTemplateSourceFactory, InnerCapacityProviderLaunchParametersFactory> WithLaunchParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapacityProviderLaunchTemplateSourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchParameters(combinedResult.T5, subFactoryAction).T2);
}
