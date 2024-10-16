// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerRestoreTestingSelectionProtectedResourceConditionsFactory(Action<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions> factoryAction = null) : SubResourceFactory<Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions>
{

    protected override Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions Create()
    {
        var protectedResourceConditionsResult = CreateProtectedResourceConditions();
        factoryAction?.Invoke(protectedResourceConditionsResult);

        return protectedResourceConditionsResult;
    }

    private Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions CreateProtectedResourceConditions()
    {
        var protectedResourceConditionsResult = new Humidifier.Backup.RestoreTestingSelectionTypes.ProtectedResourceConditions();

        return protectedResourceConditionsResult;
    }

} // End Of Class

public static class InnerRestoreTestingSelectionProtectedResourceConditionsFactoryExtensions
{
}
