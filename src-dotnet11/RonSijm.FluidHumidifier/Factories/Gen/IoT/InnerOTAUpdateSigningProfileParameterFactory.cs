// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateSigningProfileParameterFactory(Action<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter>
{

    protected override Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter Create()
    {
        var signingProfileParameterResult = CreateSigningProfileParameter();
        factoryAction?.Invoke(signingProfileParameterResult);

        return signingProfileParameterResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter CreateSigningProfileParameter()
    {
        var signingProfileParameterResult = new Humidifier.IoT.OTAUpdateTypes.SigningProfileParameter();

        return signingProfileParameterResult;
    }

} // End Of Class

public static class InnerOTAUpdateSigningProfileParameterFactoryExtensions
{
}
