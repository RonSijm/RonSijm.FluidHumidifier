// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class PrivacyBudgetTemplateFactory(string resourceName = null, Action<Humidifier.CleanRooms.PrivacyBudgetTemplate> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.PrivacyBudgetTemplate>(resourceName)
{

    internal InnerPrivacyBudgetTemplateParametersFactory ParametersFactory { get; set; }

    protected override Humidifier.CleanRooms.PrivacyBudgetTemplate Create()
    {
        var privacyBudgetTemplateResult = CreatePrivacyBudgetTemplate();
        factoryAction?.Invoke(privacyBudgetTemplateResult);

        return privacyBudgetTemplateResult;
    }

    private Humidifier.CleanRooms.PrivacyBudgetTemplate CreatePrivacyBudgetTemplate()
    {
        var privacyBudgetTemplateResult = new Humidifier.CleanRooms.PrivacyBudgetTemplate
        {
            GivenName = InputResourceName,
        };

        return privacyBudgetTemplateResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.PrivacyBudgetTemplate result)
    {
        base.CreateChildren(result);

        result.Parameters ??= ParametersFactory?.Build();
    }

} // End Of Class

public static class PrivacyBudgetTemplateFactoryExtensions
{
    public static CombinedResult<PrivacyBudgetTemplateFactory, InnerPrivacyBudgetTemplateParametersFactory> WithParameters(this PrivacyBudgetTemplateFactory parentFactory, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null)
    {
        parentFactory.ParametersFactory = new InnerPrivacyBudgetTemplateParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParametersFactory);
    }

    public static CombinedResult<PrivacyBudgetTemplateFactory, T1, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1>(this CombinedResult<PrivacyBudgetTemplateFactory, T1> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrivacyBudgetTemplateFactory, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1>(this CombinedResult<T1, PrivacyBudgetTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PrivacyBudgetTemplateFactory, T1, T2, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2>(this CombinedResult<PrivacyBudgetTemplateFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrivacyBudgetTemplateFactory, T2, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, PrivacyBudgetTemplateFactory, T2> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrivacyBudgetTemplateFactory, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, PrivacyBudgetTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PrivacyBudgetTemplateFactory, T1, T2, T3, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<PrivacyBudgetTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrivacyBudgetTemplateFactory, T2, T3, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, PrivacyBudgetTemplateFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrivacyBudgetTemplateFactory, T3, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, PrivacyBudgetTemplateFactory, T3> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrivacyBudgetTemplateFactory, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, PrivacyBudgetTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PrivacyBudgetTemplateFactory, T1, T2, T3, T4, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<PrivacyBudgetTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrivacyBudgetTemplateFactory, T2, T3, T4, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, PrivacyBudgetTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrivacyBudgetTemplateFactory, T3, T4, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, PrivacyBudgetTemplateFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrivacyBudgetTemplateFactory, T4, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PrivacyBudgetTemplateFactory, T4> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PrivacyBudgetTemplateFactory, InnerPrivacyBudgetTemplateParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PrivacyBudgetTemplateFactory> combinedResult, Action<Humidifier.CleanRooms.PrivacyBudgetTemplateTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction));
}
