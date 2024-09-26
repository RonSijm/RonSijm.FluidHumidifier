// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class InnerAlarmModelAcknowledgeFlowFactory(Action<Humidifier.IoTEvents.AlarmModelTypes.AcknowledgeFlow> factoryAction = null) : SubResourceFactory<Humidifier.IoTEvents.AlarmModelTypes.AcknowledgeFlow>
{

    protected override Humidifier.IoTEvents.AlarmModelTypes.AcknowledgeFlow Create()
    {
        var acknowledgeFlowResult = CreateAcknowledgeFlow();
        factoryAction?.Invoke(acknowledgeFlowResult);

        return acknowledgeFlowResult;
    }

    private Humidifier.IoTEvents.AlarmModelTypes.AcknowledgeFlow CreateAcknowledgeFlow()
    {
        var acknowledgeFlowResult = new Humidifier.IoTEvents.AlarmModelTypes.AcknowledgeFlow();

        return acknowledgeFlowResult;
    }

} // End Of Class

public static class InnerAlarmModelAcknowledgeFlowFactoryExtensions
{
}
