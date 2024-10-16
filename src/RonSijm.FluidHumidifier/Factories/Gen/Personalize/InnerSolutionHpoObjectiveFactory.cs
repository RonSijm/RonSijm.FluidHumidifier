// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerSolutionHpoObjectiveFactory(Action<Humidifier.Personalize.SolutionTypes.HpoObjective> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.SolutionTypes.HpoObjective>
{

    protected override Humidifier.Personalize.SolutionTypes.HpoObjective Create()
    {
        var hpoObjectiveResult = CreateHpoObjective();
        factoryAction?.Invoke(hpoObjectiveResult);

        return hpoObjectiveResult;
    }

    private Humidifier.Personalize.SolutionTypes.HpoObjective CreateHpoObjective()
    {
        var hpoObjectiveResult = new Humidifier.Personalize.SolutionTypes.HpoObjective();

        return hpoObjectiveResult;
    }

} // End Of Class

public static class InnerSolutionHpoObjectiveFactoryExtensions
{
}
