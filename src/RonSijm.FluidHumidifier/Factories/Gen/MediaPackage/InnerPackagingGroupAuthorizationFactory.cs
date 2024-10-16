// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerPackagingGroupAuthorizationFactory(Action<Humidifier.MediaPackage.PackagingGroupTypes.Authorization> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.PackagingGroupTypes.Authorization>
{

    protected override Humidifier.MediaPackage.PackagingGroupTypes.Authorization Create()
    {
        var authorizationResult = CreateAuthorization();
        factoryAction?.Invoke(authorizationResult);

        return authorizationResult;
    }

    private Humidifier.MediaPackage.PackagingGroupTypes.Authorization CreateAuthorization()
    {
        var authorizationResult = new Humidifier.MediaPackage.PackagingGroupTypes.Authorization();

        return authorizationResult;
    }

} // End Of Class

public static class InnerPackagingGroupAuthorizationFactoryExtensions
{
}
