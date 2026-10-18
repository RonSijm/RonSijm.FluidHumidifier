// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserUserIdentityInfoFactory(Action<Humidifier.Connect.UserTypes.UserIdentityInfo> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserTypes.UserIdentityInfo>
{

    protected override Humidifier.Connect.UserTypes.UserIdentityInfo Create()
    {
        var userIdentityInfoResult = CreateUserIdentityInfo();
        factoryAction?.Invoke(userIdentityInfoResult);

        return userIdentityInfoResult;
    }

    private Humidifier.Connect.UserTypes.UserIdentityInfo CreateUserIdentityInfo()
    {
        var userIdentityInfoResult = new Humidifier.Connect.UserTypes.UserIdentityInfo();

        return userIdentityInfoResult;
    }

} // End Of Class

public static class InnerUserUserIdentityInfoFactoryExtensions
{
}
