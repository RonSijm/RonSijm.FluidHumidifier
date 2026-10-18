// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessEnvironmentArtifactFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentArtifact> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentArtifact>
{

    internal InnerHarnessContainerConfigurationFactory ContainerConfigurationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentArtifact Create()
    {
        var harnessEnvironmentArtifactResult = CreateHarnessEnvironmentArtifact();
        factoryAction?.Invoke(harnessEnvironmentArtifactResult);

        return harnessEnvironmentArtifactResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentArtifact CreateHarnessEnvironmentArtifact()
    {
        var harnessEnvironmentArtifactResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentArtifact();

        return harnessEnvironmentArtifactResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentArtifact result)
    {
        base.CreateChildren(result);

        result.ContainerConfiguration ??= ContainerConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessEnvironmentArtifactFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration(this InnerHarnessHarnessEnvironmentArtifactFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null)
    {
        parentFactory.ContainerConfigurationFactory = new InnerHarnessContainerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerConfigurationFactory);
    }

    public static CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, T1, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1>(this CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessEnvironmentArtifactFactory, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1>(this CombinedResult<T1, InnerHarnessHarnessEnvironmentArtifactFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, T1, T2, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2>(this CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessEnvironmentArtifactFactory, T2, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessEnvironmentArtifactFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentArtifactFactory, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentArtifactFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, T1, T2, T3, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessEnvironmentArtifactFactory, T2, T3, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessEnvironmentArtifactFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentArtifactFactory, T3, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentArtifactFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessEnvironmentArtifactFactory, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessEnvironmentArtifactFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, T1, T2, T3, T4, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessEnvironmentArtifactFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessEnvironmentArtifactFactory, T2, T3, T4, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessEnvironmentArtifactFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentArtifactFactory, T3, T4, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentArtifactFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessEnvironmentArtifactFactory, T4, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessEnvironmentArtifactFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessEnvironmentArtifactFactory, InnerHarnessContainerConfigurationFactory> WithContainerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessEnvironmentArtifactFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerConfiguration(combinedResult.T5, subFactoryAction).T2);
}
