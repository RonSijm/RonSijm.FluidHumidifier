// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageMicrovmImageHooksFactory(Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks>
{

    protected override Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks Create()
    {
        var microvmImageHooksResult = CreateMicrovmImageHooks();
        factoryAction?.Invoke(microvmImageHooksResult);

        return microvmImageHooksResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks CreateMicrovmImageHooks()
    {
        var microvmImageHooksResult = new Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks();

        return microvmImageHooksResult;
    }

} // End Of Class

public static class InnerMicrovmImageMicrovmImageHooksFactoryExtensions
{
}
