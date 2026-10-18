// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class BlueprintFactory(string resourceName = null, Action<Humidifier.Bedrock.Blueprint> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.Blueprint>(resourceName)
{

    protected override Humidifier.Bedrock.Blueprint Create()
    {
        var blueprintResult = CreateBlueprint();
        factoryAction?.Invoke(blueprintResult);

        return blueprintResult;
    }

    private Humidifier.Bedrock.Blueprint CreateBlueprint()
    {
        var blueprintResult = new Humidifier.Bedrock.Blueprint
        {
            GivenName = InputResourceName,
        };

        return blueprintResult;
    }

} // End Of Class

public static class BlueprintFactoryExtensions
{
}
