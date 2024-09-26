// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CE;

public class InnerAnomalyMonitorResourceTagFactory(Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.CE.AnomalyMonitorTypes.ResourceTag>
{

    protected override Humidifier.CE.AnomalyMonitorTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.CE.AnomalyMonitorTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.CE.AnomalyMonitorTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerAnomalyMonitorResourceTagFactoryExtensions
{
}
