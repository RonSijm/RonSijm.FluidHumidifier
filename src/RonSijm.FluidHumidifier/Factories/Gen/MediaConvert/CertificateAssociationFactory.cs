// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class CertificateAssociationFactory(string resourceName = null, Action<Humidifier.MediaConvert.CertificateAssociation> factoryAction = null) : ResourceFactory<Humidifier.MediaConvert.CertificateAssociation>(resourceName)
{

    protected override Humidifier.MediaConvert.CertificateAssociation Create()
    {
        var certificateAssociationResult = CreateCertificateAssociation();
        factoryAction?.Invoke(certificateAssociationResult);

        return certificateAssociationResult;
    }

    private Humidifier.MediaConvert.CertificateAssociation CreateCertificateAssociation()
    {
        var certificateAssociationResult = new Humidifier.MediaConvert.CertificateAssociation
        {
            GivenName = InputResourceName,
        };

        return certificateAssociationResult;
    }

} // End Of Class

public static class CertificateAssociationFactoryExtensions
{
}
