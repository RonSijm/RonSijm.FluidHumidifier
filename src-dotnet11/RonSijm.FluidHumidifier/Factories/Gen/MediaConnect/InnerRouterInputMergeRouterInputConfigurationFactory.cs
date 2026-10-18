// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputMergeRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputConfiguration Create()
    {
        var mergeRouterInputConfigurationResult = CreateMergeRouterInputConfiguration();
        factoryAction?.Invoke(mergeRouterInputConfigurationResult);

        return mergeRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputConfiguration CreateMergeRouterInputConfiguration()
    {
        var mergeRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.MergeRouterInputConfiguration();

        return mergeRouterInputConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputMergeRouterInputConfigurationFactoryExtensions
{
}
