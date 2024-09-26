// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerDomainSubDomainSettingFactory(Action<Humidifier.Amplify.DomainTypes.SubDomainSetting> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.DomainTypes.SubDomainSetting>
{

    protected override Humidifier.Amplify.DomainTypes.SubDomainSetting Create()
    {
        var subDomainSettingResult = CreateSubDomainSetting();
        factoryAction?.Invoke(subDomainSettingResult);

        return subDomainSettingResult;
    }

    private Humidifier.Amplify.DomainTypes.SubDomainSetting CreateSubDomainSetting()
    {
        var subDomainSettingResult = new Humidifier.Amplify.DomainTypes.SubDomainSetting();

        return subDomainSettingResult;
    }

} // End Of Class

public static class InnerDomainSubDomainSettingFactoryExtensions
{
}
