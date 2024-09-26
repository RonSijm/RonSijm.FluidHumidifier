// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerSolutionHpoResourceConfigFactory(Action<Humidifier.Personalize.SolutionTypes.HpoResourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.SolutionTypes.HpoResourceConfig>
{

    protected override Humidifier.Personalize.SolutionTypes.HpoResourceConfig Create()
    {
        var hpoResourceConfigResult = CreateHpoResourceConfig();
        factoryAction?.Invoke(hpoResourceConfigResult);

        return hpoResourceConfigResult;
    }

    private Humidifier.Personalize.SolutionTypes.HpoResourceConfig CreateHpoResourceConfig()
    {
        var hpoResourceConfigResult = new Humidifier.Personalize.SolutionTypes.HpoResourceConfig();

        return hpoResourceConfigResult;
    }

} // End Of Class

public static class InnerSolutionHpoResourceConfigFactoryExtensions
{
}
