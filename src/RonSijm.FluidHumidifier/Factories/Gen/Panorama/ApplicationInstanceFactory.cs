// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Panorama;

public class ApplicationInstanceFactory(string resourceName = null, Action<Humidifier.Panorama.ApplicationInstance> factoryAction = null) : ResourceFactory<Humidifier.Panorama.ApplicationInstance>(resourceName)
{

    internal InnerApplicationInstanceManifestOverridesPayloadFactory ManifestOverridesPayloadFactory { get; set; }

    internal InnerApplicationInstanceManifestPayloadFactory ManifestPayloadFactory { get; set; }

    protected override Humidifier.Panorama.ApplicationInstance Create()
    {
        var applicationInstanceResult = CreateApplicationInstance();
        factoryAction?.Invoke(applicationInstanceResult);

        return applicationInstanceResult;
    }

    private Humidifier.Panorama.ApplicationInstance CreateApplicationInstance()
    {
        var applicationInstanceResult = new Humidifier.Panorama.ApplicationInstance
        {
            GivenName = InputResourceName,
        };

        return applicationInstanceResult;
    }
    public override void CreateChildren(Humidifier.Panorama.ApplicationInstance result)
    {
        base.CreateChildren(result);

        result.ManifestOverridesPayload ??= ManifestOverridesPayloadFactory?.Build();
        result.ManifestPayload ??= ManifestPayloadFactory?.Build();
    }

} // End Of Class

public static class ApplicationInstanceFactoryExtensions
{
    public static CombinedResult<ApplicationInstanceFactory, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload(this ApplicationInstanceFactory parentFactory, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null)
    {
        parentFactory.ManifestOverridesPayloadFactory = new InnerApplicationInstanceManifestOverridesPayloadFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManifestOverridesPayloadFactory);
    }

    public static CombinedResult<ApplicationInstanceFactory, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload(this ApplicationInstanceFactory parentFactory, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null)
    {
        parentFactory.ManifestPayloadFactory = new InnerApplicationInstanceManifestPayloadFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManifestPayloadFactory);
    }

    public static CombinedResult<ApplicationInstanceFactory, T1, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1>(this CombinedResult<ApplicationInstanceFactory, T1> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInstanceFactory, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1>(this CombinedResult<T1, ApplicationInstanceFactory> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationInstanceFactory, T1, T2, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2>(this CombinedResult<ApplicationInstanceFactory, T1, T2> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInstanceFactory, T2, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2>(this CombinedResult<T1, ApplicationInstanceFactory, T2> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInstanceFactory, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2>(this CombinedResult<T1, T2, ApplicationInstanceFactory> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationInstanceFactory, T1, T2, T3, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3>(this CombinedResult<ApplicationInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInstanceFactory, T2, T3, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3>(this CombinedResult<T1, ApplicationInstanceFactory, T2, T3> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInstanceFactory, T3, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationInstanceFactory, T3> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationInstanceFactory, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationInstanceFactory> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationInstanceFactory, T1, T2, T3, T4, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3, T4>(this CombinedResult<ApplicationInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInstanceFactory, T2, T3, T4, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInstanceFactory, T3, T4, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationInstanceFactory, T3, T4> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationInstanceFactory, T4, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationInstanceFactory, T4> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationInstanceFactory, InnerApplicationInstanceManifestOverridesPayloadFactory> WithManifestOverridesPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationInstanceFactory> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestOverridesPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOverridesPayload(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ApplicationInstanceFactory, T1, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1>(this CombinedResult<ApplicationInstanceFactory, T1> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInstanceFactory, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1>(this CombinedResult<T1, ApplicationInstanceFactory> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationInstanceFactory, T1, T2, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2>(this CombinedResult<ApplicationInstanceFactory, T1, T2> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInstanceFactory, T2, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2>(this CombinedResult<T1, ApplicationInstanceFactory, T2> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInstanceFactory, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2>(this CombinedResult<T1, T2, ApplicationInstanceFactory> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationInstanceFactory, T1, T2, T3, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3>(this CombinedResult<ApplicationInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInstanceFactory, T2, T3, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3>(this CombinedResult<T1, ApplicationInstanceFactory, T2, T3> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInstanceFactory, T3, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationInstanceFactory, T3> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationInstanceFactory, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationInstanceFactory> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationInstanceFactory, T1, T2, T3, T4, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3, T4>(this CombinedResult<ApplicationInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInstanceFactory, T2, T3, T4, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInstanceFactory, T3, T4, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationInstanceFactory, T3, T4> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationInstanceFactory, T4, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationInstanceFactory, T4> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationInstanceFactory, InnerApplicationInstanceManifestPayloadFactory> WithManifestPayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationInstanceFactory> combinedResult, Action<Humidifier.Panorama.ApplicationInstanceTypes.ManifestPayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestPayload(combinedResult.T5, subFactoryAction));
}
