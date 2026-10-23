// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputInputDestinationVpcFactory(Action<Humidifier.MediaLive.InputTypes.InputDestinationVpc> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.InputDestinationVpc>
{

    protected override Humidifier.MediaLive.InputTypes.InputDestinationVpc Create()
    {
        var inputDestinationVpcResult = CreateInputDestinationVpc();
        factoryAction?.Invoke(inputDestinationVpcResult);

        return inputDestinationVpcResult;
    }

    private Humidifier.MediaLive.InputTypes.InputDestinationVpc CreateInputDestinationVpc()
    {
        var inputDestinationVpcResult = new Humidifier.MediaLive.InputTypes.InputDestinationVpc();

        return inputDestinationVpcResult;
    }

} // End Of Class

public static class InnerInputInputDestinationVpcFactoryExtensions
{
}
