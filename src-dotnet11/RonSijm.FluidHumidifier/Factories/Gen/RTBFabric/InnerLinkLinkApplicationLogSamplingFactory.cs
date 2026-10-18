// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkLinkApplicationLogSamplingFactory(Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling>
{

    protected override Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling Create()
    {
        var linkApplicationLogSamplingResult = CreateLinkApplicationLogSampling();
        factoryAction?.Invoke(linkApplicationLogSamplingResult);

        return linkApplicationLogSamplingResult;
    }

    private Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling CreateLinkApplicationLogSampling()
    {
        var linkApplicationLogSamplingResult = new Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling();

        return linkApplicationLogSamplingResult;
    }

} // End Of Class

public static class InnerLinkLinkApplicationLogSamplingFactoryExtensions
{
}
