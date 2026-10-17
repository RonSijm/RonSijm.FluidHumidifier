// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipProtectedJobOutputConfigurationFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration>
{

    internal InnerMembershipProtectedJobS3OutputConfigurationInputFactory S3Factory { get; set; }

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration Create()
    {
        var membershipProtectedJobOutputConfigurationResult = CreateMembershipProtectedJobOutputConfiguration();
        factoryAction?.Invoke(membershipProtectedJobOutputConfigurationResult);

        return membershipProtectedJobOutputConfigurationResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration CreateMembershipProtectedJobOutputConfiguration()
    {
        var membershipProtectedJobOutputConfigurationResult = new Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration();

        return membershipProtectedJobOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerMembershipMembershipProtectedJobOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3(this InnerMembershipMembershipProtectedJobOutputConfigurationFactory parentFactory, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerMembershipProtectedJobS3OutputConfigurationInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T1, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1>(this CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1>(this CombinedResult<T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T1, T2, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2>(this CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T2, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T1, T2, T3, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T2, T3, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T3, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T1, T2, T3, T4, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T2, T3, T4, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T3, T4, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T4, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipProtectedJobOutputConfigurationFactory, InnerMembershipProtectedJobS3OutputConfigurationInputFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
