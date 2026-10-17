// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputFrozenFramesConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.FrozenFramesConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.FrozenFramesConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.FrozenFramesConfiguration Create()
    {
        var frozenFramesConfigurationResult = CreateFrozenFramesConfiguration();
        factoryAction?.Invoke(frozenFramesConfigurationResult);

        return frozenFramesConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.FrozenFramesConfiguration CreateFrozenFramesConfiguration()
    {
        var frozenFramesConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.FrozenFramesConfiguration();

        return frozenFramesConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputFrozenFramesConfigurationFactoryExtensions
{
}
