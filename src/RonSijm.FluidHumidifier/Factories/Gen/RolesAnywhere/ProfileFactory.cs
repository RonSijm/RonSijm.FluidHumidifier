// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RolesAnywhere;

public class ProfileFactory(string resourceName = null, Action<Humidifier.RolesAnywhere.Profile> factoryAction = null) : ResourceFactory<Humidifier.RolesAnywhere.Profile>(resourceName)
{

    internal List<InnerProfileAttributeMappingFactory> AttributeMappingsFactories { get; set; } = [];

    protected override Humidifier.RolesAnywhere.Profile Create()
    {
        var profileResult = CreateProfile();
        factoryAction?.Invoke(profileResult);

        return profileResult;
    }

    private Humidifier.RolesAnywhere.Profile CreateProfile()
    {
        var profileResult = new Humidifier.RolesAnywhere.Profile
        {
            GivenName = InputResourceName,
        };

        return profileResult;
    }
    public override void CreateChildren(Humidifier.RolesAnywhere.Profile result)
    {
        base.CreateChildren(result);

        result.AttributeMappings = AttributeMappingsFactories.Any() ? AttributeMappingsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ProfileFactoryExtensions
{
    public static CombinedResult<ProfileFactory, InnerProfileAttributeMappingFactory> WithAttributeMappings(this ProfileFactory parentFactory, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null)
    {
        var factory = new InnerProfileAttributeMappingFactory(subFactoryAction);
        parentFactory.AttributeMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProfileFactory, T1, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1>(this CombinedResult<ProfileFactory, T1> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributeMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfileFactory, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1>(this CombinedResult<T1, ProfileFactory> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributeMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProfileFactory, T1, T2, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2>(this CombinedResult<ProfileFactory, T1, T2> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfileFactory, T2, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2>(this CombinedResult<T1, ProfileFactory, T2> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfileFactory, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2>(this CombinedResult<T1, T2, ProfileFactory> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProfileFactory, T1, T2, T3, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3>(this CombinedResult<ProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfileFactory, T2, T3, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3>(this CombinedResult<T1, ProfileFactory, T2, T3> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfileFactory, T3, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3>(this CombinedResult<T1, T2, ProfileFactory, T3> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProfileFactory, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProfileFactory> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProfileFactory, T1, T2, T3, T4, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3, T4>(this CombinedResult<ProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfileFactory, T2, T3, T4, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3, T4>(this CombinedResult<T1, ProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfileFactory, T3, T4, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProfileFactory, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProfileFactory, T4, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProfileFactory, T4> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProfileFactory, InnerProfileAttributeMappingFactory> WithAttributeMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProfileFactory> combinedResult, Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributeMappings(combinedResult.T5, subFactoryAction));
}
