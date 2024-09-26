// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerTLSInspectionConfigurationServerCertificateConfigurationFactory(Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration>
{

    internal InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory CheckCertificateRevocationStatusFactory { get; set; }

    protected override Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration Create()
    {
        var serverCertificateConfigurationResult = CreateServerCertificateConfiguration();
        factoryAction?.Invoke(serverCertificateConfigurationResult);

        return serverCertificateConfigurationResult;
    }

    private Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration CreateServerCertificateConfiguration()
    {
        var serverCertificateConfigurationResult = new Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration();

        return serverCertificateConfigurationResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.ServerCertificateConfiguration result)
    {
        base.CreateChildren(result);

        result.CheckCertificateRevocationStatus ??= CheckCertificateRevocationStatusFactory?.Build();
    }

} // End Of Class

public static class InnerTLSInspectionConfigurationServerCertificateConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus(this InnerTLSInspectionConfigurationServerCertificateConfigurationFactory parentFactory, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null)
    {
        parentFactory.CheckCertificateRevocationStatusFactory = new InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CheckCertificateRevocationStatusFactory);
    }

    public static CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T1, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1>(this CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1>(this CombinedResult<T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T1, T2, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2>(this CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T2, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2>(this CombinedResult<T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2>(this CombinedResult<T1, T2, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T1, T2, T3, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3>(this CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T2, T3, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3>(this CombinedResult<T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T3, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3>(this CombinedResult<T1, T2, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T1, T2, T3, T4, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3, T4>(this CombinedResult<InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T2, T3, T4, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3, T4>(this CombinedResult<T1, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T3, T4, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T4, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory, InnerTLSInspectionConfigurationCheckCertificateRevocationStatusFactory> WithCheckCertificateRevocationStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTLSInspectionConfigurationServerCertificateConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.TLSInspectionConfigurationTypes.CheckCertificateRevocationStatus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCheckCertificateRevocationStatus(combinedResult.T5, subFactoryAction));
}
