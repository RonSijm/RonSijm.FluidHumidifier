// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class AssociationFactory(string resourceName = null, Action<Humidifier.DevOpsAgent.Association> factoryAction = null) : ResourceFactory<Humidifier.DevOpsAgent.Association>(resourceName)
{

    internal InnerAssociationServiceConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.DevOpsAgent.Association Create()
    {
        var associationResult = CreateAssociation();
        factoryAction?.Invoke(associationResult);

        return associationResult;
    }

    private Humidifier.DevOpsAgent.Association CreateAssociation()
    {
        var associationResult = new Humidifier.DevOpsAgent.Association
        {
            GivenName = InputResourceName,
        };

        return associationResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.Association result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class AssociationFactoryExtensions
{
    public static CombinedResult<AssociationFactory, InnerAssociationServiceConfigurationFactory> WithConfiguration(this AssociationFactory parentFactory, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerAssociationServiceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<AssociationFactory, T1, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1>(this CombinedResult<AssociationFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssociationFactory, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, AssociationFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AssociationFactory, T1, T2, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<AssociationFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssociationFactory, T2, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, AssociationFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssociationFactory, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, AssociationFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AssociationFactory, T1, T2, T3, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<AssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssociationFactory, T2, T3, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, AssociationFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssociationFactory, T3, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AssociationFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AssociationFactory, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssociationFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AssociationFactory, T1, T2, T3, T4, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<AssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssociationFactory, T2, T3, T4, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssociationFactory, T3, T4, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssociationFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AssociationFactory, T4, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssociationFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AssociationFactory, InnerAssociationServiceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssociationFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
