// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class UserHierarchyStructureFactory(string resourceName = null, Action<Humidifier.Connect.UserHierarchyStructure> factoryAction = null) : ResourceFactory<Humidifier.Connect.UserHierarchyStructure>(resourceName)
{

    internal InnerUserHierarchyStructureUserHierarchyStructureFactory UserHierarchyStructure_Factory { get; set; }

    protected override Humidifier.Connect.UserHierarchyStructure Create()
    {
        var userHierarchyStructureResult = CreateUserHierarchyStructure();
        factoryAction?.Invoke(userHierarchyStructureResult);

        return userHierarchyStructureResult;
    }

    private Humidifier.Connect.UserHierarchyStructure CreateUserHierarchyStructure()
    {
        var userHierarchyStructureResult = new Humidifier.Connect.UserHierarchyStructure
        {
            GivenName = InputResourceName,
        };

        return userHierarchyStructureResult;
    }
    public override void CreateChildren(Humidifier.Connect.UserHierarchyStructure result)
    {
        base.CreateChildren(result);

        result.UserHierarchyStructure_ ??= UserHierarchyStructure_Factory?.Build();
    }

} // End Of Class

public static class UserHierarchyStructureFactoryExtensions
{
    public static CombinedResult<UserHierarchyStructureFactory, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_(this UserHierarchyStructureFactory parentFactory, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null)
    {
        parentFactory.UserHierarchyStructure_Factory = new InnerUserHierarchyStructureUserHierarchyStructureFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UserHierarchyStructure_Factory);
    }

    public static CombinedResult<UserHierarchyStructureFactory, T1, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1>(this CombinedResult<UserHierarchyStructureFactory, T1> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserHierarchyStructureFactory, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1>(this CombinedResult<T1, UserHierarchyStructureFactory> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserHierarchyStructureFactory, T1, T2, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2>(this CombinedResult<UserHierarchyStructureFactory, T1, T2> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserHierarchyStructureFactory, T2, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2>(this CombinedResult<T1, UserHierarchyStructureFactory, T2> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserHierarchyStructureFactory, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2>(this CombinedResult<T1, T2, UserHierarchyStructureFactory> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserHierarchyStructureFactory, T1, T2, T3, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3>(this CombinedResult<UserHierarchyStructureFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserHierarchyStructureFactory, T2, T3, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3>(this CombinedResult<T1, UserHierarchyStructureFactory, T2, T3> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserHierarchyStructureFactory, T3, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3>(this CombinedResult<T1, T2, UserHierarchyStructureFactory, T3> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserHierarchyStructureFactory, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserHierarchyStructureFactory> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserHierarchyStructureFactory, T1, T2, T3, T4, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3, T4>(this CombinedResult<UserHierarchyStructureFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserHierarchyStructureFactory, T2, T3, T4, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3, T4>(this CombinedResult<T1, UserHierarchyStructureFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserHierarchyStructureFactory, T3, T4, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserHierarchyStructureFactory, T3, T4> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserHierarchyStructureFactory, T4, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserHierarchyStructureFactory, T4> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserHierarchyStructureFactory, InnerUserHierarchyStructureUserHierarchyStructureFactory> WithUserHierarchyStructure_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserHierarchyStructureFactory> combinedResult, Action<Humidifier.Connect.UserHierarchyStructureTypes.UserHierarchyStructure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserHierarchyStructure_(combinedResult.T5, subFactoryAction));
}
