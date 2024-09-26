// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerMLTransformTransformParametersFactory(Action<Humidifier.Glue.MLTransformTypes.TransformParameters> factoryAction = null) : SubResourceFactory<Humidifier.Glue.MLTransformTypes.TransformParameters>
{

    internal InnerMLTransformFindMatchesParametersFactory FindMatchesParametersFactory { get; set; }

    protected override Humidifier.Glue.MLTransformTypes.TransformParameters Create()
    {
        var transformParametersResult = CreateTransformParameters();
        factoryAction?.Invoke(transformParametersResult);

        return transformParametersResult;
    }

    private Humidifier.Glue.MLTransformTypes.TransformParameters CreateTransformParameters()
    {
        var transformParametersResult = new Humidifier.Glue.MLTransformTypes.TransformParameters();

        return transformParametersResult;
    }
    public override void CreateChildren(Humidifier.Glue.MLTransformTypes.TransformParameters result)
    {
        base.CreateChildren(result);

        result.FindMatchesParameters ??= FindMatchesParametersFactory?.Build();
    }

} // End Of Class

public static class InnerMLTransformTransformParametersFactoryExtensions
{
    public static CombinedResult<InnerMLTransformTransformParametersFactory, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters(this InnerMLTransformTransformParametersFactory parentFactory, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null)
    {
        parentFactory.FindMatchesParametersFactory = new InnerMLTransformFindMatchesParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FindMatchesParametersFactory);
    }

    public static CombinedResult<InnerMLTransformTransformParametersFactory, T1, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1>(this CombinedResult<InnerMLTransformTransformParametersFactory, T1> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMLTransformTransformParametersFactory, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1>(this CombinedResult<T1, InnerMLTransformTransformParametersFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMLTransformTransformParametersFactory, T1, T2, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2>(this CombinedResult<InnerMLTransformTransformParametersFactory, T1, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMLTransformTransformParametersFactory, T2, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2>(this CombinedResult<T1, InnerMLTransformTransformParametersFactory, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMLTransformTransformParametersFactory, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2>(this CombinedResult<T1, T2, InnerMLTransformTransformParametersFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMLTransformTransformParametersFactory, T1, T2, T3, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3>(this CombinedResult<InnerMLTransformTransformParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMLTransformTransformParametersFactory, T2, T3, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3>(this CombinedResult<T1, InnerMLTransformTransformParametersFactory, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMLTransformTransformParametersFactory, T3, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerMLTransformTransformParametersFactory, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMLTransformTransformParametersFactory, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMLTransformTransformParametersFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMLTransformTransformParametersFactory, T1, T2, T3, T4, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3, T4>(this CombinedResult<InnerMLTransformTransformParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMLTransformTransformParametersFactory, T2, T3, T4, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerMLTransformTransformParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMLTransformTransformParametersFactory, T3, T4, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMLTransformTransformParametersFactory, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMLTransformTransformParametersFactory, T4, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMLTransformTransformParametersFactory, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMLTransformTransformParametersFactory, InnerMLTransformFindMatchesParametersFactory> WithFindMatchesParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMLTransformTransformParametersFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindMatchesParameters(combinedResult.T5, subFactoryAction));
}
