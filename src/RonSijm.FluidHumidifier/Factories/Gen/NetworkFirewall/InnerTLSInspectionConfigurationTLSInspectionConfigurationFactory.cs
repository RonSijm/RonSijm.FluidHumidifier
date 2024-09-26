// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory(Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration>
{

    internal List<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> ServerCertificateConfigurationsFactories { get; set; } = [];

    protected override Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration Create()
    {
        var tLSInspectionConfigurationResult = CreateTLSInspectionConfiguration();
        factoryAction?.Invoke(tLSInspectionConfigurationResult);

        return tLSInspectionConfigurationResult;
    }

    private Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration CreateTLSInspectionConfiguration()
    {
        var tLSInspectionConfigurationResult = new Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration();

        return tLSInspectionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.TLSInspectionConfiguration result)
    {
        base.CreateChildren(result);

        result.ServerCertificateConfigurations = ServerCertificateConfigurationsFactories.Any() ? ServerCertificateConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerTLSInspectionConfigurationTLSInspectionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations(this InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory parentFactory, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null)
    {
        var factory = new InnerTLSInspectionConfigurationServerCertificateConfigurationFactory(subFactoryAction);
        parentFactory.ServerCertificateConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1>(this CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1>(this CombinedResult<T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T1, T2, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2>(this CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T2, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2>(this CombinedResult<T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2>(this CombinedResult<T1, T2, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T1, T2, T3, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3>(this CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T2, T3, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3>(this CombinedResult<T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T3, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T1, T2, T3, T4, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3, T4>(this CombinedResult<InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T2, T3, T4, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T3, T4, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T4, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> WithServerCertificateConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTLSInspectionConfigurationTLSInspectionConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCertificateConfigurations(combinedResult.T5, subFactoryAction));
}
