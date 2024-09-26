// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerMissionProfileDataflowEdgeFactory(Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge>
{

    protected override Humidifier.GroundStation.MissionProfileTypes.DataflowEdge Create()
    {
        var dataflowEdgeResult = CreateDataflowEdge();
        factoryAction?.Invoke(dataflowEdgeResult);

        return dataflowEdgeResult;
    }

    private Humidifier.GroundStation.MissionProfileTypes.DataflowEdge CreateDataflowEdge()
    {
        var dataflowEdgeResult = new Humidifier.GroundStation.MissionProfileTypes.DataflowEdge();

        return dataflowEdgeResult;
    }

} // End Of Class

public static class InnerMissionProfileDataflowEdgeFactoryExtensions
{
}
