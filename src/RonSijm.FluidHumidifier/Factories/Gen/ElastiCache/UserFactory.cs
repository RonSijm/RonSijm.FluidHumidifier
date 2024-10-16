// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class UserFactory(string resourceName = null, Action<Humidifier.ElastiCache.User> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.User>(resourceName)
{

    internal InnerUserAuthenticationModeFactory AuthenticationModeFactory { get; set; }

    protected override Humidifier.ElastiCache.User Create()
    {
        var userResult = CreateUser();
        factoryAction?.Invoke(userResult);

        return userResult;
    }

    private Humidifier.ElastiCache.User CreateUser()
    {
        var userResult = new Humidifier.ElastiCache.User
        {
            GivenName = InputResourceName,
        };

        return userResult;
    }
    public override void CreateChildren(Humidifier.ElastiCache.User result)
    {
        base.CreateChildren(result);

        result.AuthenticationMode ??= AuthenticationModeFactory?.Build();
    }

} // End Of Class

public static class UserFactoryExtensions
{
    public static CombinedResult<UserFactory, InnerUserAuthenticationModeFactory> WithAuthenticationMode(this UserFactory parentFactory, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null)
    {
        parentFactory.AuthenticationModeFactory = new InnerUserAuthenticationModeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthenticationModeFactory);
    }

    public static CombinedResult<UserFactory, T1, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1>(this CombinedResult<UserFactory, T1> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1>(this CombinedResult<T1, UserFactory> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2>(this CombinedResult<UserFactory, T1, T2> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2>(this CombinedResult<T1, UserFactory, T2> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2>(this CombinedResult<T1, T2, UserFactory> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3>(this CombinedResult<UserFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3>(this CombinedResult<T1, UserFactory, T2, T3> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3>(this CombinedResult<T1, T2, UserFactory, T3> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserFactory> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, T4, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3, T4>(this CombinedResult<UserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, T4, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3, T4>(this CombinedResult<T1, UserFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, T4, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserFactory, T3, T4> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, T4, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserFactory, T4> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserFactory, InnerUserAuthenticationModeFactory> WithAuthenticationMode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserFactory> combinedResult, Action<Humidifier.ElastiCache.UserTypes.AuthenticationMode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationMode(combinedResult.T5, subFactoryAction));
}
