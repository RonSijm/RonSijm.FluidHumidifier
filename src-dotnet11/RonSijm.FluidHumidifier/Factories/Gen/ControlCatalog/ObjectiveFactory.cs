// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlCatalog;

public class ObjectiveFactory(string resourceName = null, Action<Humidifier.ControlCatalog.Objective> factoryAction = null) : ResourceFactory<Humidifier.ControlCatalog.Objective>(resourceName)
{

    protected override Humidifier.ControlCatalog.Objective Create()
    {
        var objectiveResult = CreateObjective();
        factoryAction?.Invoke(objectiveResult);

        return objectiveResult;
    }

    private Humidifier.ControlCatalog.Objective CreateObjective()
    {
        var objectiveResult = new Humidifier.ControlCatalog.Objective
        {
            GivenName = InputResourceName,
        };

        return objectiveResult;
    }

} // End Of Class

public static class ObjectiveFactoryExtensions
{
}
