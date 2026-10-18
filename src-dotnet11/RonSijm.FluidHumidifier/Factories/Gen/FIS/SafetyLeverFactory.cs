// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class SafetyLeverFactory(string resourceName = null, Action<Humidifier.FIS.SafetyLever> factoryAction = null) : ResourceFactory<Humidifier.FIS.SafetyLever>(resourceName)
{

    protected override Humidifier.FIS.SafetyLever Create()
    {
        var safetyLeverResult = CreateSafetyLever();
        factoryAction?.Invoke(safetyLeverResult);

        return safetyLeverResult;
    }

    private Humidifier.FIS.SafetyLever CreateSafetyLever()
    {
        var safetyLeverResult = new Humidifier.FIS.SafetyLever
        {
            GivenName = InputResourceName,
        };

        return safetyLeverResult;
    }

} // End Of Class

public static class SafetyLeverFactoryExtensions
{
}
