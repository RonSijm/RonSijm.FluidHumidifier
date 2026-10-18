// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerOutboundExternalLinkLinkApplicationLogSamplingFactory(Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling>
{

    protected override Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling Create()
    {
        var linkApplicationLogSamplingResult = CreateLinkApplicationLogSampling();
        factoryAction?.Invoke(linkApplicationLogSamplingResult);

        return linkApplicationLogSamplingResult;
    }

    private Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling CreateLinkApplicationLogSampling()
    {
        var linkApplicationLogSamplingResult = new Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling();

        return linkApplicationLogSamplingResult;
    }

} // End Of Class

public static class InnerOutboundExternalLinkLinkApplicationLogSamplingFactoryExtensions
{
}
