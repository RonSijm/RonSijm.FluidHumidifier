// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeEndpointCertificateAuthorityFactory(Action<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority>
{

    internal InnerAcmeEndpointPublicCertificateAuthorityFactory PublicCertificateAuthorityFactory { get; set; }

    protected override Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority Create()
    {
        var certificateAuthorityResult = CreateCertificateAuthority();
        factoryAction?.Invoke(certificateAuthorityResult);

        return certificateAuthorityResult;
    }

    private Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority CreateCertificateAuthority()
    {
        var certificateAuthorityResult = new Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority();

        return certificateAuthorityResult;
    }
    public override void CreateChildren(Humidifier.CertificateManager.AcmeEndpointTypes.CertificateAuthority result)
    {
        base.CreateChildren(result);

        result.PublicCertificateAuthority ??= PublicCertificateAuthorityFactory?.Build();
    }

} // End Of Class

public static class InnerAcmeEndpointCertificateAuthorityFactoryExtensions
{
    public static CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority(this InnerAcmeEndpointCertificateAuthorityFactory parentFactory, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null)
    {
        parentFactory.PublicCertificateAuthorityFactory = new InnerAcmeEndpointPublicCertificateAuthorityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PublicCertificateAuthorityFactory);
    }

    public static CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, T1, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1>(this CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeEndpointCertificateAuthorityFactory, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1>(this CombinedResult<T1, InnerAcmeEndpointCertificateAuthorityFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, T1, T2, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2>(this CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeEndpointCertificateAuthorityFactory, T2, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2>(this CombinedResult<T1, InnerAcmeEndpointCertificateAuthorityFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeEndpointCertificateAuthorityFactory, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2>(this CombinedResult<T1, T2, InnerAcmeEndpointCertificateAuthorityFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, T1, T2, T3, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3>(this CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeEndpointCertificateAuthorityFactory, T2, T3, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3>(this CombinedResult<T1, InnerAcmeEndpointCertificateAuthorityFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeEndpointCertificateAuthorityFactory, T3, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3>(this CombinedResult<T1, T2, InnerAcmeEndpointCertificateAuthorityFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAcmeEndpointCertificateAuthorityFactory, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAcmeEndpointCertificateAuthorityFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, T1, T2, T3, T4, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<InnerAcmeEndpointCertificateAuthorityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeEndpointCertificateAuthorityFactory, T2, T3, T4, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<T1, InnerAcmeEndpointCertificateAuthorityFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeEndpointCertificateAuthorityFactory, T3, T4, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAcmeEndpointCertificateAuthorityFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAcmeEndpointCertificateAuthorityFactory, T4, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAcmeEndpointCertificateAuthorityFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAcmeEndpointCertificateAuthorityFactory, InnerAcmeEndpointPublicCertificateAuthorityFactory> WithPublicCertificateAuthority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAcmeEndpointCertificateAuthorityFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicCertificateAuthority(combinedResult.T5, subFactoryAction).T2);
}
