// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerSecurityProfileApplicationFactory(Action<Humidifier.Connect.SecurityProfileTypes.Application> factoryAction = null) : SubResourceFactory<Humidifier.Connect.SecurityProfileTypes.Application>
{

    protected override Humidifier.Connect.SecurityProfileTypes.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.Connect.SecurityProfileTypes.Application CreateApplication()
    {
        var applicationResult = new Humidifier.Connect.SecurityProfileTypes.Application();

        return applicationResult;
    }

} // End Of Class

public static class InnerSecurityProfileApplicationFactoryExtensions
{
}
