// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerComponentComponentChildFactory(Action<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild>
{

    protected override Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild Create()
    {
        var componentChildResult = CreateComponentChild();
        factoryAction?.Invoke(componentChildResult);

        return componentChildResult;
    }

    private Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild CreateComponentChild()
    {
        var componentChildResult = new Humidifier.AmplifyUIBuilder.ComponentTypes.ComponentChild();

        return componentChildResult;
    }

} // End Of Class

public static class InnerComponentComponentChildFactoryExtensions
{
}
