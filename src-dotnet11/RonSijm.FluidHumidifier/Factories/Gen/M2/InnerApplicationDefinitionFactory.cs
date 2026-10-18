// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.M2;

public class InnerApplicationDefinitionFactory(Action<Humidifier.M2.ApplicationTypes.Definition> factoryAction = null) : SubResourceFactory<Humidifier.M2.ApplicationTypes.Definition>
{

    protected override Humidifier.M2.ApplicationTypes.Definition Create()
    {
        var definitionResult = CreateDefinition();
        factoryAction?.Invoke(definitionResult);

        return definitionResult;
    }

    private Humidifier.M2.ApplicationTypes.Definition CreateDefinition()
    {
        var definitionResult = new Humidifier.M2.ApplicationTypes.Definition();

        return definitionResult;
    }

} // End Of Class

public static class InnerApplicationDefinitionFactoryExtensions
{
}
