// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class StateMachineAliasFactory(string resourceName = null, Action<Humidifier.StepFunctions.StateMachineAlias> factoryAction = null) : ResourceFactory<Humidifier.StepFunctions.StateMachineAlias>(resourceName)
{

    internal List<InnerStateMachineAliasRoutingConfigurationVersionFactory> RoutingConfigurationFactories { get; set; } = [];

    internal InnerStateMachineAliasDeploymentPreferenceFactory DeploymentPreferenceFactory { get; set; }

    protected override Humidifier.StepFunctions.StateMachineAlias Create()
    {
        var stateMachineAliasResult = CreateStateMachineAlias();
        factoryAction?.Invoke(stateMachineAliasResult);

        return stateMachineAliasResult;
    }

    private Humidifier.StepFunctions.StateMachineAlias CreateStateMachineAlias()
    {
        var stateMachineAliasResult = new Humidifier.StepFunctions.StateMachineAlias
        {
            GivenName = InputResourceName,
        };

        return stateMachineAliasResult;
    }
    public override void CreateChildren(Humidifier.StepFunctions.StateMachineAlias result)
    {
        base.CreateChildren(result);

        result.RoutingConfiguration = RoutingConfigurationFactories.Any() ? RoutingConfigurationFactories.Select(x => x.Build()).ToList() : null;
        result.DeploymentPreference ??= DeploymentPreferenceFactory?.Build();
    }

} // End Of Class

public static class StateMachineAliasFactoryExtensions
{
    public static CombinedResult<StateMachineAliasFactory, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration(this StateMachineAliasFactory parentFactory, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null)
    {
        var factory = new InnerStateMachineAliasRoutingConfigurationVersionFactory(subFactoryAction);
        parentFactory.RoutingConfigurationFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<StateMachineAliasFactory, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference(this StateMachineAliasFactory parentFactory, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null)
    {
        parentFactory.DeploymentPreferenceFactory = new InnerStateMachineAliasDeploymentPreferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentPreferenceFactory);
    }

    public static CombinedResult<StateMachineAliasFactory, T1, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1>(this CombinedResult<StateMachineAliasFactory, T1> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StateMachineAliasFactory, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1>(this CombinedResult<T1, StateMachineAliasFactory> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StateMachineAliasFactory, T1, T2, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<StateMachineAliasFactory, T1, T2> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StateMachineAliasFactory, T2, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<T1, StateMachineAliasFactory, T2> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StateMachineAliasFactory, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<T1, T2, StateMachineAliasFactory> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StateMachineAliasFactory, T1, T2, T3, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<StateMachineAliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StateMachineAliasFactory, T2, T3, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, StateMachineAliasFactory, T2, T3> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StateMachineAliasFactory, T3, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, StateMachineAliasFactory, T3> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StateMachineAliasFactory, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, StateMachineAliasFactory> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StateMachineAliasFactory, T1, T2, T3, T4, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<StateMachineAliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StateMachineAliasFactory, T2, T3, T4, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, StateMachineAliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StateMachineAliasFactory, T3, T4, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, StateMachineAliasFactory, T3, T4> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StateMachineAliasFactory, T4, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StateMachineAliasFactory, T4> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StateMachineAliasFactory, InnerStateMachineAliasRoutingConfigurationVersionFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StateMachineAliasFactory> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.RoutingConfigurationVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<StateMachineAliasFactory, T1, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1>(this CombinedResult<StateMachineAliasFactory, T1> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StateMachineAliasFactory, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1>(this CombinedResult<T1, StateMachineAliasFactory> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StateMachineAliasFactory, T1, T2, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2>(this CombinedResult<StateMachineAliasFactory, T1, T2> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StateMachineAliasFactory, T2, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2>(this CombinedResult<T1, StateMachineAliasFactory, T2> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StateMachineAliasFactory, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2>(this CombinedResult<T1, T2, StateMachineAliasFactory> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StateMachineAliasFactory, T1, T2, T3, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3>(this CombinedResult<StateMachineAliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StateMachineAliasFactory, T2, T3, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3>(this CombinedResult<T1, StateMachineAliasFactory, T2, T3> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StateMachineAliasFactory, T3, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3>(this CombinedResult<T1, T2, StateMachineAliasFactory, T3> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StateMachineAliasFactory, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3>(this CombinedResult<T1, T2, T3, StateMachineAliasFactory> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StateMachineAliasFactory, T1, T2, T3, T4, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3, T4>(this CombinedResult<StateMachineAliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StateMachineAliasFactory, T2, T3, T4, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3, T4>(this CombinedResult<T1, StateMachineAliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StateMachineAliasFactory, T3, T4, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3, T4>(this CombinedResult<T1, T2, StateMachineAliasFactory, T3, T4> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StateMachineAliasFactory, T4, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StateMachineAliasFactory, T4> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StateMachineAliasFactory, InnerStateMachineAliasDeploymentPreferenceFactory> WithDeploymentPreference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StateMachineAliasFactory> combinedResult, Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPreference(combinedResult.T5, subFactoryAction));
}
