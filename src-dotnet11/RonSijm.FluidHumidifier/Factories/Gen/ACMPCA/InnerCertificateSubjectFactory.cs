// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateSubjectFactory(Action<Humidifier.ACMPCA.CertificateTypes.Subject> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateTypes.Subject>
{

    protected override Humidifier.ACMPCA.CertificateTypes.Subject Create()
    {
        var subjectResult = CreateSubject();
        factoryAction?.Invoke(subjectResult);

        return subjectResult;
    }

    private Humidifier.ACMPCA.CertificateTypes.Subject CreateSubject()
    {
        var subjectResult = new Humidifier.ACMPCA.CertificateTypes.Subject();

        return subjectResult;
    }

} // End Of Class

public static class InnerCertificateSubjectFactoryExtensions
{
}
