// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDLPSettingMicrosoftPurviewCredentialsFactory(Action<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials>
{

    protected override Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials Create()
    {
        var microsoftPurviewCredentialsResult = CreateMicrosoftPurviewCredentials();
        factoryAction?.Invoke(microsoftPurviewCredentialsResult);

        return microsoftPurviewCredentialsResult;
    }

    private Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials CreateMicrosoftPurviewCredentials()
    {
        var microsoftPurviewCredentialsResult = new Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials();

        return microsoftPurviewCredentialsResult;
    }

} // End Of Class

public static class InnerDLPSettingMicrosoftPurviewCredentialsFactoryExtensions
{
}
