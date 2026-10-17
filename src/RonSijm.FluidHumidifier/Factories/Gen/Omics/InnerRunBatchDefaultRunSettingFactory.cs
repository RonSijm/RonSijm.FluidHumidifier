// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerRunBatchDefaultRunSettingFactory(Action<Humidifier.Omics.RunBatchTypes.DefaultRunSetting> factoryAction = null) : SubResourceFactory<Humidifier.Omics.RunBatchTypes.DefaultRunSetting>
{

    protected override Humidifier.Omics.RunBatchTypes.DefaultRunSetting Create()
    {
        var defaultRunSettingResult = CreateDefaultRunSetting();
        factoryAction?.Invoke(defaultRunSettingResult);

        return defaultRunSettingResult;
    }

    private Humidifier.Omics.RunBatchTypes.DefaultRunSetting CreateDefaultRunSetting()
    {
        var defaultRunSettingResult = new Humidifier.Omics.RunBatchTypes.DefaultRunSetting();

        return defaultRunSettingResult;
    }

} // End Of Class

public static class InnerRunBatchDefaultRunSettingFactoryExtensions
{
}
