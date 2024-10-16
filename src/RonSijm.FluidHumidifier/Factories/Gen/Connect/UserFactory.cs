// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class UserFactory(string resourceName = null, Action<Humidifier.Connect.User> factoryAction = null) : ResourceFactory<Humidifier.Connect.User>(resourceName)
{

    internal List<InnerUserUserProficiencyFactory> UserProficienciesFactories { get; set; } = [];

    internal InnerUserUserPhoneConfigFactory PhoneConfigFactory { get; set; }

    internal InnerUserUserIdentityInfoFactory IdentityInfoFactory { get; set; }

    protected override Humidifier.Connect.User Create()
    {
        var userResult = CreateUser();
        factoryAction?.Invoke(userResult);

        return userResult;
    }

    private Humidifier.Connect.User CreateUser()
    {
        var userResult = new Humidifier.Connect.User
        {
            GivenName = InputResourceName,
        };

        return userResult;
    }
    public override void CreateChildren(Humidifier.Connect.User result)
    {
        base.CreateChildren(result);

        result.UserProficiencies = UserProficienciesFactories.Any() ? UserProficienciesFactories.Select(x => x.Build()).ToList() : null;
        result.PhoneConfig ??= PhoneConfigFactory?.Build();
        result.IdentityInfo ??= IdentityInfoFactory?.Build();
    }

} // End Of Class

public static class UserFactoryExtensions
{
    public static CombinedResult<UserFactory, InnerUserUserProficiencyFactory> WithUserProficiencies(this UserFactory parentFactory, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null)
    {
        var factory = new InnerUserUserProficiencyFactory(subFactoryAction);
        parentFactory.UserProficienciesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<UserFactory, InnerUserUserPhoneConfigFactory> WithPhoneConfig(this UserFactory parentFactory, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null)
    {
        parentFactory.PhoneConfigFactory = new InnerUserUserPhoneConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PhoneConfigFactory);
    }

    public static CombinedResult<UserFactory, InnerUserUserIdentityInfoFactory> WithIdentityInfo(this UserFactory parentFactory, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null)
    {
        parentFactory.IdentityInfoFactory = new InnerUserUserIdentityInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityInfoFactory);
    }

    public static CombinedResult<UserFactory, T1, InnerUserUserProficiencyFactory> WithUserProficiencies<T1>(this CombinedResult<UserFactory, T1> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserProficiencies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, InnerUserUserProficiencyFactory> WithUserProficiencies<T1>(this CombinedResult<T1, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserProficiencies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2>(this CombinedResult<UserFactory, T1, T2> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2>(this CombinedResult<T1, UserFactory, T2> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2>(this CombinedResult<T1, T2, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3>(this CombinedResult<UserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3>(this CombinedResult<T1, UserFactory, T2, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3>(this CombinedResult<T1, T2, UserFactory, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, T4, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3, T4>(this CombinedResult<UserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, T4, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3, T4>(this CombinedResult<T1, UserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, T4, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserFactory, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, T4, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserFactory, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserFactory, InnerUserUserProficiencyFactory> WithUserProficiencies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserProficiency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserProficiencies(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UserFactory, T1, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1>(this CombinedResult<UserFactory, T1> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPhoneConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1>(this CombinedResult<T1, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPhoneConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2>(this CombinedResult<UserFactory, T1, T2> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2>(this CombinedResult<T1, UserFactory, T2> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2>(this CombinedResult<T1, T2, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3>(this CombinedResult<UserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3>(this CombinedResult<T1, UserFactory, T2, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3>(this CombinedResult<T1, T2, UserFactory, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, T4, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3, T4>(this CombinedResult<UserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, T4, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3, T4>(this CombinedResult<T1, UserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, T4, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserFactory, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, T4, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserFactory, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserFactory, InnerUserUserPhoneConfigFactory> WithPhoneConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserPhoneConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhoneConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UserFactory, T1, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1>(this CombinedResult<UserFactory, T1> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1>(this CombinedResult<T1, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2>(this CombinedResult<UserFactory, T1, T2> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2>(this CombinedResult<T1, UserFactory, T2> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2>(this CombinedResult<T1, T2, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3>(this CombinedResult<UserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3>(this CombinedResult<T1, UserFactory, T2, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3>(this CombinedResult<T1, T2, UserFactory, T3> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, T4, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3, T4>(this CombinedResult<UserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, T4, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3, T4>(this CombinedResult<T1, UserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, T4, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserFactory, T3, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, T4, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserFactory, T4> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserFactory, InnerUserUserIdentityInfoFactory> WithIdentityInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserFactory> combinedResult, Action<Humidifier.Connect.UserTypes.UserIdentityInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityInfo(combinedResult.T5, subFactoryAction));
}
