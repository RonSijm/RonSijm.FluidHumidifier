// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerEnvironmentActionsAwsConsoleLinkParametersFactory(Action<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters>
{

    protected override Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters Create()
    {
        var awsConsoleLinkParametersResult = CreateAwsConsoleLinkParameters();
        factoryAction?.Invoke(awsConsoleLinkParametersResult);

        return awsConsoleLinkParametersResult;
    }

    private Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters CreateAwsConsoleLinkParameters()
    {
        var awsConsoleLinkParametersResult = new Humidifier.DataZone.EnvironmentActionsTypes.AwsConsoleLinkParameters();

        return awsConsoleLinkParametersResult;
    }

} // End Of Class

public static class InnerEnvironmentActionsAwsConsoleLinkParametersFactoryExtensions
{
}
