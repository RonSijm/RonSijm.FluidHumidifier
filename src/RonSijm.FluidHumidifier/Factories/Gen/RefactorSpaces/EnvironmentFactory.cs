// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class EnvironmentFactory(string resourceName = null, Action<Humidifier.RefactorSpaces.Environment> factoryAction = null) : ResourceFactory<Humidifier.RefactorSpaces.Environment>(resourceName)
{

    protected override Humidifier.RefactorSpaces.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.RefactorSpaces.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.RefactorSpaces.Environment
        {
            GivenName = InputResourceName,
        };

        return environmentResult;
    }

} // End Of Class

public static class EnvironmentFactoryExtensions
{
}
