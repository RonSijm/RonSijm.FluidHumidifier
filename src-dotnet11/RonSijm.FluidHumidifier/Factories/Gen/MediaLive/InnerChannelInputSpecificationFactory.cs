// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelInputSpecificationFactory(Action<Humidifier.MediaLive.ChannelTypes.InputSpecification> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.InputSpecification>
{

    protected override Humidifier.MediaLive.ChannelTypes.InputSpecification Create()
    {
        var inputSpecificationResult = CreateInputSpecification();
        factoryAction?.Invoke(inputSpecificationResult);

        return inputSpecificationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.InputSpecification CreateInputSpecification()
    {
        var inputSpecificationResult = new Humidifier.MediaLive.ChannelTypes.InputSpecification();

        return inputSpecificationResult;
    }

} // End Of Class

public static class InnerChannelInputSpecificationFactoryExtensions
{
}
