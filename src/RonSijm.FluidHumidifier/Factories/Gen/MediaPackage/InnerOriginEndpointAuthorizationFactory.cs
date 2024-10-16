// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointAuthorizationFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.Authorization> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.Authorization>
{

    protected override Humidifier.MediaPackage.OriginEndpointTypes.Authorization Create()
    {
        var authorizationResult = CreateAuthorization();
        factoryAction?.Invoke(authorizationResult);

        return authorizationResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.Authorization CreateAuthorization()
    {
        var authorizationResult = new Humidifier.MediaPackage.OriginEndpointTypes.Authorization();

        return authorizationResult;
    }

} // End Of Class

public static class InnerOriginEndpointAuthorizationFactoryExtensions
{
}
