// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionRedshiftCredentialsFactory(Action<Humidifier.DataZone.ConnectionTypes.RedshiftCredentials> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.RedshiftCredentials>
{

    internal InnerConnectionUsernamePasswordFactory UsernamePasswordFactory { get; set; }

    protected override Humidifier.DataZone.ConnectionTypes.RedshiftCredentials Create()
    {
        var redshiftCredentialsResult = CreateRedshiftCredentials();
        factoryAction?.Invoke(redshiftCredentialsResult);

        return redshiftCredentialsResult;
    }

    private Humidifier.DataZone.ConnectionTypes.RedshiftCredentials CreateRedshiftCredentials()
    {
        var redshiftCredentialsResult = new Humidifier.DataZone.ConnectionTypes.RedshiftCredentials();

        return redshiftCredentialsResult;
    }
    public override void CreateChildren(Humidifier.DataZone.ConnectionTypes.RedshiftCredentials result)
    {
        base.CreateChildren(result);

        result.UsernamePassword ??= UsernamePasswordFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionRedshiftCredentialsFactoryExtensions
{
    public static CombinedResult<InnerConnectionRedshiftCredentialsFactory, InnerConnectionUsernamePasswordFactory> WithUsernamePassword(this InnerConnectionRedshiftCredentialsFactory parentFactory, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null)
    {
        parentFactory.UsernamePasswordFactory = new InnerConnectionUsernamePasswordFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UsernamePasswordFactory);
    }

    public static CombinedResult<InnerConnectionRedshiftCredentialsFactory, T1, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1>(this CombinedResult<InnerConnectionRedshiftCredentialsFactory, T1> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, WithUsernamePassword(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionRedshiftCredentialsFactory, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1>(this CombinedResult<T1, InnerConnectionRedshiftCredentialsFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, WithUsernamePassword(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionRedshiftCredentialsFactory, T1, T2, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2>(this CombinedResult<InnerConnectionRedshiftCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionRedshiftCredentialsFactory, T2, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2>(this CombinedResult<T1, InnerConnectionRedshiftCredentialsFactory, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionRedshiftCredentialsFactory, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2>(this CombinedResult<T1, T2, InnerConnectionRedshiftCredentialsFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionRedshiftCredentialsFactory, T1, T2, T3, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3>(this CombinedResult<InnerConnectionRedshiftCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionRedshiftCredentialsFactory, T2, T3, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3>(this CombinedResult<T1, InnerConnectionRedshiftCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionRedshiftCredentialsFactory, T3, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionRedshiftCredentialsFactory, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionRedshiftCredentialsFactory, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionRedshiftCredentialsFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionRedshiftCredentialsFactory, T1, T2, T3, T4, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3, T4>(this CombinedResult<InnerConnectionRedshiftCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionRedshiftCredentialsFactory, T2, T3, T4, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionRedshiftCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionRedshiftCredentialsFactory, T3, T4, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionRedshiftCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionRedshiftCredentialsFactory, T4, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionRedshiftCredentialsFactory, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionRedshiftCredentialsFactory, InnerConnectionUsernamePasswordFactory> WithUsernamePassword<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionRedshiftCredentialsFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.UsernamePassword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsernamePassword(combinedResult.T5, subFactoryAction).T2);
}
