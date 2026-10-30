// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.MGN.Application> factoryAction = null) : ResourceFactory<Humidifier.MGN.Application>(resourceName)
{

    protected override Humidifier.MGN.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.MGN.Application CreateApplication()
    {
        var applicationResult = new Humidifier.MGN.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
}
