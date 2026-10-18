// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class ProfileFactory(string resourceName = null, Action<Humidifier.WellArchitected.Profile> factoryAction = null) : ResourceFactory<Humidifier.WellArchitected.Profile>(resourceName)
{

    internal List<InnerProfileProfileQuestionUpdateFactory> ProfileQuestionsFactories { get; set; } = [];

    protected override Humidifier.WellArchitected.Profile Create()
    {
        var profileResult = CreateProfile();
        factoryAction?.Invoke(profileResult);

        return profileResult;
    }

    private Humidifier.WellArchitected.Profile CreateProfile()
    {
        var profileResult = new Humidifier.WellArchitected.Profile
        {
            GivenName = InputResourceName,
        };

        return profileResult;
    }
    public override void CreateChildren(Humidifier.WellArchitected.Profile result)
    {
        base.CreateChildren(result);

        result.ProfileQuestions = ProfileQuestionsFactories.Any() ? ProfileQuestionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ProfileFactoryExtensions
{
    public static CombinedResult<ProfileFactory, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions(this ProfileFactory parentFactory, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null)
    {
        var factory = new InnerProfileProfileQuestionUpdateFactory(subFactoryAction);
        parentFactory.ProfileQuestionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProfileFactory, T1, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1>(this CombinedResult<ProfileFactory, T1> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, WithProfileQuestions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProfileFactory, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1>(this CombinedResult<T1, ProfileFactory> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, WithProfileQuestions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProfileFactory, T1, T2, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2>(this CombinedResult<ProfileFactory, T1, T2> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProfileFactory, T2, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2>(this CombinedResult<T1, ProfileFactory, T2> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProfileFactory, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2>(this CombinedResult<T1, T2, ProfileFactory> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProfileFactory, T1, T2, T3, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3>(this CombinedResult<ProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProfileFactory, T2, T3, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3>(this CombinedResult<T1, ProfileFactory, T2, T3> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProfileFactory, T3, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3>(this CombinedResult<T1, T2, ProfileFactory, T3> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProfileFactory, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProfileFactory> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProfileFactory, T1, T2, T3, T4, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3, T4>(this CombinedResult<ProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProfileFactory, T2, T3, T4, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3, T4>(this CombinedResult<T1, ProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProfileFactory, T3, T4, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProfileFactory, T3, T4> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProfileFactory, T4, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProfileFactory, T4> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProfileFactory, InnerProfileProfileQuestionUpdateFactory> WithProfileQuestions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProfileFactory> combinedResult, Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProfileQuestions(combinedResult.T5, subFactoryAction).T2);
}
