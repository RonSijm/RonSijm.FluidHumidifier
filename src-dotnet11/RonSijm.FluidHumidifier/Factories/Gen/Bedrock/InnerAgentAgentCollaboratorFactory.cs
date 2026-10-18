// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentAgentCollaboratorFactory(Action<Humidifier.Bedrock.AgentTypes.AgentCollaborator> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.AgentCollaborator>
{

    internal InnerAgentAgentDescriptorFactory AgentDescriptorFactory { get; set; }

    protected override Humidifier.Bedrock.AgentTypes.AgentCollaborator Create()
    {
        var agentCollaboratorResult = CreateAgentCollaborator();
        factoryAction?.Invoke(agentCollaboratorResult);

        return agentCollaboratorResult;
    }

    private Humidifier.Bedrock.AgentTypes.AgentCollaborator CreateAgentCollaborator()
    {
        var agentCollaboratorResult = new Humidifier.Bedrock.AgentTypes.AgentCollaborator();

        return agentCollaboratorResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.AgentTypes.AgentCollaborator result)
    {
        base.CreateChildren(result);

        result.AgentDescriptor ??= AgentDescriptorFactory?.Build();
    }

} // End Of Class

public static class InnerAgentAgentCollaboratorFactoryExtensions
{
    public static CombinedResult<InnerAgentAgentCollaboratorFactory, InnerAgentAgentDescriptorFactory> WithAgentDescriptor(this InnerAgentAgentCollaboratorFactory parentFactory, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null)
    {
        parentFactory.AgentDescriptorFactory = new InnerAgentAgentDescriptorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AgentDescriptorFactory);
    }

    public static CombinedResult<InnerAgentAgentCollaboratorFactory, T1, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1>(this CombinedResult<InnerAgentAgentCollaboratorFactory, T1> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentAgentCollaboratorFactory, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1>(this CombinedResult<T1, InnerAgentAgentCollaboratorFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAgentAgentCollaboratorFactory, T1, T2, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2>(this CombinedResult<InnerAgentAgentCollaboratorFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentAgentCollaboratorFactory, T2, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2>(this CombinedResult<T1, InnerAgentAgentCollaboratorFactory, T2> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentAgentCollaboratorFactory, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2>(this CombinedResult<T1, T2, InnerAgentAgentCollaboratorFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAgentAgentCollaboratorFactory, T1, T2, T3, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3>(this CombinedResult<InnerAgentAgentCollaboratorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentAgentCollaboratorFactory, T2, T3, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3>(this CombinedResult<T1, InnerAgentAgentCollaboratorFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentAgentCollaboratorFactory, T3, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, InnerAgentAgentCollaboratorFactory, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentAgentCollaboratorFactory, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAgentAgentCollaboratorFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAgentAgentCollaboratorFactory, T1, T2, T3, T4, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3, T4>(this CombinedResult<InnerAgentAgentCollaboratorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentAgentCollaboratorFactory, T2, T3, T4, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, InnerAgentAgentCollaboratorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentAgentCollaboratorFactory, T3, T4, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAgentAgentCollaboratorFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentAgentCollaboratorFactory, T4, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAgentAgentCollaboratorFactory, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAgentAgentCollaboratorFactory, InnerAgentAgentDescriptorFactory> WithAgentDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAgentAgentCollaboratorFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentDescriptor(combinedResult.T5, subFactoryAction).T2);
}
