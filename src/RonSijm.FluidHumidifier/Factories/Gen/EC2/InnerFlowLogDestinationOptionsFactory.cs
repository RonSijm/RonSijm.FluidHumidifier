// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerFlowLogDestinationOptionsFactory(Action<Humidifier.EC2.FlowLogTypes.DestinationOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.FlowLogTypes.DestinationOptions>
{

    protected override Humidifier.EC2.FlowLogTypes.DestinationOptions Create()
    {
        var destinationOptionsResult = CreateDestinationOptions();
        factoryAction?.Invoke(destinationOptionsResult);

        return destinationOptionsResult;
    }

    private Humidifier.EC2.FlowLogTypes.DestinationOptions CreateDestinationOptions()
    {
        var destinationOptionsResult = new Humidifier.EC2.FlowLogTypes.DestinationOptions();

        return destinationOptionsResult;
    }

} // End Of Class

public static class InnerFlowLogDestinationOptionsFactoryExtensions
{
}
