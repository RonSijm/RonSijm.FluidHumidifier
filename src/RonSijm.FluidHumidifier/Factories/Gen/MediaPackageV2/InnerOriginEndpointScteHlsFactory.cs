// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointScteHlsFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls Create()
    {
        var scteHlsResult = CreateScteHls();
        factoryAction?.Invoke(scteHlsResult);

        return scteHlsResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls CreateScteHls()
    {
        var scteHlsResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.ScteHls();

        return scteHlsResult;
    }

} // End Of Class

public static class InnerOriginEndpointScteHlsFactoryExtensions
{
}
