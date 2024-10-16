// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class RotationScheduleFactory(string resourceName = null, Action<Humidifier.SecretsManager.RotationSchedule> factoryAction = null) : ResourceFactory<Humidifier.SecretsManager.RotationSchedule>(resourceName)
{

    internal InnerRotationScheduleHostedRotationLambdaFactory HostedRotationLambdaFactory { get; set; }

    internal InnerRotationScheduleRotationRulesFactory RotationRulesFactory { get; set; }

    protected override Humidifier.SecretsManager.RotationSchedule Create()
    {
        var rotationScheduleResult = CreateRotationSchedule();
        factoryAction?.Invoke(rotationScheduleResult);

        return rotationScheduleResult;
    }

    private Humidifier.SecretsManager.RotationSchedule CreateRotationSchedule()
    {
        var rotationScheduleResult = new Humidifier.SecretsManager.RotationSchedule
        {
            GivenName = InputResourceName,
        };

        return rotationScheduleResult;
    }
    public override void CreateChildren(Humidifier.SecretsManager.RotationSchedule result)
    {
        base.CreateChildren(result);

        result.HostedRotationLambda ??= HostedRotationLambdaFactory?.Build();
        result.RotationRules ??= RotationRulesFactory?.Build();
    }

} // End Of Class

public static class RotationScheduleFactoryExtensions
{
    public static CombinedResult<RotationScheduleFactory, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda(this RotationScheduleFactory parentFactory, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null)
    {
        parentFactory.HostedRotationLambdaFactory = new InnerRotationScheduleHostedRotationLambdaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HostedRotationLambdaFactory);
    }

    public static CombinedResult<RotationScheduleFactory, InnerRotationScheduleRotationRulesFactory> WithRotationRules(this RotationScheduleFactory parentFactory, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null)
    {
        parentFactory.RotationRulesFactory = new InnerRotationScheduleRotationRulesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RotationRulesFactory);
    }

    public static CombinedResult<RotationScheduleFactory, T1, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1>(this CombinedResult<RotationScheduleFactory, T1> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationScheduleFactory, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1>(this CombinedResult<T1, RotationScheduleFactory> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RotationScheduleFactory, T1, T2, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2>(this CombinedResult<RotationScheduleFactory, T1, T2> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationScheduleFactory, T2, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2>(this CombinedResult<T1, RotationScheduleFactory, T2> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationScheduleFactory, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2>(this CombinedResult<T1, T2, RotationScheduleFactory> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RotationScheduleFactory, T1, T2, T3, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3>(this CombinedResult<RotationScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationScheduleFactory, T2, T3, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3>(this CombinedResult<T1, RotationScheduleFactory, T2, T3> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationScheduleFactory, T3, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3>(this CombinedResult<T1, T2, RotationScheduleFactory, T3> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RotationScheduleFactory, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3>(this CombinedResult<T1, T2, T3, RotationScheduleFactory> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RotationScheduleFactory, T1, T2, T3, T4, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3, T4>(this CombinedResult<RotationScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationScheduleFactory, T2, T3, T4, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3, T4>(this CombinedResult<T1, RotationScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationScheduleFactory, T3, T4, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, RotationScheduleFactory, T3, T4> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RotationScheduleFactory, T4, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RotationScheduleFactory, T4> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RotationScheduleFactory, InnerRotationScheduleHostedRotationLambdaFactory> WithHostedRotationLambda<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RotationScheduleFactory> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.HostedRotationLambda> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostedRotationLambda(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RotationScheduleFactory, T1, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1>(this CombinedResult<RotationScheduleFactory, T1> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, WithRotationRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationScheduleFactory, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1>(this CombinedResult<T1, RotationScheduleFactory> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, WithRotationRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RotationScheduleFactory, T1, T2, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2>(this CombinedResult<RotationScheduleFactory, T1, T2> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationScheduleFactory, T2, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2>(this CombinedResult<T1, RotationScheduleFactory, T2> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationScheduleFactory, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2>(this CombinedResult<T1, T2, RotationScheduleFactory> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RotationScheduleFactory, T1, T2, T3, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3>(this CombinedResult<RotationScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationScheduleFactory, T2, T3, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3>(this CombinedResult<T1, RotationScheduleFactory, T2, T3> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationScheduleFactory, T3, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3>(this CombinedResult<T1, T2, RotationScheduleFactory, T3> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RotationScheduleFactory, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, RotationScheduleFactory> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RotationScheduleFactory, T1, T2, T3, T4, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3, T4>(this CombinedResult<RotationScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RotationScheduleFactory, T2, T3, T4, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3, T4>(this CombinedResult<T1, RotationScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RotationScheduleFactory, T3, T4, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, RotationScheduleFactory, T3, T4> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RotationScheduleFactory, T4, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RotationScheduleFactory, T4> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RotationScheduleFactory, InnerRotationScheduleRotationRulesFactory> WithRotationRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RotationScheduleFactory> combinedResult, Action<Humidifier.SecretsManager.RotationScheduleTypes.RotationRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRotationRules(combinedResult.T5, subFactoryAction));
}
