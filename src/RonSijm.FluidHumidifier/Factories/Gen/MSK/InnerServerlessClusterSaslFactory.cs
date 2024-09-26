// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerServerlessClusterSaslFactory(Action<Humidifier.MSK.ServerlessClusterTypes.Sasl> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ServerlessClusterTypes.Sasl>
{

    internal InnerServerlessClusterIamFactory IamFactory { get; set; }

    protected override Humidifier.MSK.ServerlessClusterTypes.Sasl Create()
    {
        var saslResult = CreateSasl();
        factoryAction?.Invoke(saslResult);

        return saslResult;
    }

    private Humidifier.MSK.ServerlessClusterTypes.Sasl CreateSasl()
    {
        var saslResult = new Humidifier.MSK.ServerlessClusterTypes.Sasl();

        return saslResult;
    }
    public override void CreateChildren(Humidifier.MSK.ServerlessClusterTypes.Sasl result)
    {
        base.CreateChildren(result);

        result.Iam ??= IamFactory?.Build();
    }

} // End Of Class

public static class InnerServerlessClusterSaslFactoryExtensions
{
    public static CombinedResult<InnerServerlessClusterSaslFactory, InnerServerlessClusterIamFactory> WithIam(this InnerServerlessClusterSaslFactory parentFactory, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null)
    {
        parentFactory.IamFactory = new InnerServerlessClusterIamFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IamFactory);
    }

    public static CombinedResult<InnerServerlessClusterSaslFactory, T1, InnerServerlessClusterIamFactory> WithIam<T1>(this CombinedResult<InnerServerlessClusterSaslFactory, T1> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessClusterSaslFactory, InnerServerlessClusterIamFactory> WithIam<T1>(this CombinedResult<T1, InnerServerlessClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServerlessClusterSaslFactory, T1, T2, InnerServerlessClusterIamFactory> WithIam<T1, T2>(this CombinedResult<InnerServerlessClusterSaslFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessClusterSaslFactory, T2, InnerServerlessClusterIamFactory> WithIam<T1, T2>(this CombinedResult<T1, InnerServerlessClusterSaslFactory, T2> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessClusterSaslFactory, InnerServerlessClusterIamFactory> WithIam<T1, T2>(this CombinedResult<T1, T2, InnerServerlessClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServerlessClusterSaslFactory, T1, T2, T3, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3>(this CombinedResult<InnerServerlessClusterSaslFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessClusterSaslFactory, T2, T3, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, InnerServerlessClusterSaslFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessClusterSaslFactory, T3, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, T2, InnerServerlessClusterSaslFactory, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServerlessClusterSaslFactory, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServerlessClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServerlessClusterSaslFactory, T1, T2, T3, T4, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<InnerServerlessClusterSaslFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServerlessClusterSaslFactory, T2, T3, T4, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, InnerServerlessClusterSaslFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServerlessClusterSaslFactory, T3, T4, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServerlessClusterSaslFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServerlessClusterSaslFactory, T4, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServerlessClusterSaslFactory, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServerlessClusterSaslFactory, InnerServerlessClusterIamFactory> WithIam<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServerlessClusterSaslFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.Iam> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIam(combinedResult.T5, subFactoryAction));
}
