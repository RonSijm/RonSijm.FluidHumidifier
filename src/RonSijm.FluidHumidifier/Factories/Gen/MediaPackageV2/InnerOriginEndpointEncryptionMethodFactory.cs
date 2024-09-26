// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointEncryptionMethodFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod Create()
    {
        var encryptionMethodResult = CreateEncryptionMethod();
        factoryAction?.Invoke(encryptionMethodResult);

        return encryptionMethodResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod CreateEncryptionMethod()
    {
        var encryptionMethodResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.EncryptionMethod();

        return encryptionMethodResult;
    }

} // End Of Class

public static class InnerOriginEndpointEncryptionMethodFactoryExtensions
{
}
