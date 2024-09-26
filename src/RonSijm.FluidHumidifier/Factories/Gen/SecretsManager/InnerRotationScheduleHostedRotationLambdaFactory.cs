// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class InnerRotationScheduleHostedRotationLambdaFactory(Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> factoryAction = null) : SubResourceFactory<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda>
{

    protected override Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda Create()
    {
        var hostedRotationLambdaResult = CreateHostedRotationLambda();
        factoryAction?.Invoke(hostedRotationLambdaResult);

        return hostedRotationLambdaResult;
    }

    private Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda CreateHostedRotationLambda()
    {
        var hostedRotationLambdaResult = new Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda();

        return hostedRotationLambdaResult;
    }

} // End Of Class

public static class InnerRotationScheduleHostedRotationLambdaFactoryExtensions
{
}
