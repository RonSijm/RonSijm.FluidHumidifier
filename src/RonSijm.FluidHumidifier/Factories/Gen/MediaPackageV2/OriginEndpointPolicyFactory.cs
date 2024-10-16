// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class OriginEndpointPolicyFactory(string resourceName = null, Action<Humidifier.MediaPackageV2.OriginEndpointPolicy> factoryAction = null) : ResourceFactory<Humidifier.MediaPackageV2.OriginEndpointPolicy>(resourceName)
{

    protected override Humidifier.MediaPackageV2.OriginEndpointPolicy Create()
    {
        var originEndpointPolicyResult = CreateOriginEndpointPolicy();
        factoryAction?.Invoke(originEndpointPolicyResult);

        return originEndpointPolicyResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointPolicy CreateOriginEndpointPolicy()
    {
        var originEndpointPolicyResult = new Humidifier.MediaPackageV2.OriginEndpointPolicy
        {
            GivenName = InputResourceName,
        };

        return originEndpointPolicyResult;
    }

} // End Of Class

public static class OriginEndpointPolicyFactoryExtensions
{
}
