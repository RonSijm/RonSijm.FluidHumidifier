// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerSecurityProfileDataTableAccessControlConfigurationFactory(Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration>
{

    internal InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory PrimaryAttributeAccessControlConfigurationFactory { get; set; }

    protected override Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration Create()
    {
        var dataTableAccessControlConfigurationResult = CreateDataTableAccessControlConfiguration();
        factoryAction?.Invoke(dataTableAccessControlConfigurationResult);

        return dataTableAccessControlConfigurationResult;
    }

    private Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration CreateDataTableAccessControlConfiguration()
    {
        var dataTableAccessControlConfigurationResult = new Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration();

        return dataTableAccessControlConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration result)
    {
        base.CreateChildren(result);

        result.PrimaryAttributeAccessControlConfiguration ??= PrimaryAttributeAccessControlConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityProfileDataTableAccessControlConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration(this InnerSecurityProfileDataTableAccessControlConfigurationFactory parentFactory, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null)
    {
        parentFactory.PrimaryAttributeAccessControlConfigurationFactory = new InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrimaryAttributeAccessControlConfigurationFactory);
    }

    public static CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, T1, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1>(this CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, T1> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1>(this CombinedResult<T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, T1, T2, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2>(this CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T2, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2>(this CombinedResult<T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T2> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityProfileDataTableAccessControlConfigurationFactory, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerSecurityProfileDataTableAccessControlConfigurationFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, T1, T2, T3, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3>(this CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T2, T3, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T3, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileDataTableAccessControlConfigurationFactory, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityProfileDataTableAccessControlConfigurationFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, T1, T2, T3, T4, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerSecurityProfileDataTableAccessControlConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T2, T3, T4, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T3, T4, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T4, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityProfileDataTableAccessControlConfigurationFactory, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityProfileDataTableAccessControlConfigurationFactory, InnerSecurityProfilePrimaryAttributeAccessControlConfigurationItemFactory> WithPrimaryAttributeAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityProfileDataTableAccessControlConfigurationFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.PrimaryAttributeAccessControlConfigurationItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryAttributeAccessControlConfiguration(combinedResult.T5, subFactoryAction).T2);
}
