// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputBlackFramesConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.BlackFramesConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.BlackFramesConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.BlackFramesConfiguration Create()
    {
        var blackFramesConfigurationResult = CreateBlackFramesConfiguration();
        factoryAction?.Invoke(blackFramesConfigurationResult);

        return blackFramesConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.BlackFramesConfiguration CreateBlackFramesConfiguration()
    {
        var blackFramesConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.BlackFramesConfiguration();

        return blackFramesConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputBlackFramesConfigurationFactoryExtensions
{
}
