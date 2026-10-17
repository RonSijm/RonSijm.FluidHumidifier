// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory(Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration>
{

    internal InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory PoliciesFactory { get; set; }

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration Create()
    {
        var privacyConfigurationResult = CreatePrivacyConfiguration();
        factoryAction?.Invoke(privacyConfigurationResult);

        return privacyConfigurationResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration CreatePrivacyConfiguration()
    {
        var privacyConfigurationResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration();

        return privacyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfiguration result)
    {
        base.CreateChildren(result);

        result.Policies ??= PoliciesFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies(this InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory parentFactory, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null)
    {
        parentFactory.PoliciesFactory = new InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PoliciesFactory);
    }

    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1>(this CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T1> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1>(this CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T1, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2>(this CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2>(this CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T2> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T1, T2, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3>(this CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T2, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T3> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T1, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T3, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, T4> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationPoliciesFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredModelAlgorithmAssociationPrivacyConfigurationFactory> combinedResult, Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.PrivacyConfigurationPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T5, subFactoryAction).T2);
}
