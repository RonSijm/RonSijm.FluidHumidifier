// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerDirectoryConfigCertificateBasedAuthPropertiesFactory(Action<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties>
{

    protected override Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties Create()
    {
        var certificateBasedAuthPropertiesResult = CreateCertificateBasedAuthProperties();
        factoryAction?.Invoke(certificateBasedAuthPropertiesResult);

        return certificateBasedAuthPropertiesResult;
    }

    private Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties CreateCertificateBasedAuthProperties()
    {
        var certificateBasedAuthPropertiesResult = new Humidifier.AppStream.DirectoryConfigTypes.CertificateBasedAuthProperties();

        return certificateBasedAuthPropertiesResult;
    }

} // End Of Class

public static class InnerDirectoryConfigCertificateBasedAuthPropertiesFactoryExtensions
{
}
