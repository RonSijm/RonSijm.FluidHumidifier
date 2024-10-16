// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupGateway;

public class HypervisorFactory(string resourceName = null, Action<Humidifier.BackupGateway.Hypervisor> factoryAction = null) : ResourceFactory<Humidifier.BackupGateway.Hypervisor>(resourceName)
{

    protected override Humidifier.BackupGateway.Hypervisor Create()
    {
        var hypervisorResult = CreateHypervisor();
        factoryAction?.Invoke(hypervisorResult);

        return hypervisorResult;
    }

    private Humidifier.BackupGateway.Hypervisor CreateHypervisor()
    {
        var hypervisorResult = new Humidifier.BackupGateway.Hypervisor
        {
            GivenName = InputResourceName,
        };

        return hypervisorResult;
    }

} // End Of Class

public static class HypervisorFactoryExtensions
{
}
