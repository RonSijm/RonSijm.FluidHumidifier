// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class UserFactory(string resourceName = null, Action<Humidifier.Transfer.User> factoryAction = null) : ResourceFactory<Humidifier.Transfer.User>(resourceName)
{

    internal List<InnerUserHomeDirectoryMapEntryFactory> HomeDirectoryMappingsFactories { get; set; } = [];

    internal InnerUserPosixProfileFactory PosixProfileFactory { get; set; }

    protected override Humidifier.Transfer.User Create()
    {
        var userResult = CreateUser();
        factoryAction?.Invoke(userResult);

        return userResult;
    }

    private Humidifier.Transfer.User CreateUser()
    {
        var userResult = new Humidifier.Transfer.User
        {
            GivenName = InputResourceName,
        };

        return userResult;
    }
    public override void CreateChildren(Humidifier.Transfer.User result)
    {
        base.CreateChildren(result);

        result.HomeDirectoryMappings = HomeDirectoryMappingsFactories.Any() ? HomeDirectoryMappingsFactories.Select(x => x.Build()).ToList() : null;
        result.PosixProfile ??= PosixProfileFactory?.Build();
    }

} // End Of Class

public static class UserFactoryExtensions
{
    public static CombinedResult<UserFactory, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings(this UserFactory parentFactory, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null)
    {
        var factory = new InnerUserHomeDirectoryMapEntryFactory(subFactoryAction);
        parentFactory.HomeDirectoryMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<UserFactory, InnerUserPosixProfileFactory> WithPosixProfile(this UserFactory parentFactory, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null)
    {
        parentFactory.PosixProfileFactory = new InnerUserPosixProfileFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PosixProfileFactory);
    }

    public static CombinedResult<UserFactory, T1, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1>(this CombinedResult<UserFactory, T1> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1>(this CombinedResult<T1, UserFactory> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2>(this CombinedResult<UserFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2>(this CombinedResult<T1, UserFactory, T2> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2>(this CombinedResult<T1, T2, UserFactory> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3>(this CombinedResult<UserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3>(this CombinedResult<T1, UserFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3>(this CombinedResult<T1, T2, UserFactory, T3> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserFactory> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, T4, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3, T4>(this CombinedResult<UserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, T4, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3, T4>(this CombinedResult<T1, UserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, T4, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, T4, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserFactory, T4> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserFactory, InnerUserHomeDirectoryMapEntryFactory> WithHomeDirectoryMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserFactory> combinedResult, Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHomeDirectoryMappings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UserFactory, T1, InnerUserPosixProfileFactory> WithPosixProfile<T1>(this CombinedResult<UserFactory, T1> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosixProfile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, InnerUserPosixProfileFactory> WithPosixProfile<T1>(this CombinedResult<T1, UserFactory> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosixProfile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2>(this CombinedResult<UserFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2>(this CombinedResult<T1, UserFactory, T2> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2>(this CombinedResult<T1, T2, UserFactory> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3>(this CombinedResult<UserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3>(this CombinedResult<T1, UserFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3>(this CombinedResult<T1, T2, UserFactory, T3> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserFactory> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, T4, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3, T4>(this CombinedResult<UserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, T4, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3, T4>(this CombinedResult<T1, UserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, T4, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, T4, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserFactory, T4> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserFactory, InnerUserPosixProfileFactory> WithPosixProfile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserFactory> combinedResult, Action<Humidifier.Transfer.UserTypes.PosixProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosixProfile(combinedResult.T5, subFactoryAction));
}
