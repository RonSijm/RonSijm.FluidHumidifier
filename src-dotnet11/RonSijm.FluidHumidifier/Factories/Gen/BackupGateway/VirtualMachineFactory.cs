// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupGateway;

public class VirtualMachineFactory(string resourceName = null, Action<Humidifier.BackupGateway.VirtualMachine> factoryAction = null) : ResourceFactory<Humidifier.BackupGateway.VirtualMachine>(resourceName)
{

    protected override Humidifier.BackupGateway.VirtualMachine Create()
    {
        var virtualMachineResult = CreateVirtualMachine();
        factoryAction?.Invoke(virtualMachineResult);

        return virtualMachineResult;
    }

    private Humidifier.BackupGateway.VirtualMachine CreateVirtualMachine()
    {
        var virtualMachineResult = new Humidifier.BackupGateway.VirtualMachine
        {
            GivenName = InputResourceName,
        };

        return virtualMachineResult;
    }

} // End Of Class

public static class VirtualMachineFactoryExtensions
{
}
