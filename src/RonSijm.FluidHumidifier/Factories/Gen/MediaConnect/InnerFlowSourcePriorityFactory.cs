// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowSourcePriorityFactory(Action<Humidifier.MediaConnect.FlowTypes.SourcePriority> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.SourcePriority>
{

    protected override Humidifier.MediaConnect.FlowTypes.SourcePriority Create()
    {
        var sourcePriorityResult = CreateSourcePriority();
        factoryAction?.Invoke(sourcePriorityResult);

        return sourcePriorityResult;
    }

    private Humidifier.MediaConnect.FlowTypes.SourcePriority CreateSourcePriority()
    {
        var sourcePriorityResult = new Humidifier.MediaConnect.FlowTypes.SourcePriority();

        return sourcePriorityResult;
    }

} // End Of Class

public static class InnerFlowSourcePriorityFactoryExtensions
{
}
