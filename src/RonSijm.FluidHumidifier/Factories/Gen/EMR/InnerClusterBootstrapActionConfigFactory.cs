// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterBootstrapActionConfigFactory(Action<Humidifier.EMR.ClusterTypes.BootstrapActionConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.BootstrapActionConfig>
{

    internal InnerClusterScriptBootstrapActionConfigFactory ScriptBootstrapActionFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.BootstrapActionConfig Create()
    {
        var bootstrapActionConfigResult = CreateBootstrapActionConfig();
        factoryAction?.Invoke(bootstrapActionConfigResult);

        return bootstrapActionConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.BootstrapActionConfig CreateBootstrapActionConfig()
    {
        var bootstrapActionConfigResult = new Humidifier.EMR.ClusterTypes.BootstrapActionConfig();

        return bootstrapActionConfigResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.BootstrapActionConfig result)
    {
        base.CreateChildren(result);

        result.ScriptBootstrapAction ??= ScriptBootstrapActionFactory?.Build();
    }

} // End Of Class

public static class InnerClusterBootstrapActionConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterBootstrapActionConfigFactory, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction(this InnerClusterBootstrapActionConfigFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null)
    {
        parentFactory.ScriptBootstrapActionFactory = new InnerClusterScriptBootstrapActionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScriptBootstrapActionFactory);
    }

    public static CombinedResult<InnerClusterBootstrapActionConfigFactory, T1, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1>(this CombinedResult<InnerClusterBootstrapActionConfigFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBootstrapActionConfigFactory, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1>(this CombinedResult<T1, InnerClusterBootstrapActionConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterBootstrapActionConfigFactory, T1, T2, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2>(this CombinedResult<InnerClusterBootstrapActionConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBootstrapActionConfigFactory, T2, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2>(this CombinedResult<T1, InnerClusterBootstrapActionConfigFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBootstrapActionConfigFactory, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2>(this CombinedResult<T1, T2, InnerClusterBootstrapActionConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterBootstrapActionConfigFactory, T1, T2, T3, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3>(this CombinedResult<InnerClusterBootstrapActionConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBootstrapActionConfigFactory, T2, T3, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3>(this CombinedResult<T1, InnerClusterBootstrapActionConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBootstrapActionConfigFactory, T3, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterBootstrapActionConfigFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBootstrapActionConfigFactory, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterBootstrapActionConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterBootstrapActionConfigFactory, T1, T2, T3, T4, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3, T4>(this CombinedResult<InnerClusterBootstrapActionConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBootstrapActionConfigFactory, T2, T3, T4, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterBootstrapActionConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBootstrapActionConfigFactory, T3, T4, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterBootstrapActionConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBootstrapActionConfigFactory, T4, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterBootstrapActionConfigFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterBootstrapActionConfigFactory, InnerClusterScriptBootstrapActionConfigFactory> WithScriptBootstrapAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterBootstrapActionConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScriptBootstrapAction(combinedResult.T5, subFactoryAction));
}
