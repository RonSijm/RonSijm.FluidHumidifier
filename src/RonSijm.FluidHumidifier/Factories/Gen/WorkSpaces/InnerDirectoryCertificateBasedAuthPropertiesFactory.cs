// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectoryCertificateBasedAuthPropertiesFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.CertificateBasedAuthProperties> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.CertificateBasedAuthProperties>
{

    protected override Humidifier.WorkSpaces.DirectoryTypes.CertificateBasedAuthProperties Create()
    {
        var certificateBasedAuthPropertiesResult = CreateCertificateBasedAuthProperties();
        factoryAction?.Invoke(certificateBasedAuthPropertiesResult);

        return certificateBasedAuthPropertiesResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.CertificateBasedAuthProperties CreateCertificateBasedAuthProperties()
    {
        var certificateBasedAuthPropertiesResult = new Humidifier.WorkSpaces.DirectoryTypes.CertificateBasedAuthProperties();

        return certificateBasedAuthPropertiesResult;
    }

} // End Of Class

public static class InnerDirectoryCertificateBasedAuthPropertiesFactoryExtensions
{
}
