// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointScteFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.Scte Create()
    {
        var scteResult = CreateScte();
        factoryAction?.Invoke(scteResult);

        return scteResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.Scte CreateScte()
    {
        var scteResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.Scte();

        return scteResult;
    }

} // End Of Class

public static class InnerOriginEndpointScteFactoryExtensions
{
}
