// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointScteDashFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.ScteDash> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.ScteDash>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.ScteDash Create()
    {
        var scteDashResult = CreateScteDash();
        factoryAction?.Invoke(scteDashResult);

        return scteDashResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.ScteDash CreateScteDash()
    {
        var scteDashResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.ScteDash();

        return scteDashResult;
    }

} // End Of Class

public static class InnerOriginEndpointScteDashFactoryExtensions
{
}
