// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class UserProfileFactory(string resourceName = null, Action<Humidifier.SageMaker.UserProfile> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.UserProfile>(resourceName)
{

    internal InnerUserProfileUserSettingsFactory UserSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.UserProfile Create()
    {
        var userProfileResult = CreateUserProfile();
        factoryAction?.Invoke(userProfileResult);

        return userProfileResult;
    }

    private Humidifier.SageMaker.UserProfile CreateUserProfile()
    {
        var userProfileResult = new Humidifier.SageMaker.UserProfile
        {
            GivenName = InputResourceName,
        };

        return userProfileResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.UserProfile result)
    {
        base.CreateChildren(result);

        result.UserSettings ??= UserSettingsFactory?.Build();
    }

} // End Of Class

public static class UserProfileFactoryExtensions
{
    public static CombinedResult<UserProfileFactory, InnerUserProfileUserSettingsFactory> WithUserSettings(this UserProfileFactory parentFactory, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null)
    {
        parentFactory.UserSettingsFactory = new InnerUserProfileUserSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UserSettingsFactory);
    }

    public static CombinedResult<UserProfileFactory, T1, InnerUserProfileUserSettingsFactory> WithUserSettings<T1>(this CombinedResult<UserProfileFactory, T1> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserProfileFactory, InnerUserProfileUserSettingsFactory> WithUserSettings<T1>(this CombinedResult<T1, UserProfileFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserProfileFactory, T1, T2, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2>(this CombinedResult<UserProfileFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserProfileFactory, T2, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2>(this CombinedResult<T1, UserProfileFactory, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserProfileFactory, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2>(this CombinedResult<T1, T2, UserProfileFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserProfileFactory, T1, T2, T3, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3>(this CombinedResult<UserProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserProfileFactory, T2, T3, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3>(this CombinedResult<T1, UserProfileFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserProfileFactory, T3, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3>(this CombinedResult<T1, T2, UserProfileFactory, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserProfileFactory, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserProfileFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserProfileFactory, T1, T2, T3, T4, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3, T4>(this CombinedResult<UserProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserProfileFactory, T2, T3, T4, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3, T4>(this CombinedResult<T1, UserProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserProfileFactory, T3, T4, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserProfileFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserProfileFactory, T4, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserProfileFactory, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserProfileFactory, InnerUserProfileUserSettingsFactory> WithUserSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserProfileFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.UserSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserSettings(combinedResult.T5, subFactoryAction));
}
