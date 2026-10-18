// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerIdentityPoolPushSyncFactory(Action<Humidifier.Cognito.IdentityPoolTypes.PushSync> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.IdentityPoolTypes.PushSync>
{

    protected override Humidifier.Cognito.IdentityPoolTypes.PushSync Create()
    {
        var pushSyncResult = CreatePushSync();
        factoryAction?.Invoke(pushSyncResult);

        return pushSyncResult;
    }

    private Humidifier.Cognito.IdentityPoolTypes.PushSync CreatePushSync()
    {
        var pushSyncResult = new Humidifier.Cognito.IdentityPoolTypes.PushSync();

        return pushSyncResult;
    }

} // End Of Class

public static class InnerIdentityPoolPushSyncFactoryExtensions
{
}
