// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataSourceHookConfigurationFactory(Action<Humidifier.QBusiness.DataSourceTypes.HookConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataSourceTypes.HookConfiguration>
{

    internal InnerDataSourceDocumentAttributeConditionFactory InvocationConditionFactory { get; set; }

    protected override Humidifier.QBusiness.DataSourceTypes.HookConfiguration Create()
    {
        var hookConfigurationResult = CreateHookConfiguration();
        factoryAction?.Invoke(hookConfigurationResult);

        return hookConfigurationResult;
    }

    private Humidifier.QBusiness.DataSourceTypes.HookConfiguration CreateHookConfiguration()
    {
        var hookConfigurationResult = new Humidifier.QBusiness.DataSourceTypes.HookConfiguration();

        return hookConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataSourceTypes.HookConfiguration result)
    {
        base.CreateChildren(result);

        result.InvocationCondition ??= InvocationConditionFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceHookConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceHookConfigurationFactory, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition(this InnerDataSourceHookConfigurationFactory parentFactory, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null)
    {
        parentFactory.InvocationConditionFactory = new InnerDataSourceDocumentAttributeConditionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InvocationConditionFactory);
    }

    public static CombinedResult<InnerDataSourceHookConfigurationFactory, T1, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1>(this CombinedResult<InnerDataSourceHookConfigurationFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithInvocationCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceHookConfigurationFactory, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1>(this CombinedResult<T1, InnerDataSourceHookConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithInvocationCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceHookConfigurationFactory, T1, T2, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2>(this CombinedResult<InnerDataSourceHookConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceHookConfigurationFactory, T2, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2>(this CombinedResult<T1, InnerDataSourceHookConfigurationFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceHookConfigurationFactory, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceHookConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceHookConfigurationFactory, T1, T2, T3, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3>(this CombinedResult<InnerDataSourceHookConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceHookConfigurationFactory, T2, T3, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceHookConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceHookConfigurationFactory, T3, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceHookConfigurationFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceHookConfigurationFactory, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceHookConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceHookConfigurationFactory, T1, T2, T3, T4, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceHookConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceHookConfigurationFactory, T2, T3, T4, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceHookConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceHookConfigurationFactory, T3, T4, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceHookConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceHookConfigurationFactory, T4, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceHookConfigurationFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceHookConfigurationFactory, InnerDataSourceDocumentAttributeConditionFactory> WithInvocationCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceHookConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentAttributeCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationCondition(combinedResult.T5, subFactoryAction));
}
