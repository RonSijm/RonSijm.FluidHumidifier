// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserUserProficiencyFactory(Action<Humidifier.Connect.UserTypes.UserProficiency> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserTypes.UserProficiency>
{

    protected override Humidifier.Connect.UserTypes.UserProficiency Create()
    {
        var userProficiencyResult = CreateUserProficiency();
        factoryAction?.Invoke(userProficiencyResult);

        return userProficiencyResult;
    }

    private Humidifier.Connect.UserTypes.UserProficiency CreateUserProficiency()
    {
        var userProficiencyResult = new Humidifier.Connect.UserTypes.UserProficiency();

        return userProficiencyResult;
    }

} // End Of Class

public static class InnerUserUserProficiencyFactoryExtensions
{
}
