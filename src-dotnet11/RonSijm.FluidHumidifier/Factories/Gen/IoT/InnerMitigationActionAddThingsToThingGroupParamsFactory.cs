// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerMitigationActionAddThingsToThingGroupParamsFactory(Action<Humidifier.IoT.MitigationActionTypes.AddThingsToThingGroupParams> factoryAction = null) : SubResourceFactory<Humidifier.IoT.MitigationActionTypes.AddThingsToThingGroupParams>
{

    protected override Humidifier.IoT.MitigationActionTypes.AddThingsToThingGroupParams Create()
    {
        var addThingsToThingGroupParamsResult = CreateAddThingsToThingGroupParams();
        factoryAction?.Invoke(addThingsToThingGroupParamsResult);

        return addThingsToThingGroupParamsResult;
    }

    private Humidifier.IoT.MitigationActionTypes.AddThingsToThingGroupParams CreateAddThingsToThingGroupParams()
    {
        var addThingsToThingGroupParamsResult = new Humidifier.IoT.MitigationActionTypes.AddThingsToThingGroupParams();

        return addThingsToThingGroupParamsResult;
    }

} // End Of Class

public static class InnerMitigationActionAddThingsToThingGroupParamsFactoryExtensions
{
}
