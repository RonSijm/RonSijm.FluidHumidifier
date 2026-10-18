// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class LimitsProfileFactory(string resourceName = null, Action<Humidifier.QuickSight.LimitsProfile> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.LimitsProfile>(resourceName)
{

    protected override Humidifier.QuickSight.LimitsProfile Create()
    {
        var limitsProfileResult = CreateLimitsProfile();
        factoryAction?.Invoke(limitsProfileResult);

        return limitsProfileResult;
    }

    private Humidifier.QuickSight.LimitsProfile CreateLimitsProfile()
    {
        var limitsProfileResult = new Humidifier.QuickSight.LimitsProfile
        {
            GivenName = InputResourceName,
        };

        return limitsProfileResult;
    }

} // End Of Class

public static class LimitsProfileFactoryExtensions
{
}
