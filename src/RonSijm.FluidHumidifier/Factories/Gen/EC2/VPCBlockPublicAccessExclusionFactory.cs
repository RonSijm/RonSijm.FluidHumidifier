// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCBlockPublicAccessExclusionFactory(string resourceName = null, Action<Humidifier.EC2.VPCBlockPublicAccessExclusion> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCBlockPublicAccessExclusion>(resourceName)
{

    protected override Humidifier.EC2.VPCBlockPublicAccessExclusion Create()
    {
        var vPCBlockPublicAccessExclusionResult = CreateVPCBlockPublicAccessExclusion();
        factoryAction?.Invoke(vPCBlockPublicAccessExclusionResult);

        return vPCBlockPublicAccessExclusionResult;
    }

    private Humidifier.EC2.VPCBlockPublicAccessExclusion CreateVPCBlockPublicAccessExclusion()
    {
        var vPCBlockPublicAccessExclusionResult = new Humidifier.EC2.VPCBlockPublicAccessExclusion
        {
            GivenName = InputResourceName,
        };

        return vPCBlockPublicAccessExclusionResult;
    }

} // End Of Class

public static class VPCBlockPublicAccessExclusionFactoryExtensions
{
}
