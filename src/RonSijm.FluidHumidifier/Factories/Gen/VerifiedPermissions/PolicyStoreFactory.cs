// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class PolicyStoreFactory(string resourceName = null, Action<Humidifier.VerifiedPermissions.PolicyStore> factoryAction = null) : ResourceFactory<Humidifier.VerifiedPermissions.PolicyStore>(resourceName)
{

    internal InnerPolicyStoreValidationSettingsFactory ValidationSettingsFactory { get; set; }

    internal InnerPolicyStoreSchemaDefinitionFactory SchemaFactory { get; set; }

    protected override Humidifier.VerifiedPermissions.PolicyStore Create()
    {
        var policyStoreResult = CreatePolicyStore();
        factoryAction?.Invoke(policyStoreResult);

        return policyStoreResult;
    }

    private Humidifier.VerifiedPermissions.PolicyStore CreatePolicyStore()
    {
        var policyStoreResult = new Humidifier.VerifiedPermissions.PolicyStore
        {
            GivenName = InputResourceName,
        };

        return policyStoreResult;
    }
    public override void CreateChildren(Humidifier.VerifiedPermissions.PolicyStore result)
    {
        base.CreateChildren(result);

        result.ValidationSettings ??= ValidationSettingsFactory?.Build();
        result.Schema ??= SchemaFactory?.Build();
    }

} // End Of Class

public static class PolicyStoreFactoryExtensions
{
    public static CombinedResult<PolicyStoreFactory, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings(this PolicyStoreFactory parentFactory, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null)
    {
        parentFactory.ValidationSettingsFactory = new InnerPolicyStoreValidationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidationSettingsFactory);
    }

    public static CombinedResult<PolicyStoreFactory, InnerPolicyStoreSchemaDefinitionFactory> WithSchema(this PolicyStoreFactory parentFactory, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null)
    {
        parentFactory.SchemaFactory = new InnerPolicyStoreSchemaDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaFactory);
    }

    public static CombinedResult<PolicyStoreFactory, T1, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1>(this CombinedResult<PolicyStoreFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyStoreFactory, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1>(this CombinedResult<T1, PolicyStoreFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PolicyStoreFactory, T1, T2, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2>(this CombinedResult<PolicyStoreFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyStoreFactory, T2, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2>(this CombinedResult<T1, PolicyStoreFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyStoreFactory, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2>(this CombinedResult<T1, T2, PolicyStoreFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PolicyStoreFactory, T1, T2, T3, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3>(this CombinedResult<PolicyStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyStoreFactory, T2, T3, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3>(this CombinedResult<T1, PolicyStoreFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyStoreFactory, T3, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3>(this CombinedResult<T1, T2, PolicyStoreFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyStoreFactory, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyStoreFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PolicyStoreFactory, T1, T2, T3, T4, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3, T4>(this CombinedResult<PolicyStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyStoreFactory, T2, T3, T4, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3, T4>(this CombinedResult<T1, PolicyStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyStoreFactory, T3, T4, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyStoreFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyStoreFactory, T4, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyStoreFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PolicyStoreFactory, InnerPolicyStoreValidationSettingsFactory> WithValidationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyStoreFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.ValidationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidationSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PolicyStoreFactory, T1, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1>(this CombinedResult<PolicyStoreFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyStoreFactory, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1>(this CombinedResult<T1, PolicyStoreFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PolicyStoreFactory, T1, T2, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2>(this CombinedResult<PolicyStoreFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyStoreFactory, T2, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2>(this CombinedResult<T1, PolicyStoreFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyStoreFactory, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2>(this CombinedResult<T1, T2, PolicyStoreFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PolicyStoreFactory, T1, T2, T3, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3>(this CombinedResult<PolicyStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyStoreFactory, T2, T3, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, PolicyStoreFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyStoreFactory, T3, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, PolicyStoreFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyStoreFactory, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyStoreFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PolicyStoreFactory, T1, T2, T3, T4, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<PolicyStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyStoreFactory, T2, T3, T4, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, PolicyStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyStoreFactory, T3, T4, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyStoreFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyStoreFactory, T4, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyStoreFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PolicyStoreFactory, InnerPolicyStoreSchemaDefinitionFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyStoreFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.SchemaDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T5, subFactoryAction));
}
