// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyPolicyDefinitionFactory(Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition>
{

    internal InnerPolicyStaticPolicyDefinitionFactory StaticFactory { get; set; }

    internal InnerPolicyTemplateLinkedPolicyDefinitionFactory TemplateLinkedFactory { get; set; }

    protected override Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition Create()
    {
        var policyDefinitionResult = CreatePolicyDefinition();
        factoryAction?.Invoke(policyDefinitionResult);

        return policyDefinitionResult;
    }

    private Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition CreatePolicyDefinition()
    {
        var policyDefinitionResult = new Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition();

        return policyDefinitionResult;
    }
    public override void CreateChildren(Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition result)
    {
        base.CreateChildren(result);

        result.Static ??= StaticFactory?.Build();
        result.TemplateLinked ??= TemplateLinkedFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyPolicyDefinitionFactoryExtensions
{
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, InnerPolicyStaticPolicyDefinitionFactory> WithStatic(this InnerPolicyPolicyDefinitionFactory parentFactory, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null)
    {
        parentFactory.StaticFactory = new InnerPolicyStaticPolicyDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StaticFactory);
    }

    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked(this InnerPolicyPolicyDefinitionFactory parentFactory, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null)
    {
        parentFactory.TemplateLinkedFactory = new InnerPolicyTemplateLinkedPolicyDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TemplateLinkedFactory);
    }

    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatic(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatic(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, T4, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3, T4>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, T4, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, T4, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, T4, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory, InnerPolicyStaticPolicyDefinitionFactory> WithStatic<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatic(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateLinked(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateLinked(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, T4, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3, T4>(this CombinedResult<InnerPolicyPolicyDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, T4, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyPolicyDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, T4, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyPolicyDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, T4, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyDefinitionFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory, InnerPolicyTemplateLinkedPolicyDefinitionFactory> WithTemplateLinked<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateLinked(combinedResult.T5, subFactoryAction));
}
