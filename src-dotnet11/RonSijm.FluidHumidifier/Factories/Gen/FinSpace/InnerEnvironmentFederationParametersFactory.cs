// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FinSpace;

public class InnerEnvironmentFederationParametersFactory(Action<Humidifier.FinSpace.EnvironmentTypes.FederationParameters> factoryAction = null) : SubResourceFactory<Humidifier.FinSpace.EnvironmentTypes.FederationParameters>
{

    protected override Humidifier.FinSpace.EnvironmentTypes.FederationParameters Create()
    {
        var federationParametersResult = CreateFederationParameters();
        factoryAction?.Invoke(federationParametersResult);

        return federationParametersResult;
    }

    private Humidifier.FinSpace.EnvironmentTypes.FederationParameters CreateFederationParameters()
    {
        var federationParametersResult = new Humidifier.FinSpace.EnvironmentTypes.FederationParameters();

        return federationParametersResult;
    }

} // End Of Class

public static class InnerEnvironmentFederationParametersFactoryExtensions
{
}
