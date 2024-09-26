// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateValidityFactory(Action<Humidifier.ACMPCA.CertificateTypes.Validity> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateTypes.Validity>
{

    protected override Humidifier.ACMPCA.CertificateTypes.Validity Create()
    {
        var validityResult = CreateValidity();
        factoryAction?.Invoke(validityResult);

        return validityResult;
    }

    private Humidifier.ACMPCA.CertificateTypes.Validity CreateValidity()
    {
        var validityResult = new Humidifier.ACMPCA.CertificateTypes.Validity();

        return validityResult;
    }

} // End Of Class

public static class InnerCertificateValidityFactoryExtensions
{
}
