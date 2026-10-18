// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointStartTagFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag Create()
    {
        var startTagResult = CreateStartTag();
        factoryAction?.Invoke(startTagResult);

        return startTagResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag CreateStartTag()
    {
        var startTagResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.StartTag();

        return startTagResult;
    }

} // End Of Class

public static class InnerOriginEndpointStartTagFactoryExtensions
{
}
