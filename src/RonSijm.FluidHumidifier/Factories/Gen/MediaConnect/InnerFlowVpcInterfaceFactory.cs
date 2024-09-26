// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowVpcInterfaceFactory(Action<Humidifier.MediaConnect.FlowTypes.VpcInterface> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.VpcInterface>
{

    protected override Humidifier.MediaConnect.FlowTypes.VpcInterface Create()
    {
        var vpcInterfaceResult = CreateVpcInterface();
        factoryAction?.Invoke(vpcInterfaceResult);

        return vpcInterfaceResult;
    }

    private Humidifier.MediaConnect.FlowTypes.VpcInterface CreateVpcInterface()
    {
        var vpcInterfaceResult = new Humidifier.MediaConnect.FlowTypes.VpcInterface();

        return vpcInterfaceResult;
    }

} // End Of Class

public static class InnerFlowVpcInterfaceFactoryExtensions
{
}
