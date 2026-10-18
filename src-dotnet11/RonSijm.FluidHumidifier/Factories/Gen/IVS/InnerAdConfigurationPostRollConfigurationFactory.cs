// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerAdConfigurationPostRollConfigurationFactory(Action<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration>
{

    protected override Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration Create()
    {
        var postRollConfigurationResult = CreatePostRollConfiguration();
        factoryAction?.Invoke(postRollConfigurationResult);

        return postRollConfigurationResult;
    }

    private Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration CreatePostRollConfiguration()
    {
        var postRollConfigurationResult = new Humidifier.IVS.AdConfigurationTypes.PostRollConfiguration();

        return postRollConfigurationResult;
    }

} // End Of Class

public static class InnerAdConfigurationPostRollConfigurationFactoryExtensions
{
}
