// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class EntitledDataSetsFactory(string resourceName = null, Action<Humidifier.DataExchange.EntitledDataSets> factoryAction = null) : ResourceFactory<Humidifier.DataExchange.EntitledDataSets>(resourceName)
{

    protected override Humidifier.DataExchange.EntitledDataSets Create()
    {
        var entitledDataSetsResult = CreateEntitledDataSets();
        factoryAction?.Invoke(entitledDataSetsResult);

        return entitledDataSetsResult;
    }

    private Humidifier.DataExchange.EntitledDataSets CreateEntitledDataSets()
    {
        var entitledDataSetsResult = new Humidifier.DataExchange.EntitledDataSets
        {
            GivenName = InputResourceName,
        };

        return entitledDataSetsResult;
    }

} // End Of Class

public static class EntitledDataSetsFactoryExtensions
{
}
