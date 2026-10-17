// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServerlessRepo;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.ServerlessRepo.Application> factoryAction = null) : ResourceFactory<Humidifier.ServerlessRepo.Application>(resourceName)
{

    protected override Humidifier.ServerlessRepo.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.ServerlessRepo.Application CreateApplication()
    {
        var applicationResult = new Humidifier.ServerlessRepo.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
}
