// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeSourcePriorityFactory(Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.SourcePriority>
{

    protected override Humidifier.MediaConnect.BridgeTypes.SourcePriority Create()
    {
        var sourcePriorityResult = CreateSourcePriority();
        factoryAction?.Invoke(sourcePriorityResult);

        return sourcePriorityResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.SourcePriority CreateSourcePriority()
    {
        var sourcePriorityResult = new Humidifier.MediaConnect.BridgeTypes.SourcePriority();

        return sourcePriorityResult;
    }

} // End Of Class

public static class InnerBridgeSourcePriorityFactoryExtensions
{
}
