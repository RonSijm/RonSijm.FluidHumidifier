// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Shield;

public class DRTAccessFactory(string resourceName = null, Action<Humidifier.Shield.DRTAccess> factoryAction = null) : ResourceFactory<Humidifier.Shield.DRTAccess>(resourceName)
{

    protected override Humidifier.Shield.DRTAccess Create()
    {
        var dRTAccessResult = CreateDRTAccess();
        factoryAction?.Invoke(dRTAccessResult);

        return dRTAccessResult;
    }

    private Humidifier.Shield.DRTAccess CreateDRTAccess()
    {
        var dRTAccessResult = new Humidifier.Shield.DRTAccess
        {
            GivenName = InputResourceName,
        };

        return dRTAccessResult;
    }

} // End Of Class

public static class DRTAccessFactoryExtensions
{
}
