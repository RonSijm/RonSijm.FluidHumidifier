// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class TapeFactory(string resourceName = null, Action<Humidifier.StorageGateway.Tape> factoryAction = null) : ResourceFactory<Humidifier.StorageGateway.Tape>(resourceName)
{

    protected override Humidifier.StorageGateway.Tape Create()
    {
        var tapeResult = CreateTape();
        factoryAction?.Invoke(tapeResult);

        return tapeResult;
    }

    private Humidifier.StorageGateway.Tape CreateTape()
    {
        var tapeResult = new Humidifier.StorageGateway.Tape
        {
            GivenName = InputResourceName,
        };

        return tapeResult;
    }

} // End Of Class

public static class TapeFactoryExtensions
{
}
