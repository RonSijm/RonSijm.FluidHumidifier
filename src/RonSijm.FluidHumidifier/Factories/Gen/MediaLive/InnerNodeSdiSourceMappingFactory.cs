// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerNodeSdiSourceMappingFactory(Action<Humidifier.MediaLive.NodeTypes.SdiSourceMapping> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.NodeTypes.SdiSourceMapping>
{

    protected override Humidifier.MediaLive.NodeTypes.SdiSourceMapping Create()
    {
        var sdiSourceMappingResult = CreateSdiSourceMapping();
        factoryAction?.Invoke(sdiSourceMappingResult);

        return sdiSourceMappingResult;
    }

    private Humidifier.MediaLive.NodeTypes.SdiSourceMapping CreateSdiSourceMapping()
    {
        var sdiSourceMappingResult = new Humidifier.MediaLive.NodeTypes.SdiSourceMapping();

        return sdiSourceMappingResult;
    }

} // End Of Class

public static class InnerNodeSdiSourceMappingFactoryExtensions
{
}
