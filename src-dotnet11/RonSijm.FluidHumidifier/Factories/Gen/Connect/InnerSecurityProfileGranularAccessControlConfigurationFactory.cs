// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerSecurityProfileGranularAccessControlConfigurationFactory(Action<Humidifier.Connect.SecurityProfileTypes.GranularAccessControlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.SecurityProfileTypes.GranularAccessControlConfiguration>
{

    internal InnerSecurityProfileDataTableAccessControlConfigurationFactory DataTableAccessControlConfigurationFactory { get; set; }

    protected override Humidifier.Connect.SecurityProfileTypes.GranularAccessControlConfiguration Create()
    {
        var granularAccessControlConfigurationResult = CreateGranularAccessControlConfiguration();
        factoryAction?.Invoke(granularAccessControlConfigurationResult);

        return granularAccessControlConfigurationResult;
    }

    private Humidifier.Connect.SecurityProfileTypes.GranularAccessControlConfiguration CreateGranularAccessControlConfiguration()
    {
        var granularAccessControlConfigurationResult = new Humidifier.Connect.SecurityProfileTypes.GranularAccessControlConfiguration();

        return granularAccessControlConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Connect.SecurityProfileTypes.GranularAccessControlConfiguration result)
    {
        base.CreateChildren(result);

        result.DataTableAccessControlConfiguration ??= DataTableAccessControlConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityProfileGranularAccessControlConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration(this InnerSecurityProfileGranularAccessControlConfigurationFactory parentFactory, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null)
    {
        parentFactory.DataTableAccessControlConfigurationFactory = new InnerSecurityProfileDataTableAccessControlConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataTableAccessControlConfigurationFactory);
    }

    public static CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, T1, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1>(this CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, T1> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityProfileGranularAccessControlConfigurationFactory, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1>(this CombinedResult<T1, InnerSecurityProfileGranularAccessControlConfigurationFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, T1, T2, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2>(this CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityProfileGranularAccessControlConfigurationFactory, T2, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2>(this CombinedResult<T1, InnerSecurityProfileGranularAccessControlConfigurationFactory, T2> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityProfileGranularAccessControlConfigurationFactory, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerSecurityProfileGranularAccessControlConfigurationFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, T1, T2, T3, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3>(this CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityProfileGranularAccessControlConfigurationFactory, T2, T3, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerSecurityProfileGranularAccessControlConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityProfileGranularAccessControlConfigurationFactory, T3, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityProfileGranularAccessControlConfigurationFactory, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileGranularAccessControlConfigurationFactory, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityProfileGranularAccessControlConfigurationFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, T1, T2, T3, T4, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerSecurityProfileGranularAccessControlConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityProfileGranularAccessControlConfigurationFactory, T2, T3, T4, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityProfileGranularAccessControlConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityProfileGranularAccessControlConfigurationFactory, T3, T4, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityProfileGranularAccessControlConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileGranularAccessControlConfigurationFactory, T4, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityProfileGranularAccessControlConfigurationFactory, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityProfileGranularAccessControlConfigurationFactory, InnerSecurityProfileDataTableAccessControlConfigurationFactory> WithDataTableAccessControlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityProfileGranularAccessControlConfigurationFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.DataTableAccessControlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataTableAccessControlConfiguration(combinedResult.T5, subFactoryAction).T2);
}
