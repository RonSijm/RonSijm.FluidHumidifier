// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ReservedInstancesFactory(string resourceName = null, Action<Humidifier.EC2.ReservedInstances> factoryAction = null) : ResourceFactory<Humidifier.EC2.ReservedInstances>(resourceName)
{

    protected override Humidifier.EC2.ReservedInstances Create()
    {
        var reservedInstancesResult = CreateReservedInstances();
        factoryAction?.Invoke(reservedInstancesResult);

        return reservedInstancesResult;
    }

    private Humidifier.EC2.ReservedInstances CreateReservedInstances()
    {
        var reservedInstancesResult = new Humidifier.EC2.ReservedInstances
        {
            GivenName = InputResourceName,
        };

        return reservedInstancesResult;
    }

} // End Of Class

public static class ReservedInstancesFactoryExtensions
{
}
