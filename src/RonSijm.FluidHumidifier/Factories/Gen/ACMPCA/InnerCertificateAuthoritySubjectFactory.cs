// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateAuthoritySubjectFactory(Action<Humidifier.ACMPCA.CertificateAuthorityTypes.Subject> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateAuthorityTypes.Subject>
{

    protected override Humidifier.ACMPCA.CertificateAuthorityTypes.Subject Create()
    {
        var subjectResult = CreateSubject();
        factoryAction?.Invoke(subjectResult);

        return subjectResult;
    }

    private Humidifier.ACMPCA.CertificateAuthorityTypes.Subject CreateSubject()
    {
        var subjectResult = new Humidifier.ACMPCA.CertificateAuthorityTypes.Subject();

        return subjectResult;
    }

} // End Of Class

public static class InnerCertificateAuthoritySubjectFactoryExtensions
{
}
