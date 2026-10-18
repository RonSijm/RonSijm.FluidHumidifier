// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SavingsPlans;

public class SavingsPlanFactory(string resourceName = null, Action<Humidifier.SavingsPlans.SavingsPlan> factoryAction = null) : ResourceFactory<Humidifier.SavingsPlans.SavingsPlan>(resourceName)
{

    protected override Humidifier.SavingsPlans.SavingsPlan Create()
    {
        var savingsPlanResult = CreateSavingsPlan();
        factoryAction?.Invoke(savingsPlanResult);

        return savingsPlanResult;
    }

    private Humidifier.SavingsPlans.SavingsPlan CreateSavingsPlan()
    {
        var savingsPlanResult = new Humidifier.SavingsPlans.SavingsPlan
        {
            GivenName = InputResourceName,
        };

        return savingsPlanResult;
    }

} // End Of Class

public static class SavingsPlanFactoryExtensions
{
}
