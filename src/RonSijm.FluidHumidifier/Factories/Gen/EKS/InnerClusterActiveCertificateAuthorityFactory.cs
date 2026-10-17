// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterActiveCertificateAuthorityFactory(Action<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority>
{

    protected override Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority Create()
    {
        var activeCertificateAuthorityResult = CreateActiveCertificateAuthority();
        factoryAction?.Invoke(activeCertificateAuthorityResult);

        return activeCertificateAuthorityResult;
    }

    private Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority CreateActiveCertificateAuthority()
    {
        var activeCertificateAuthorityResult = new Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority();

        return activeCertificateAuthorityResult;
    }

} // End Of Class

public static class InnerClusterActiveCertificateAuthorityFactoryExtensions
{
}
