// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class BlueprintFactory(string resourceName = null, Action<Humidifier.Glue.Blueprint> factoryAction = null) : ResourceFactory<Humidifier.Glue.Blueprint>(resourceName)
{

    protected override Humidifier.Glue.Blueprint Create()
    {
        var blueprintResult = CreateBlueprint();
        factoryAction?.Invoke(blueprintResult);

        return blueprintResult;
    }

    private Humidifier.Glue.Blueprint CreateBlueprint()
    {
        var blueprintResult = new Humidifier.Glue.Blueprint
        {
            GivenName = InputResourceName,
        };

        return blueprintResult;
    }

} // End Of Class

public static class BlueprintFactoryExtensions
{
}
