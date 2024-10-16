// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerFleetComputeCapacityFactory(Action<Humidifier.AppStream.FleetTypes.ComputeCapacity> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.FleetTypes.ComputeCapacity>
{

    protected override Humidifier.AppStream.FleetTypes.ComputeCapacity Create()
    {
        var computeCapacityResult = CreateComputeCapacity();
        factoryAction?.Invoke(computeCapacityResult);

        return computeCapacityResult;
    }

    private Humidifier.AppStream.FleetTypes.ComputeCapacity CreateComputeCapacity()
    {
        var computeCapacityResult = new Humidifier.AppStream.FleetTypes.ComputeCapacity();

        return computeCapacityResult;
    }

} // End Of Class

public static class InnerFleetComputeCapacityFactoryExtensions
{
}
