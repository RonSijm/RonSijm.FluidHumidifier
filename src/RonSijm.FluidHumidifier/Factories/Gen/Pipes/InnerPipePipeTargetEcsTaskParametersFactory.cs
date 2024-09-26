// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetEcsTaskParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetEcsTaskParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetEcsTaskParameters>
{

    internal InnerPipeEcsTaskOverrideFactory OverridesFactory { get; set; }

    internal InnerPipeNetworkConfigurationFactory NetworkConfigurationFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.PipeTargetEcsTaskParameters Create()
    {
        var pipeTargetEcsTaskParametersResult = CreatePipeTargetEcsTaskParameters();
        factoryAction?.Invoke(pipeTargetEcsTaskParametersResult);

        return pipeTargetEcsTaskParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetEcsTaskParameters CreatePipeTargetEcsTaskParameters()
    {
        var pipeTargetEcsTaskParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetEcsTaskParameters();

        return pipeTargetEcsTaskParametersResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.PipeTargetEcsTaskParameters result)
    {
        base.CreateChildren(result);

        result.Overrides ??= OverridesFactory?.Build();
        result.NetworkConfiguration ??= NetworkConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerPipePipeTargetEcsTaskParametersFactoryExtensions
{
    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeEcsTaskOverrideFactory> WithOverrides(this InnerPipePipeTargetEcsTaskParametersFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null)
    {
        parentFactory.OverridesFactory = new InnerPipeEcsTaskOverrideFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OverridesFactory);
    }

    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration(this InnerPipePipeTargetEcsTaskParametersFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null)
    {
        parentFactory.NetworkConfigurationFactory = new InnerPipeNetworkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkConfigurationFactory);
    }

    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1>(this CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1>(this CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2>(this CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2>(this CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2>(this CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, T3, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3>(this CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, T3, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, T3, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipePipeTargetEcsTaskParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, T3, T4, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, T3, T4, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, T3, T4, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeTargetEcsTaskParametersFactory, T4, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipePipeTargetEcsTaskParametersFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeEcsTaskOverrideFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipePipeTargetEcsTaskParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.EcsTaskOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, T3, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, T3, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, T3, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipePipeTargetEcsTaskParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, T3, T4, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPipePipeTargetEcsTaskParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, T3, T4, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipePipeTargetEcsTaskParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, T3, T4, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipePipeTargetEcsTaskParametersFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeTargetEcsTaskParametersFactory, T4, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipePipeTargetEcsTaskParametersFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipePipeTargetEcsTaskParametersFactory, InnerPipeNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipePipeTargetEcsTaskParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T5, subFactoryAction));
}
