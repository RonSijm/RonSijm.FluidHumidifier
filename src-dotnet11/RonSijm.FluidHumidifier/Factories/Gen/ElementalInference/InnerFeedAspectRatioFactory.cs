// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElementalInference;

public class InnerFeedAspectRatioFactory(Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> factoryAction = null) : SubResourceFactory<Humidifier.ElementalInference.FeedTypes.AspectRatio>
{

    protected override Humidifier.ElementalInference.FeedTypes.AspectRatio Create()
    {
        var aspectRatioResult = CreateAspectRatio();
        factoryAction?.Invoke(aspectRatioResult);

        return aspectRatioResult;
    }

    private Humidifier.ElementalInference.FeedTypes.AspectRatio CreateAspectRatio()
    {
        var aspectRatioResult = new Humidifier.ElementalInference.FeedTypes.AspectRatio();

        return aspectRatioResult;
    }

} // End Of Class

public static class InnerFeedAspectRatioFactoryExtensions
{
}
