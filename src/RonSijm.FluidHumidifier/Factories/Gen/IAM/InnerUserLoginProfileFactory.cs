// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class InnerUserLoginProfileFactory(Action<Humidifier.IAM.UserTypes.LoginProfile> factoryAction = null) : SubResourceFactory<Humidifier.IAM.UserTypes.LoginProfile>
{

    protected override Humidifier.IAM.UserTypes.LoginProfile Create()
    {
        var loginProfileResult = CreateLoginProfile();
        factoryAction?.Invoke(loginProfileResult);

        return loginProfileResult;
    }

    private Humidifier.IAM.UserTypes.LoginProfile CreateLoginProfile()
    {
        var loginProfileResult = new Humidifier.IAM.UserTypes.LoginProfile();

        return loginProfileResult;
    }

} // End Of Class

public static class InnerUserLoginProfileFactoryExtensions
{
}
