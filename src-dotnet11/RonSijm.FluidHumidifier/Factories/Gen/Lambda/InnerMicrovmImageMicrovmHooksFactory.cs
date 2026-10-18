// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageMicrovmHooksFactory(Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks>
{

    protected override Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks Create()
    {
        var microvmHooksResult = CreateMicrovmHooks();
        factoryAction?.Invoke(microvmHooksResult);

        return microvmHooksResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks CreateMicrovmHooks()
    {
        var microvmHooksResult = new Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks();

        return microvmHooksResult;
    }

} // End Of Class

public static class InnerMicrovmImageMicrovmHooksFactoryExtensions
{
}
