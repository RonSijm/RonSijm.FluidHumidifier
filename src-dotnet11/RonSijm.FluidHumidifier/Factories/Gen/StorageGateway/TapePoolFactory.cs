// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class TapePoolFactory(string resourceName = null, Action<Humidifier.StorageGateway.TapePool> factoryAction = null) : ResourceFactory<Humidifier.StorageGateway.TapePool>(resourceName)
{

    protected override Humidifier.StorageGateway.TapePool Create()
    {
        var tapePoolResult = CreateTapePool();
        factoryAction?.Invoke(tapePoolResult);

        return tapePoolResult;
    }

    private Humidifier.StorageGateway.TapePool CreateTapePool()
    {
        var tapePoolResult = new Humidifier.StorageGateway.TapePool
        {
            GivenName = InputResourceName,
        };

        return tapePoolResult;
    }

} // End Of Class

public static class TapePoolFactoryExtensions
{
}
