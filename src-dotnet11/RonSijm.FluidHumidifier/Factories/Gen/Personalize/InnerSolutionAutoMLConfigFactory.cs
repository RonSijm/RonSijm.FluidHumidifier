// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerSolutionAutoMLConfigFactory(Action<Humidifier.Personalize.SolutionTypes.AutoMLConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.SolutionTypes.AutoMLConfig>
{

    protected override Humidifier.Personalize.SolutionTypes.AutoMLConfig Create()
    {
        var autoMLConfigResult = CreateAutoMLConfig();
        factoryAction?.Invoke(autoMLConfigResult);

        return autoMLConfigResult;
    }

    private Humidifier.Personalize.SolutionTypes.AutoMLConfig CreateAutoMLConfig()
    {
        var autoMLConfigResult = new Humidifier.Personalize.SolutionTypes.AutoMLConfig();

        return autoMLConfigResult;
    }

} // End Of Class

public static class InnerSolutionAutoMLConfigFactoryExtensions
{
}
