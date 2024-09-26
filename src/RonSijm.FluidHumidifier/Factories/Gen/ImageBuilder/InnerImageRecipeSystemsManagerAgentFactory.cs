// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageRecipeSystemsManagerAgentFactory(Action<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent>
{

    protected override Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent Create()
    {
        var systemsManagerAgentResult = CreateSystemsManagerAgent();
        factoryAction?.Invoke(systemsManagerAgentResult);

        return systemsManagerAgentResult;
    }

    private Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent CreateSystemsManagerAgent()
    {
        var systemsManagerAgentResult = new Humidifier.ImageBuilder.ImageRecipeTypes.SystemsManagerAgent();

        return systemsManagerAgentResult;
    }

} // End Of Class

public static class InnerImageRecipeSystemsManagerAgentFactoryExtensions
{
}
