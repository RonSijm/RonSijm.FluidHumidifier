// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionEphemeralStorageFactory(Action<Humidifier.Lambda.FunctionTypes.EphemeralStorage> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.EphemeralStorage>
{

    protected override Humidifier.Lambda.FunctionTypes.EphemeralStorage Create()
    {
        var ephemeralStorageResult = CreateEphemeralStorage();
        factoryAction?.Invoke(ephemeralStorageResult);

        return ephemeralStorageResult;
    }

    private Humidifier.Lambda.FunctionTypes.EphemeralStorage CreateEphemeralStorage()
    {
        var ephemeralStorageResult = new Humidifier.Lambda.FunctionTypes.EphemeralStorage();

        return ephemeralStorageResult;
    }

} // End Of Class

public static class InnerFunctionEphemeralStorageFactoryExtensions
{
}
