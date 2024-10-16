// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class WorkteamFactory(string resourceName = null, Action<Humidifier.SageMaker.Workteam> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Workteam>(resourceName)
{

    internal List<InnerWorkteamMemberDefinitionFactory> MemberDefinitionsFactories { get; set; } = [];

    internal InnerWorkteamNotificationConfigurationFactory NotificationConfigurationFactory { get; set; }

    protected override Humidifier.SageMaker.Workteam Create()
    {
        var workteamResult = CreateWorkteam();
        factoryAction?.Invoke(workteamResult);

        return workteamResult;
    }

    private Humidifier.SageMaker.Workteam CreateWorkteam()
    {
        var workteamResult = new Humidifier.SageMaker.Workteam
        {
            GivenName = InputResourceName,
        };

        return workteamResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Workteam result)
    {
        base.CreateChildren(result);

        result.MemberDefinitions = MemberDefinitionsFactories.Any() ? MemberDefinitionsFactories.Select(x => x.Build()).ToList() : null;
        result.NotificationConfiguration ??= NotificationConfigurationFactory?.Build();
    }

} // End Of Class

public static class WorkteamFactoryExtensions
{
    public static CombinedResult<WorkteamFactory, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions(this WorkteamFactory parentFactory, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null)
    {
        var factory = new InnerWorkteamMemberDefinitionFactory(subFactoryAction);
        parentFactory.MemberDefinitionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkteamFactory, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration(this WorkteamFactory parentFactory, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null)
    {
        parentFactory.NotificationConfigurationFactory = new InnerWorkteamNotificationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NotificationConfigurationFactory);
    }

    public static CombinedResult<WorkteamFactory, T1, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1>(this CombinedResult<WorkteamFactory, T1> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkteamFactory, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1>(this CombinedResult<T1, WorkteamFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkteamFactory, T1, T2, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2>(this CombinedResult<WorkteamFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkteamFactory, T2, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2>(this CombinedResult<T1, WorkteamFactory, T2> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkteamFactory, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2>(this CombinedResult<T1, T2, WorkteamFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkteamFactory, T1, T2, T3, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3>(this CombinedResult<WorkteamFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkteamFactory, T2, T3, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3>(this CombinedResult<T1, WorkteamFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkteamFactory, T3, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, WorkteamFactory, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkteamFactory, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkteamFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkteamFactory, T1, T2, T3, T4, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3, T4>(this CombinedResult<WorkteamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkteamFactory, T2, T3, T4, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, WorkteamFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkteamFactory, T3, T4, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkteamFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkteamFactory, T4, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkteamFactory, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkteamFactory, InnerWorkteamMemberDefinitionFactory> WithMemberDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkteamFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.MemberDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberDefinitions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WorkteamFactory, T1, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1>(this CombinedResult<WorkteamFactory, T1> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkteamFactory, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1>(this CombinedResult<T1, WorkteamFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkteamFactory, T1, T2, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2>(this CombinedResult<WorkteamFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkteamFactory, T2, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2>(this CombinedResult<T1, WorkteamFactory, T2> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkteamFactory, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2>(this CombinedResult<T1, T2, WorkteamFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkteamFactory, T1, T2, T3, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3>(this CombinedResult<WorkteamFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkteamFactory, T2, T3, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, WorkteamFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkteamFactory, T3, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, WorkteamFactory, T3> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkteamFactory, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkteamFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkteamFactory, T1, T2, T3, T4, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<WorkteamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkteamFactory, T2, T3, T4, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, WorkteamFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkteamFactory, T3, T4, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkteamFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkteamFactory, T4, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkteamFactory, T4> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkteamFactory, InnerWorkteamNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkteamFactory> combinedResult, Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T5, subFactoryAction));
}
