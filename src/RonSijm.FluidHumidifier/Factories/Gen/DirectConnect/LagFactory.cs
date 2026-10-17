// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class LagFactory(string resourceName = null, Action<Humidifier.DirectConnect.Lag> factoryAction = null) : ResourceFactory<Humidifier.DirectConnect.Lag>(resourceName)
{

    protected override Humidifier.DirectConnect.Lag Create()
    {
        var lagResult = CreateLag();
        factoryAction?.Invoke(lagResult);

        return lagResult;
    }

    private Humidifier.DirectConnect.Lag CreateLag()
    {
        var lagResult = new Humidifier.DirectConnect.Lag
        {
            GivenName = InputResourceName,
        };

        return lagResult;
    }

} // End Of Class

public static class LagFactoryExtensions
{
}
