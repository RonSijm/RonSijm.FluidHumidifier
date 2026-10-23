// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputInputSourceFactory(Action<Humidifier.MediaLive.InputTypes.InputSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.InputSource>
{

    protected override Humidifier.MediaLive.InputTypes.InputSource Create()
    {
        var inputSourceResult = CreateInputSource();
        factoryAction?.Invoke(inputSourceResult);

        return inputSourceResult;
    }

    private Humidifier.MediaLive.InputTypes.InputSource CreateInputSource()
    {
        var inputSourceResult = new Humidifier.MediaLive.InputTypes.InputSource();

        return inputSourceResult;
    }

} // End Of Class

public static class InnerInputInputSourceFactoryExtensions
{
}
