// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerNodeNodeInterfaceMappingFactory(Action<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping>
{

    protected override Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping Create()
    {
        var nodeInterfaceMappingResult = CreateNodeInterfaceMapping();
        factoryAction?.Invoke(nodeInterfaceMappingResult);

        return nodeInterfaceMappingResult;
    }

    private Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping CreateNodeInterfaceMapping()
    {
        var nodeInterfaceMappingResult = new Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping();

        return nodeInterfaceMappingResult;
    }

} // End Of Class

public static class InnerNodeNodeInterfaceMappingFactoryExtensions
{
}
