// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class MasterFactory(string resourceName = null, Action<Humidifier.GuardDuty.Master> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.Master>(resourceName)
{

    protected override Humidifier.GuardDuty.Master Create()
    {
        var masterResult = CreateMaster();
        factoryAction?.Invoke(masterResult);

        return masterResult;
    }

    private Humidifier.GuardDuty.Master CreateMaster()
    {
        var masterResult = new Humidifier.GuardDuty.Master
        {
            GivenName = InputResourceName,
        };

        return masterResult;
    }

} // End Of Class

public static class MasterFactoryExtensions
{
}
