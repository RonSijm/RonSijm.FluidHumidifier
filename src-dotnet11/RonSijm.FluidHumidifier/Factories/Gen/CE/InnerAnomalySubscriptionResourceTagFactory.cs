// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CE;

public class InnerAnomalySubscriptionResourceTagFactory(Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag>
{

    protected override Humidifier.CE.AnomalySubscriptionTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.CE.AnomalySubscriptionTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.CE.AnomalySubscriptionTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerAnomalySubscriptionResourceTagFactoryExtensions
{
}
