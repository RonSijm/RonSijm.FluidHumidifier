// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerEventDataStoreContextKeySelectorFactory(Action<Humidifier.CloudTrail.EventDataStoreTypes.ContextKeySelector> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.EventDataStoreTypes.ContextKeySelector>
{

    protected override Humidifier.CloudTrail.EventDataStoreTypes.ContextKeySelector Create()
    {
        var contextKeySelectorResult = CreateContextKeySelector();
        factoryAction?.Invoke(contextKeySelectorResult);

        return contextKeySelectorResult;
    }

    private Humidifier.CloudTrail.EventDataStoreTypes.ContextKeySelector CreateContextKeySelector()
    {
        var contextKeySelectorResult = new Humidifier.CloudTrail.EventDataStoreTypes.ContextKeySelector();

        return contextKeySelectorResult;
    }

} // End Of Class

public static class InnerEventDataStoreContextKeySelectorFactoryExtensions
{
}
