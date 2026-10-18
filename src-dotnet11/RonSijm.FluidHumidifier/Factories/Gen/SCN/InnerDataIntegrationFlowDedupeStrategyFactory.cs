// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowDedupeStrategyFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy>
{

    internal InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory FieldPriorityFactory { get; set; }

    protected override Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy Create()
    {
        var dedupeStrategyResult = CreateDedupeStrategy();
        factoryAction?.Invoke(dedupeStrategyResult);

        return dedupeStrategyResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy CreateDedupeStrategy()
    {
        var dedupeStrategyResult = new Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy();

        return dedupeStrategyResult;
    }
    public override void CreateChildren(Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy result)
    {
        base.CreateChildren(result);

        result.FieldPriority ??= FieldPriorityFactory?.Build();
    }

} // End Of Class

public static class InnerDataIntegrationFlowDedupeStrategyFactoryExtensions
{
    public static CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority(this InnerDataIntegrationFlowDedupeStrategyFactory parentFactory, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null)
    {
        parentFactory.FieldPriorityFactory = new InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldPriorityFactory);
    }

    public static CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, T1, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1>(this CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, T1> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldPriority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDedupeStrategyFactory, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1>(this CombinedResult<T1, InnerDataIntegrationFlowDedupeStrategyFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldPriority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, T1, T2, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2>(this CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDedupeStrategyFactory, T2, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2>(this CombinedResult<T1, InnerDataIntegrationFlowDedupeStrategyFactory, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDedupeStrategyFactory, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDedupeStrategyFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, T1, T2, T3, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3>(this CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDedupeStrategyFactory, T2, T3, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3>(this CombinedResult<T1, InnerDataIntegrationFlowDedupeStrategyFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDedupeStrategyFactory, T3, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDedupeStrategyFactory, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDedupeStrategyFactory, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDedupeStrategyFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, T1, T2, T3, T4, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3, T4>(this CombinedResult<InnerDataIntegrationFlowDedupeStrategyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDedupeStrategyFactory, T2, T3, T4, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataIntegrationFlowDedupeStrategyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDedupeStrategyFactory, T3, T4, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDedupeStrategyFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDedupeStrategyFactory, T4, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDedupeStrategyFactory, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDedupeStrategyFactory, InnerDataIntegrationFlowFieldPriorityDedupeStrategyConfigurationFactory> WithFieldPriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDedupeStrategyFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldPriority(combinedResult.T5, subFactoryAction).T2);
}
