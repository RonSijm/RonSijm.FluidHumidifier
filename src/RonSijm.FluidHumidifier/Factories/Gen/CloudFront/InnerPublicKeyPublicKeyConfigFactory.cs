// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerPublicKeyPublicKeyConfigFactory(Action<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig>
{

    protected override Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig Create()
    {
        var publicKeyConfigResult = CreatePublicKeyConfig();
        factoryAction?.Invoke(publicKeyConfigResult);

        return publicKeyConfigResult;
    }

    private Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig CreatePublicKeyConfig()
    {
        var publicKeyConfigResult = new Humidifier.CloudFront.PublicKeyTypes.PublicKeyConfig();

        return publicKeyConfigResult;
    }

} // End Of Class

public static class InnerPublicKeyPublicKeyConfigFactoryExtensions
{
}
