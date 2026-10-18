// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElementalInference;

public class InnerFeedCroppingConfigFactory(Action<Humidifier.ElementalInference.FeedTypes.CroppingConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElementalInference.FeedTypes.CroppingConfig>
{

    protected override Humidifier.ElementalInference.FeedTypes.CroppingConfig Create()
    {
        var croppingConfigResult = CreateCroppingConfig();
        factoryAction?.Invoke(croppingConfigResult);

        return croppingConfigResult;
    }

    private Humidifier.ElementalInference.FeedTypes.CroppingConfig CreateCroppingConfig()
    {
        var croppingConfigResult = new Humidifier.ElementalInference.FeedTypes.CroppingConfig();

        return croppingConfigResult;
    }

} // End Of Class

public static class InnerFeedCroppingConfigFactoryExtensions
{
}
