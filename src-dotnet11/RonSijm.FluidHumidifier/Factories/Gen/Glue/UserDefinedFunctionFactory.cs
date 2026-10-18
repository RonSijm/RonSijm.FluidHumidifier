// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class UserDefinedFunctionFactory(string resourceName = null, Action<Humidifier.Glue.UserDefinedFunction> factoryAction = null) : ResourceFactory<Humidifier.Glue.UserDefinedFunction>(resourceName)
{

    internal List<InnerUserDefinedFunctionResourceUriFactory> ResourceUrisFactories { get; set; } = [];

    protected override Humidifier.Glue.UserDefinedFunction Create()
    {
        var userDefinedFunctionResult = CreateUserDefinedFunction();
        factoryAction?.Invoke(userDefinedFunctionResult);

        return userDefinedFunctionResult;
    }

    private Humidifier.Glue.UserDefinedFunction CreateUserDefinedFunction()
    {
        var userDefinedFunctionResult = new Humidifier.Glue.UserDefinedFunction
        {
            GivenName = InputResourceName,
        };

        return userDefinedFunctionResult;
    }
    public override void CreateChildren(Humidifier.Glue.UserDefinedFunction result)
    {
        base.CreateChildren(result);

        result.ResourceUris = ResourceUrisFactories.Any() ? ResourceUrisFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class UserDefinedFunctionFactoryExtensions
{
    public static CombinedResult<UserDefinedFunctionFactory, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris(this UserDefinedFunctionFactory parentFactory, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null)
    {
        var factory = new InnerUserDefinedFunctionResourceUriFactory(subFactoryAction);
        parentFactory.ResourceUrisFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<UserDefinedFunctionFactory, T1, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1>(this CombinedResult<UserDefinedFunctionFactory, T1> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceUris(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, UserDefinedFunctionFactory, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1>(this CombinedResult<T1, UserDefinedFunctionFactory> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceUris(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<UserDefinedFunctionFactory, T1, T2, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2>(this CombinedResult<UserDefinedFunctionFactory, T1, T2> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, UserDefinedFunctionFactory, T2, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2>(this CombinedResult<T1, UserDefinedFunctionFactory, T2> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, UserDefinedFunctionFactory, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2>(this CombinedResult<T1, T2, UserDefinedFunctionFactory> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<UserDefinedFunctionFactory, T1, T2, T3, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3>(this CombinedResult<UserDefinedFunctionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, UserDefinedFunctionFactory, T2, T3, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3>(this CombinedResult<T1, UserDefinedFunctionFactory, T2, T3> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, UserDefinedFunctionFactory, T3, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3>(this CombinedResult<T1, T2, UserDefinedFunctionFactory, T3> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, UserDefinedFunctionFactory, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserDefinedFunctionFactory> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<UserDefinedFunctionFactory, T1, T2, T3, T4, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3, T4>(this CombinedResult<UserDefinedFunctionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, UserDefinedFunctionFactory, T2, T3, T4, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3, T4>(this CombinedResult<T1, UserDefinedFunctionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, UserDefinedFunctionFactory, T3, T4, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserDefinedFunctionFactory, T3, T4> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, UserDefinedFunctionFactory, T4, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserDefinedFunctionFactory, T4> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, UserDefinedFunctionFactory, InnerUserDefinedFunctionResourceUriFactory> WithResourceUris<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserDefinedFunctionFactory> combinedResult, Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceUris(combinedResult.T5, subFactoryAction).T2);
}
