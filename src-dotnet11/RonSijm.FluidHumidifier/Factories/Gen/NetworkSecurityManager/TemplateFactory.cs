// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class TemplateFactory(string resourceName = null, Action<Humidifier.NetworkSecurityManager.Template> factoryAction = null) : ResourceFactory<Humidifier.NetworkSecurityManager.Template>(resourceName)
{

    internal List<InnerTemplateAssociatedRuleFactory> AssociatedRuleListFactories { get; set; } = [];

    protected override Humidifier.NetworkSecurityManager.Template Create()
    {
        var templateResult = CreateTemplate();
        factoryAction?.Invoke(templateResult);

        return templateResult;
    }

    private Humidifier.NetworkSecurityManager.Template CreateTemplate()
    {
        var templateResult = new Humidifier.NetworkSecurityManager.Template
        {
            GivenName = InputResourceName,
        };

        return templateResult;
    }
    public override void CreateChildren(Humidifier.NetworkSecurityManager.Template result)
    {
        base.CreateChildren(result);

        result.AssociatedRuleList = AssociatedRuleListFactories.Any() ? AssociatedRuleListFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TemplateFactoryExtensions
{
    public static CombinedResult<TemplateFactory, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList(this TemplateFactory parentFactory, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null)
    {
        var factory = new InnerTemplateAssociatedRuleFactory(subFactoryAction);
        parentFactory.AssociatedRuleListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TemplateFactory, T1, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1>(this CombinedResult<TemplateFactory, T1> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1>(this CombinedResult<T1, TemplateFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2>(this CombinedResult<TemplateFactory, T1, T2> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2>(this CombinedResult<T1, TemplateFactory, T2> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2>(this CombinedResult<T1, T2, TemplateFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, T3, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3>(this CombinedResult<TemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, T3, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3>(this CombinedResult<T1, TemplateFactory, T2, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, T3, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3>(this CombinedResult<T1, T2, TemplateFactory, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TemplateFactory, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3>(this CombinedResult<T1, T2, T3, TemplateFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, T3, T4, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3, T4>(this CombinedResult<TemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, T3, T4, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3, T4>(this CombinedResult<T1, TemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, T3, T4, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3, T4>(this CombinedResult<T1, T2, TemplateFactory, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TemplateFactory, T4, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TemplateFactory, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TemplateFactory, InnerTemplateAssociatedRuleFactory> WithAssociatedRuleList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TemplateFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedRuleList(combinedResult.T5, subFactoryAction).T2);
}
