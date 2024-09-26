// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipProtectedQueryOutputConfigurationFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration>
{

    internal InnerMembershipProtectedQueryS3OutputConfigurationFactory S3Factory { get; set; }

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration Create()
    {
        var membershipProtectedQueryOutputConfigurationResult = CreateMembershipProtectedQueryOutputConfiguration();
        factoryAction?.Invoke(membershipProtectedQueryOutputConfigurationResult);

        return membershipProtectedQueryOutputConfigurationResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration CreateMembershipProtectedQueryOutputConfiguration()
    {
        var membershipProtectedQueryOutputConfigurationResult = new Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration();

        return membershipProtectedQueryOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerMembershipMembershipProtectedQueryOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3(this InnerMembershipMembershipProtectedQueryOutputConfigurationFactory parentFactory, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerMembershipProtectedQueryS3OutputConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T1, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1>(this CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1>(this CombinedResult<T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T1, T2, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2>(this CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T2, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T1, T2, T3, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T2, T3, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T3, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T1, T2, T3, T4, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T2, T3, T4, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T3, T4, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T4, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory, InnerMembershipProtectedQueryS3OutputConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
