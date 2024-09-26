// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class IntegrationFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.Integration> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.Integration>(resourceName)
{

    internal List<InnerIntegrationObjectTypeMappingFactory> ObjectTypeNamesFactories { get; set; } = [];

    internal InnerIntegrationFlowDefinitionFactory FlowDefinitionFactory { get; set; }

    protected override Humidifier.CustomerProfiles.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.CustomerProfiles.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.CustomerProfiles.Integration
        {
            GivenName = InputResourceName,
        };

        return integrationResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.Integration result)
    {
        base.CreateChildren(result);

        result.ObjectTypeNames = ObjectTypeNamesFactories.Any() ? ObjectTypeNamesFactories.Select(x => x.Build()).ToList() : null;
        result.FlowDefinition ??= FlowDefinitionFactory?.Build();
    }

} // End Of Class

public static class IntegrationFactoryExtensions
{
    public static CombinedResult<IntegrationFactory, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames(this IntegrationFactory parentFactory, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null)
    {
        var factory = new InnerIntegrationObjectTypeMappingFactory(subFactoryAction);
        parentFactory.ObjectTypeNamesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IntegrationFactory, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition(this IntegrationFactory parentFactory, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null)
    {
        parentFactory.FlowDefinitionFactory = new InnerIntegrationFlowDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FlowDefinitionFactory);
    }

    public static CombinedResult<IntegrationFactory, T1, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1>(this CombinedResult<IntegrationFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1>(this CombinedResult<T1, IntegrationFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2>(this CombinedResult<IntegrationFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2>(this CombinedResult<T1, IntegrationFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2>(this CombinedResult<T1, T2, IntegrationFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, T3, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3>(this CombinedResult<IntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, T3, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3>(this CombinedResult<T1, IntegrationFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, T3, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3>(this CombinedResult<T1, T2, IntegrationFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IntegrationFactory, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntegrationFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, T3, T4, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3, T4>(this CombinedResult<IntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, T3, T4, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3, T4>(this CombinedResult<T1, IntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, T3, T4, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntegrationFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IntegrationFactory, T4, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntegrationFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IntegrationFactory, InnerIntegrationObjectTypeMappingFactory> WithObjectTypeNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntegrationFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectTypeNames(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1>(this CombinedResult<IntegrationFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1>(this CombinedResult<T1, IntegrationFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2>(this CombinedResult<IntegrationFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2>(this CombinedResult<T1, IntegrationFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2>(this CombinedResult<T1, T2, IntegrationFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, T3, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3>(this CombinedResult<IntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, T3, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3>(this CombinedResult<T1, IntegrationFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, T3, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3>(this CombinedResult<T1, T2, IntegrationFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IntegrationFactory, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntegrationFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IntegrationFactory, T1, T2, T3, T4, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3, T4>(this CombinedResult<IntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IntegrationFactory, T2, T3, T4, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3, T4>(this CombinedResult<T1, IntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IntegrationFactory, T3, T4, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntegrationFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IntegrationFactory, T4, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntegrationFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IntegrationFactory, InnerIntegrationFlowDefinitionFactory> WithFlowDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntegrationFactory> combinedResult, Action<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowDefinition(combinedResult.T5, subFactoryAction));
}
