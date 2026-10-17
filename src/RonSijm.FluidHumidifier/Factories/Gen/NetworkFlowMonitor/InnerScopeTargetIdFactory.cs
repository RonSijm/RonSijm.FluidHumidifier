// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFlowMonitor;

public class InnerScopeTargetIdFactory(Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId>
{

    protected override Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId Create()
    {
        var targetIdResult = CreateTargetId();
        factoryAction?.Invoke(targetIdResult);

        return targetIdResult;
    }

    private Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId CreateTargetId()
    {
        var targetIdResult = new Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId();

        return targetIdResult;
    }

} // End Of Class

public static class InnerScopeTargetIdFactoryExtensions
{
}
