// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelCdiInputSpecificationFactory(Action<Humidifier.MediaLive.ChannelTypes.CdiInputSpecification> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.CdiInputSpecification>
{

    protected override Humidifier.MediaLive.ChannelTypes.CdiInputSpecification Create()
    {
        var cdiInputSpecificationResult = CreateCdiInputSpecification();
        factoryAction?.Invoke(cdiInputSpecificationResult);

        return cdiInputSpecificationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.CdiInputSpecification CreateCdiInputSpecification()
    {
        var cdiInputSpecificationResult = new Humidifier.MediaLive.ChannelTypes.CdiInputSpecification();

        return cdiInputSpecificationResult;
    }

} // End Of Class

public static class InnerChannelCdiInputSpecificationFactoryExtensions
{
}
