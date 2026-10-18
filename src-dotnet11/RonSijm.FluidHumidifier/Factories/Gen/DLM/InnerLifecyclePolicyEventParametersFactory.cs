// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyEventParametersFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.EventParameters>
{

    protected override Humidifier.DLM.LifecyclePolicyTypes.EventParameters Create()
    {
        var eventParametersResult = CreateEventParameters();
        factoryAction?.Invoke(eventParametersResult);

        return eventParametersResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.EventParameters CreateEventParameters()
    {
        var eventParametersResult = new Humidifier.DLM.LifecyclePolicyTypes.EventParameters();

        return eventParametersResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyEventParametersFactoryExtensions
{
}
