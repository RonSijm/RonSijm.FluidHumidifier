// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyTemplateLinkedPolicyDefinitionFactory(Action<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition>
{

    internal InnerPolicyEntityIdentifierFactory ResourceFactory { get; set; }

    internal InnerPolicyEntityIdentifierFactory PrincipalFactory { get; set; }

    protected override Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition Create()
    {
        var templateLinkedPolicyDefinitionResult = CreateTemplateLinkedPolicyDefinition();
        factoryAction?.Invoke(templateLinkedPolicyDefinitionResult);

        return templateLinkedPolicyDefinitionResult;
    }

    private Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition CreateTemplateLinkedPolicyDefinition()
    {
        var templateLinkedPolicyDefinitionResult = new Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition();

        return templateLinkedPolicyDefinitionResult;
    }
    public override void CreateChildren(Humidifier.VerifiedPermissions.PolicyTypes.TemplateLinkedPolicyDefinition result)
    {
        base.CreateChildren(result);

        result.Resource ??= ResourceFactory?.Build();
        result.Principal ??= PrincipalFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyTemplateLinkedPolicyDefinitionFactoryExtensions
{
    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithResource(this InnerPolicyTemplateLinkedPolicyDefinitionFactory parentFactory, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null)
    {
        parentFactory.ResourceFactory = new InnerPolicyEntityIdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceFactory);
    }

    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithPrincipal(this InnerPolicyTemplateLinkedPolicyDefinitionFactory parentFactory, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null)
    {
        parentFactory.PrincipalFactory = new InnerPolicyEntityIdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrincipalFactory);
    }

    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, InnerPolicyEntityIdentifierFactory> WithResource<T1>(this CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithResource<T1>(this CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2>(this CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2>(this CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2>(this CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, T3, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3>(this CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, T3, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T3, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, T3, T4, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, T3, T4, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T3, T4, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T4, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyTemplateLinkedPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1>(this CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1>(this CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2>(this CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, T3, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, T3, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T3, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, T3, T4, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<InnerPolicyTemplateLinkedPolicyDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, T3, T4, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T3, T4, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T4, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyTemplateLinkedPolicyDefinitionFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyTemplateLinkedPolicyDefinitionFactory, InnerPolicyEntityIdentifierFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyTemplateLinkedPolicyDefinitionFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T5, subFactoryAction));
}
