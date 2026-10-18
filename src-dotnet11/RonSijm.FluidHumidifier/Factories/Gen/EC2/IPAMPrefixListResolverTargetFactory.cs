// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMPrefixListResolverTargetFactory(string resourceName = null, Action<Humidifier.EC2.IPAMPrefixListResolverTarget> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMPrefixListResolverTarget>(resourceName)
{

    protected override Humidifier.EC2.IPAMPrefixListResolverTarget Create()
    {
        var iPAMPrefixListResolverTargetResult = CreateIPAMPrefixListResolverTarget();
        factoryAction?.Invoke(iPAMPrefixListResolverTargetResult);

        return iPAMPrefixListResolverTargetResult;
    }

    private Humidifier.EC2.IPAMPrefixListResolverTarget CreateIPAMPrefixListResolverTarget()
    {
        var iPAMPrefixListResolverTargetResult = new Humidifier.EC2.IPAMPrefixListResolverTarget
        {
            GivenName = InputResourceName,
        };

        return iPAMPrefixListResolverTargetResult;
    }

} // End Of Class

public static class IPAMPrefixListResolverTargetFactoryExtensions
{
}
