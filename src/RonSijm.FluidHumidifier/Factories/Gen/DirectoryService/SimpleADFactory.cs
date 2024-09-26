// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectoryService;

public class SimpleADFactory(string resourceName = null, Action<Humidifier.DirectoryService.SimpleAD> factoryAction = null) : ResourceFactory<Humidifier.DirectoryService.SimpleAD>(resourceName)
{

    internal InnerSimpleADVpcSettingsFactory VpcSettingsFactory { get; set; }

    protected override Humidifier.DirectoryService.SimpleAD Create()
    {
        var simpleADResult = CreateSimpleAD();
        factoryAction?.Invoke(simpleADResult);

        return simpleADResult;
    }

    private Humidifier.DirectoryService.SimpleAD CreateSimpleAD()
    {
        var simpleADResult = new Humidifier.DirectoryService.SimpleAD
        {
            GivenName = InputResourceName,
        };

        return simpleADResult;
    }
    public override void CreateChildren(Humidifier.DirectoryService.SimpleAD result)
    {
        base.CreateChildren(result);

        result.VpcSettings ??= VpcSettingsFactory?.Build();
    }

} // End Of Class

public static class SimpleADFactoryExtensions
{
    public static CombinedResult<SimpleADFactory, InnerSimpleADVpcSettingsFactory> WithVpcSettings(this SimpleADFactory parentFactory, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null)
    {
        parentFactory.VpcSettingsFactory = new InnerSimpleADVpcSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcSettingsFactory);
    }

    public static CombinedResult<SimpleADFactory, T1, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1>(this CombinedResult<SimpleADFactory, T1> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimpleADFactory, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1>(this CombinedResult<T1, SimpleADFactory> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SimpleADFactory, T1, T2, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2>(this CombinedResult<SimpleADFactory, T1, T2> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimpleADFactory, T2, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2>(this CombinedResult<T1, SimpleADFactory, T2> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimpleADFactory, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2>(this CombinedResult<T1, T2, SimpleADFactory> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SimpleADFactory, T1, T2, T3, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3>(this CombinedResult<SimpleADFactory, T1, T2, T3> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimpleADFactory, T2, T3, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3>(this CombinedResult<T1, SimpleADFactory, T2, T3> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimpleADFactory, T3, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3>(this CombinedResult<T1, T2, SimpleADFactory, T3> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SimpleADFactory, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, SimpleADFactory> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SimpleADFactory, T1, T2, T3, T4, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<SimpleADFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SimpleADFactory, T2, T3, T4, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<T1, SimpleADFactory, T2, T3, T4> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SimpleADFactory, T3, T4, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, SimpleADFactory, T3, T4> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SimpleADFactory, T4, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SimpleADFactory, T4> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SimpleADFactory, InnerSimpleADVpcSettingsFactory> WithVpcSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SimpleADFactory> combinedResult, Action<Humidifier.DirectoryService.SimpleADTypes.VpcSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcSettings(combinedResult.T5, subFactoryAction));
}
