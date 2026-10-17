// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerInboundExternalLinkLinkApplicationLogSamplingFactory(Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling>
{

    protected override Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling Create()
    {
        var linkApplicationLogSamplingResult = CreateLinkApplicationLogSampling();
        factoryAction?.Invoke(linkApplicationLogSamplingResult);

        return linkApplicationLogSamplingResult;
    }

    private Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling CreateLinkApplicationLogSampling()
    {
        var linkApplicationLogSamplingResult = new Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling();

        return linkApplicationLogSamplingResult;
    }

} // End Of Class

public static class InnerInboundExternalLinkLinkApplicationLogSamplingFactoryExtensions
{
}
