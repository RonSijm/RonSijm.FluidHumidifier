// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class AssetsFactory(string resourceName = null, Action<Humidifier.DataExchange.Assets> factoryAction = null) : ResourceFactory<Humidifier.DataExchange.Assets>(resourceName)
{

    protected override Humidifier.DataExchange.Assets Create()
    {
        var assetsResult = CreateAssets();
        factoryAction?.Invoke(assetsResult);

        return assetsResult;
    }

    private Humidifier.DataExchange.Assets CreateAssets()
    {
        var assetsResult = new Humidifier.DataExchange.Assets
        {
            GivenName = InputResourceName,
        };

        return assetsResult;
    }

} // End Of Class

public static class AssetsFactoryExtensions
{
}
