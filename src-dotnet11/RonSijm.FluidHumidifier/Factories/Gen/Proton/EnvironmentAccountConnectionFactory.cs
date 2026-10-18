// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Proton;

public class EnvironmentAccountConnectionFactory(string resourceName = null, Action<Humidifier.Proton.EnvironmentAccountConnection> factoryAction = null) : ResourceFactory<Humidifier.Proton.EnvironmentAccountConnection>(resourceName)
{

    protected override Humidifier.Proton.EnvironmentAccountConnection Create()
    {
        var environmentAccountConnectionResult = CreateEnvironmentAccountConnection();
        factoryAction?.Invoke(environmentAccountConnectionResult);

        return environmentAccountConnectionResult;
    }

    private Humidifier.Proton.EnvironmentAccountConnection CreateEnvironmentAccountConnection()
    {
        var environmentAccountConnectionResult = new Humidifier.Proton.EnvironmentAccountConnection
        {
            GivenName = InputResourceName,
        };

        return environmentAccountConnectionResult;
    }

} // End Of Class

public static class EnvironmentAccountConnectionFactoryExtensions
{
}
