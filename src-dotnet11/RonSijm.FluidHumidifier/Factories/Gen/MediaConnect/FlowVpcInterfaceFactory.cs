// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class FlowVpcInterfaceFactory(string resourceName = null, Action<Humidifier.MediaConnect.FlowVpcInterface> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.FlowVpcInterface>(resourceName)
{

    protected override Humidifier.MediaConnect.FlowVpcInterface Create()
    {
        var flowVpcInterfaceResult = CreateFlowVpcInterface();
        factoryAction?.Invoke(flowVpcInterfaceResult);

        return flowVpcInterfaceResult;
    }

    private Humidifier.MediaConnect.FlowVpcInterface CreateFlowVpcInterface()
    {
        var flowVpcInterfaceResult = new Humidifier.MediaConnect.FlowVpcInterface
        {
            GivenName = InputResourceName,
        };

        return flowVpcInterfaceResult;
    }

} // End Of Class

public static class FlowVpcInterfaceFactoryExtensions
{
}
