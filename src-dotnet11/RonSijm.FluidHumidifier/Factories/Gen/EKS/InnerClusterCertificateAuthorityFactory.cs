// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterCertificateAuthorityFactory(Action<Humidifier.EKS.ClusterTypes.CertificateAuthority> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.CertificateAuthority>
{

    internal InnerClusterActiveCertificateAuthorityFactory ActiveFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.CertificateAuthority Create()
    {
        var certificateAuthorityResult = CreateCertificateAuthority();
        factoryAction?.Invoke(certificateAuthorityResult);

        return certificateAuthorityResult;
    }

    private Humidifier.EKS.ClusterTypes.CertificateAuthority CreateCertificateAuthority()
    {
        var certificateAuthorityResult = new Humidifier.EKS.ClusterTypes.CertificateAuthority();

        return certificateAuthorityResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.CertificateAuthority result)
    {
        base.CreateChildren(result);

        result.Active ??= ActiveFactory?.Build();
    }

} // End Of Class

public static class InnerClusterCertificateAuthorityFactoryExtensions
{
    public static CombinedResult<InnerClusterCertificateAuthorityFactory, InnerClusterActiveCertificateAuthorityFactory> WithActive(this InnerClusterCertificateAuthorityFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null)
    {
        parentFactory.ActiveFactory = new InnerClusterActiveCertificateAuthorityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActiveFactory);
    }

    public static CombinedResult<InnerClusterCertificateAuthorityFactory, T1, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1>(this CombinedResult<InnerClusterCertificateAuthorityFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, WithActive(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterCertificateAuthorityFactory, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1>(this CombinedResult<T1, InnerClusterCertificateAuthorityFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, WithActive(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterCertificateAuthorityFactory, T1, T2, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2>(this CombinedResult<InnerClusterCertificateAuthorityFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterCertificateAuthorityFactory, T2, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2>(this CombinedResult<T1, InnerClusterCertificateAuthorityFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterCertificateAuthorityFactory, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2>(this CombinedResult<T1, T2, InnerClusterCertificateAuthorityFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterCertificateAuthorityFactory, T1, T2, T3, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3>(this CombinedResult<InnerClusterCertificateAuthorityFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterCertificateAuthorityFactory, T2, T3, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3>(this CombinedResult<T1, InnerClusterCertificateAuthorityFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterCertificateAuthorityFactory, T3, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterCertificateAuthorityFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterCertificateAuthorityFactory, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterCertificateAuthorityFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterCertificateAuthorityFactory, T1, T2, T3, T4, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3, T4>(this CombinedResult<InnerClusterCertificateAuthorityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterCertificateAuthorityFactory, T2, T3, T4, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterCertificateAuthorityFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterCertificateAuthorityFactory, T3, T4, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterCertificateAuthorityFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterCertificateAuthorityFactory, T4, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterCertificateAuthorityFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterCertificateAuthorityFactory, InnerClusterActiveCertificateAuthorityFactory> WithActive<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterCertificateAuthorityFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActive(combinedResult.T5, subFactoryAction).T2);
}
