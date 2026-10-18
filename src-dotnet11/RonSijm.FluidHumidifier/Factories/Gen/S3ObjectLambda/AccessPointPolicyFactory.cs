// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3ObjectLambda;

public class AccessPointPolicyFactory(string resourceName = null, Action<Humidifier.S3ObjectLambda.AccessPointPolicy> factoryAction = null) : ResourceFactory<Humidifier.S3ObjectLambda.AccessPointPolicy>(resourceName)
{

    protected override Humidifier.S3ObjectLambda.AccessPointPolicy Create()
    {
        var accessPointPolicyResult = CreateAccessPointPolicy();
        factoryAction?.Invoke(accessPointPolicyResult);

        return accessPointPolicyResult;
    }

    private Humidifier.S3ObjectLambda.AccessPointPolicy CreateAccessPointPolicy()
    {
        var accessPointPolicyResult = new Humidifier.S3ObjectLambda.AccessPointPolicy
        {
            GivenName = InputResourceName,
        };

        return accessPointPolicyResult;
    }

} // End Of Class

public static class AccessPointPolicyFactoryExtensions
{
}
