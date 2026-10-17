// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ReservedCapacityFactory(string resourceName = null, Action<Humidifier.SageMaker.ReservedCapacity> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.ReservedCapacity>(resourceName)
{

    protected override Humidifier.SageMaker.ReservedCapacity Create()
    {
        var reservedCapacityResult = CreateReservedCapacity();
        factoryAction?.Invoke(reservedCapacityResult);

        return reservedCapacityResult;
    }

    private Humidifier.SageMaker.ReservedCapacity CreateReservedCapacity()
    {
        var reservedCapacityResult = new Humidifier.SageMaker.ReservedCapacity
        {
            GivenName = InputResourceName,
        };

        return reservedCapacityResult;
    }

} // End Of Class

public static class ReservedCapacityFactoryExtensions
{
}
