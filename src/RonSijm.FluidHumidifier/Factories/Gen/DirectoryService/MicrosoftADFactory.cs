// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectoryService;

public class MicrosoftADFactory(string resourceName = null, Action<Humidifier.DirectoryService.MicrosoftAD> factoryAction = null) : ResourceFactory<Humidifier.DirectoryService.MicrosoftAD>(resourceName)
{

    internal InnerMicrosoftADVpcSettingsFactory VpcSettingsFactory { get; set; }

    protected override Humidifier.DirectoryService.MicrosoftAD Create()
    {
        var microsoftADResult = CreateMicrosoftAD();
        factoryAction?.Invoke(microsoftADResult);

        return microsoftADResult;
    }

    private Humidifier.DirectoryService.MicrosoftAD CreateMicrosoftAD()
    {
        var microsoftADResult = new Humidifier.DirectoryService.MicrosoftAD
        {
            GivenName = InputResourceName,
        };

        return microsoftADResult;
    }
    public override void CreateChildren(Humidifier.DirectoryService.MicrosoftAD result)
    {
        base.CreateChildren(result);

        result.VpcSettings ??= VpcSettingsFactory?.Build();
    }

} // End Of Class

public static class MicrosoftADFactoryExtensions
{
    public static CombinedResult<MicrosoftADFactory, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings(this MicrosoftADFactory parentFactory, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null)
    {
        parentFactory.VpcSettingsFactory = new InnerMicrosoftADVpcSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcSettingsFactory);
    }

    public static CombinedResult<MicrosoftADFactory, T1, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1>(this CombinedResult<MicrosoftADFactory, T1> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MicrosoftADFactory, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1>(this CombinedResult<T1, MicrosoftADFactory> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MicrosoftADFactory, T1, T2, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2>(this CombinedResult<MicrosoftADFactory, T1, T2> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MicrosoftADFactory, T2, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2>(this CombinedResult<T1, MicrosoftADFactory, T2> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MicrosoftADFactory, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2>(this CombinedResult<T1, T2, MicrosoftADFactory> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MicrosoftADFactory, T1, T2, T3, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3>(this CombinedResult<MicrosoftADFactory, T1, T2, T3> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MicrosoftADFactory, T2, T3, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3>(this CombinedResult<T1, MicrosoftADFactory, T2, T3> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MicrosoftADFactory, T3, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3>(this CombinedResult<T1, T2, MicrosoftADFactory, T3> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MicrosoftADFactory, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, MicrosoftADFactory> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MicrosoftADFactory, T1, T2, T3, T4, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<MicrosoftADFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MicrosoftADFactory, T2, T3, T4, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<T1, MicrosoftADFactory, T2, T3, T4> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MicrosoftADFactory, T3, T4, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, MicrosoftADFactory, T3, T4> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MicrosoftADFactory, T4, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MicrosoftADFactory, T4> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MicrosoftADFactory, InnerMicrosoftADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MicrosoftADFactory> combinedResult, Action<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T5, subFactoryAction));
}
