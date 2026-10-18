// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class MultiRegionAccessPointPolicyFactory(string resourceName = null, Action<Humidifier.S3.MultiRegionAccessPointPolicy> factoryAction = null) : ResourceFactory<Humidifier.S3.MultiRegionAccessPointPolicy>(resourceName)
{

    protected override Humidifier.S3.MultiRegionAccessPointPolicy Create()
    {
        var multiRegionAccessPointPolicyResult = CreateMultiRegionAccessPointPolicy();
        factoryAction?.Invoke(multiRegionAccessPointPolicyResult);

        return multiRegionAccessPointPolicyResult;
    }

    private Humidifier.S3.MultiRegionAccessPointPolicy CreateMultiRegionAccessPointPolicy()
    {
        var multiRegionAccessPointPolicyResult = new Humidifier.S3.MultiRegionAccessPointPolicy
        {
            GivenName = InputResourceName,
        };

        return multiRegionAccessPointPolicyResult;
    }

} // End Of Class

public static class MultiRegionAccessPointPolicyFactoryExtensions
{
}
