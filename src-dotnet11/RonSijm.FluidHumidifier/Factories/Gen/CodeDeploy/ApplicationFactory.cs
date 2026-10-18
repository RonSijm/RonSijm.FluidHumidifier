// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.CodeDeploy.Application> factoryAction = null) : ResourceFactory<Humidifier.CodeDeploy.Application>(resourceName)
{

    protected override Humidifier.CodeDeploy.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.CodeDeploy.Application CreateApplication()
    {
        var applicationResult = new Humidifier.CodeDeploy.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
}
