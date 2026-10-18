// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerStackUserSettingFactory(Action<Humidifier.AppStream.StackTypes.UserSetting> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.StackTypes.UserSetting>
{

    protected override Humidifier.AppStream.StackTypes.UserSetting Create()
    {
        var userSettingResult = CreateUserSetting();
        factoryAction?.Invoke(userSettingResult);

        return userSettingResult;
    }

    private Humidifier.AppStream.StackTypes.UserSetting CreateUserSetting()
    {
        var userSettingResult = new Humidifier.AppStream.StackTypes.UserSetting();

        return userSettingResult;
    }

} // End Of Class

public static class InnerStackUserSettingFactoryExtensions
{
}
