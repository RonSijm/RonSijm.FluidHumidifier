// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMAllocationFactory(string resourceName = null, Action<Humidifier.EC2.IPAMAllocation> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMAllocation>(resourceName)
{

    protected override Humidifier.EC2.IPAMAllocation Create()
    {
        var iPAMAllocationResult = CreateIPAMAllocation();
        factoryAction?.Invoke(iPAMAllocationResult);

        return iPAMAllocationResult;
    }

    private Humidifier.EC2.IPAMAllocation CreateIPAMAllocation()
    {
        var iPAMAllocationResult = new Humidifier.EC2.IPAMAllocation
        {
            GivenName = InputResourceName,
        };

        return iPAMAllocationResult;
    }

} // End Of Class

public static class IPAMAllocationFactoryExtensions
{
}
