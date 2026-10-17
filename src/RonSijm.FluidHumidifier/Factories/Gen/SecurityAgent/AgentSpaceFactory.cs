// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class AgentSpaceFactory(string resourceName = null, Action<Humidifier.SecurityAgent.AgentSpace> factoryAction = null) : ResourceFactory<Humidifier.SecurityAgent.AgentSpace>(resourceName)
{

    internal List<InnerAgentSpaceIntegratedResourceFactory> IntegratedResourcesFactories { get; set; } = [];

    internal InnerAgentSpaceCodeReviewSettingsFactory CodeReviewSettingsFactory { get; set; }

    internal InnerAgentSpaceAWSResourcesFactory AwsResourcesFactory { get; set; }

    protected override Humidifier.SecurityAgent.AgentSpace Create()
    {
        var agentSpaceResult = CreateAgentSpace();
        factoryAction?.Invoke(agentSpaceResult);

        return agentSpaceResult;
    }

    private Humidifier.SecurityAgent.AgentSpace CreateAgentSpace()
    {
        var agentSpaceResult = new Humidifier.SecurityAgent.AgentSpace
        {
            GivenName = InputResourceName,
        };

        return agentSpaceResult;
    }
    public override void CreateChildren(Humidifier.SecurityAgent.AgentSpace result)
    {
        base.CreateChildren(result);

        result.IntegratedResources = IntegratedResourcesFactories.Any() ? IntegratedResourcesFactories.Select(x => x.Build()).ToList() : null;
        result.CodeReviewSettings ??= CodeReviewSettingsFactory?.Build();
        result.AwsResources ??= AwsResourcesFactory?.Build();
    }

} // End Of Class

public static class AgentSpaceFactoryExtensions
{
    public static CombinedResult<AgentSpaceFactory, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources(this AgentSpaceFactory parentFactory, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null)
    {
        var factory = new InnerAgentSpaceIntegratedResourceFactory(subFactoryAction);
        parentFactory.IntegratedResourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AgentSpaceFactory, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings(this AgentSpaceFactory parentFactory, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null)
    {
        parentFactory.CodeReviewSettingsFactory = new InnerAgentSpaceCodeReviewSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeReviewSettingsFactory);
    }

    public static CombinedResult<AgentSpaceFactory, InnerAgentSpaceAWSResourcesFactory> WithAwsResources(this AgentSpaceFactory parentFactory, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null)
    {
        parentFactory.AwsResourcesFactory = new InnerAgentSpaceAWSResourcesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsResourcesFactory);
    }

    public static CombinedResult<AgentSpaceFactory, T1, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1>(this CombinedResult<AgentSpaceFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntegratedResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1>(this CombinedResult<T1, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntegratedResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2>(this CombinedResult<AgentSpaceFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2>(this CombinedResult<T1, AgentSpaceFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2>(this CombinedResult<T1, T2, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3>(this CombinedResult<AgentSpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3>(this CombinedResult<T1, AgentSpaceFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3>(this CombinedResult<T1, T2, AgentSpaceFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, T4, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3, T4>(this CombinedResult<AgentSpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, T4, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3, T4>(this CombinedResult<T1, AgentSpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, T4, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentSpaceFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, T4, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentSpaceFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgentSpaceFactory, InnerAgentSpaceIntegratedResourceFactory> WithIntegratedResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntegratedResources(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1>(this CombinedResult<AgentSpaceFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1>(this CombinedResult<T1, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2>(this CombinedResult<AgentSpaceFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2>(this CombinedResult<T1, AgentSpaceFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2>(this CombinedResult<T1, T2, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3>(this CombinedResult<AgentSpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3>(this CombinedResult<T1, AgentSpaceFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3>(this CombinedResult<T1, T2, AgentSpaceFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, T4, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3, T4>(this CombinedResult<AgentSpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, T4, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3, T4>(this CombinedResult<T1, AgentSpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, T4, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentSpaceFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, T4, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentSpaceFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgentSpaceFactory, InnerAgentSpaceCodeReviewSettingsFactory> WithCodeReviewSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeReviewSettings(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1>(this CombinedResult<AgentSpaceFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1>(this CombinedResult<T1, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2>(this CombinedResult<AgentSpaceFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2>(this CombinedResult<T1, AgentSpaceFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2>(this CombinedResult<T1, T2, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3>(this CombinedResult<AgentSpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3>(this CombinedResult<T1, AgentSpaceFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3>(this CombinedResult<T1, T2, AgentSpaceFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, T4, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3, T4>(this CombinedResult<AgentSpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, T4, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3, T4>(this CombinedResult<T1, AgentSpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, T4, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentSpaceFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, T4, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentSpaceFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgentSpaceFactory, InnerAgentSpaceAWSResourcesFactory> WithAwsResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentSpaceFactory> combinedResult, Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsResources(combinedResult.T5, subFactoryAction).T2);
}
