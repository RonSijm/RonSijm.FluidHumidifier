// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexprogramMultiplexProgramServiceDescriptorFactory(Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor>
{

    protected override Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor Create()
    {
        var multiplexProgramServiceDescriptorResult = CreateMultiplexProgramServiceDescriptor();
        factoryAction?.Invoke(multiplexProgramServiceDescriptorResult);

        return multiplexProgramServiceDescriptorResult;
    }

    private Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor CreateMultiplexProgramServiceDescriptor()
    {
        var multiplexProgramServiceDescriptorResult = new Humidifier.MediaLive.MultiplexprogramTypes.MultiplexProgramServiceDescriptor();

        return multiplexProgramServiceDescriptorResult;
    }

} // End Of Class

public static class InnerMultiplexprogramMultiplexProgramServiceDescriptorFactoryExtensions
{
}
