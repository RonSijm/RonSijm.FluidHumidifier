// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupEngineVersionFactory(Action<Humidifier.Athena.WorkGroupTypes.EngineVersion> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.EngineVersion>
{

    protected override Humidifier.Athena.WorkGroupTypes.EngineVersion Create()
    {
        var engineVersionResult = CreateEngineVersion();
        factoryAction?.Invoke(engineVersionResult);

        return engineVersionResult;
    }

    private Humidifier.Athena.WorkGroupTypes.EngineVersion CreateEngineVersion()
    {
        var engineVersionResult = new Humidifier.Athena.WorkGroupTypes.EngineVersion();

        return engineVersionResult;
    }

} // End Of Class

public static class InnerWorkGroupEngineVersionFactoryExtensions
{
}
