// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class CustomPermissionsFactory(string resourceName = null, Action<Humidifier.QuickSight.CustomPermissions> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.CustomPermissions>(resourceName)
{

    internal InnerCustomPermissionsCapabilitiesFactory CapabilitiesFactory { get; set; }

    protected override Humidifier.QuickSight.CustomPermissions Create()
    {
        var customPermissionsResult = CreateCustomPermissions();
        factoryAction?.Invoke(customPermissionsResult);

        return customPermissionsResult;
    }

    private Humidifier.QuickSight.CustomPermissions CreateCustomPermissions()
    {
        var customPermissionsResult = new Humidifier.QuickSight.CustomPermissions
        {
            GivenName = InputResourceName,
        };

        return customPermissionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.CustomPermissions result)
    {
        base.CreateChildren(result);

        result.Capabilities ??= CapabilitiesFactory?.Build();
    }

} // End Of Class

public static class CustomPermissionsFactoryExtensions
{
    public static CombinedResult<CustomPermissionsFactory, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities(this CustomPermissionsFactory parentFactory, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null)
    {
        parentFactory.CapabilitiesFactory = new InnerCustomPermissionsCapabilitiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapabilitiesFactory);
    }

    public static CombinedResult<CustomPermissionsFactory, T1, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1>(this CombinedResult<CustomPermissionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomPermissionsFactory, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1>(this CombinedResult<T1, CustomPermissionsFactory> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CustomPermissionsFactory, T1, T2, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<CustomPermissionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomPermissionsFactory, T2, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<T1, CustomPermissionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomPermissionsFactory, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<T1, T2, CustomPermissionsFactory> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CustomPermissionsFactory, T1, T2, T3, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<CustomPermissionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomPermissionsFactory, T2, T3, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, CustomPermissionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomPermissionsFactory, T3, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, CustomPermissionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomPermissionsFactory, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, T3, CustomPermissionsFactory> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CustomPermissionsFactory, T1, T2, T3, T4, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<CustomPermissionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomPermissionsFactory, T2, T3, T4, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, CustomPermissionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomPermissionsFactory, T3, T4, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, CustomPermissionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomPermissionsFactory, T4, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CustomPermissionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CustomPermissionsFactory, InnerCustomPermissionsCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CustomPermissionsFactory> combinedResult, Action<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T5, subFactoryAction));
}
