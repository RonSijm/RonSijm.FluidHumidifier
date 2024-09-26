// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerMLTransformTransformEncryptionFactory(Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> factoryAction = null) : SubResourceFactory<Humidifier.Glue.MLTransformTypes.TransformEncryption>
{

    internal InnerMLTransformMLUserDataEncryptionFactory MLUserDataEncryptionFactory { get; set; }

    protected override Humidifier.Glue.MLTransformTypes.TransformEncryption Create()
    {
        var transformEncryptionResult = CreateTransformEncryption();
        factoryAction?.Invoke(transformEncryptionResult);

        return transformEncryptionResult;
    }

    private Humidifier.Glue.MLTransformTypes.TransformEncryption CreateTransformEncryption()
    {
        var transformEncryptionResult = new Humidifier.Glue.MLTransformTypes.TransformEncryption();

        return transformEncryptionResult;
    }
    public override void CreateChildren(Humidifier.Glue.MLTransformTypes.TransformEncryption result)
    {
        base.CreateChildren(result);

        result.MLUserDataEncryption ??= MLUserDataEncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerMLTransformTransformEncryptionFactoryExtensions
{
    public static CombinedResult<InnerMLTransformTransformEncryptionFactory, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption(this InnerMLTransformTransformEncryptionFactory parentFactory, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null)
    {
        parentFactory.MLUserDataEncryptionFactory = new InnerMLTransformMLUserDataEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MLUserDataEncryptionFactory);
    }

    public static CombinedResult<InnerMLTransformTransformEncryptionFactory, T1, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1>(this CombinedResult<InnerMLTransformTransformEncryptionFactory, T1> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMLTransformTransformEncryptionFactory, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1>(this CombinedResult<T1, InnerMLTransformTransformEncryptionFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMLTransformTransformEncryptionFactory, T1, T2, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2>(this CombinedResult<InnerMLTransformTransformEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMLTransformTransformEncryptionFactory, T2, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2>(this CombinedResult<T1, InnerMLTransformTransformEncryptionFactory, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMLTransformTransformEncryptionFactory, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2>(this CombinedResult<T1, T2, InnerMLTransformTransformEncryptionFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMLTransformTransformEncryptionFactory, T1, T2, T3, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3>(this CombinedResult<InnerMLTransformTransformEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMLTransformTransformEncryptionFactory, T2, T3, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3>(this CombinedResult<T1, InnerMLTransformTransformEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMLTransformTransformEncryptionFactory, T3, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerMLTransformTransformEncryptionFactory, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMLTransformTransformEncryptionFactory, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMLTransformTransformEncryptionFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMLTransformTransformEncryptionFactory, T1, T2, T3, T4, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3, T4>(this CombinedResult<InnerMLTransformTransformEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMLTransformTransformEncryptionFactory, T2, T3, T4, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerMLTransformTransformEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMLTransformTransformEncryptionFactory, T3, T4, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMLTransformTransformEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMLTransformTransformEncryptionFactory, T4, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMLTransformTransformEncryptionFactory, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMLTransformTransformEncryptionFactory, InnerMLTransformMLUserDataEncryptionFactory> WithMLUserDataEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMLTransformTransformEncryptionFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMLUserDataEncryption(combinedResult.T5, subFactoryAction));
}
