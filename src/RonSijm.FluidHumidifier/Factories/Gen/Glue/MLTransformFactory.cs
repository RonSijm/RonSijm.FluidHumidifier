// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class MLTransformFactory(string resourceName = null, Action<Humidifier.Glue.MLTransform> factoryAction = null) : ResourceFactory<Humidifier.Glue.MLTransform>(resourceName)
{

    internal InnerMLTransformTransformEncryptionFactory TransformEncryptionFactory { get; set; }

    internal InnerMLTransformTransformParametersFactory TransformParametersFactory { get; set; }

    internal InnerMLTransformInputRecordTablesFactory InputRecordTablesFactory { get; set; }

    protected override Humidifier.Glue.MLTransform Create()
    {
        var mLTransformResult = CreateMLTransform();
        factoryAction?.Invoke(mLTransformResult);

        return mLTransformResult;
    }

    private Humidifier.Glue.MLTransform CreateMLTransform()
    {
        var mLTransformResult = new Humidifier.Glue.MLTransform
        {
            GivenName = InputResourceName,
        };

        return mLTransformResult;
    }
    public override void CreateChildren(Humidifier.Glue.MLTransform result)
    {
        base.CreateChildren(result);

        result.TransformEncryption ??= TransformEncryptionFactory?.Build();
        result.TransformParameters ??= TransformParametersFactory?.Build();
        result.InputRecordTables ??= InputRecordTablesFactory?.Build();
    }

} // End Of Class

public static class MLTransformFactoryExtensions
{
    public static CombinedResult<MLTransformFactory, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption(this MLTransformFactory parentFactory, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null)
    {
        parentFactory.TransformEncryptionFactory = new InnerMLTransformTransformEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TransformEncryptionFactory);
    }

    public static CombinedResult<MLTransformFactory, InnerMLTransformTransformParametersFactory> WithTransformParameters(this MLTransformFactory parentFactory, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null)
    {
        parentFactory.TransformParametersFactory = new InnerMLTransformTransformParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TransformParametersFactory);
    }

    public static CombinedResult<MLTransformFactory, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables(this MLTransformFactory parentFactory, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null)
    {
        parentFactory.InputRecordTablesFactory = new InnerMLTransformInputRecordTablesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputRecordTablesFactory);
    }

    public static CombinedResult<MLTransformFactory, T1, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1>(this CombinedResult<MLTransformFactory, T1> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransformEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1>(this CombinedResult<T1, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransformEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2>(this CombinedResult<MLTransformFactory, T1, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2>(this CombinedResult<T1, MLTransformFactory, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2>(this CombinedResult<T1, T2, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, T3, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3>(this CombinedResult<MLTransformFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, T3, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3>(this CombinedResult<T1, MLTransformFactory, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, T3, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3>(this CombinedResult<T1, T2, MLTransformFactory, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MLTransformFactory, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, T3, T4, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3, T4>(this CombinedResult<MLTransformFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, T3, T4, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3, T4>(this CombinedResult<T1, MLTransformFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, T3, T4, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, MLTransformFactory, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MLTransformFactory, T4, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MLTransformFactory, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MLTransformFactory, InnerMLTransformTransformEncryptionFactory> WithTransformEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformEncryption(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1>(this CombinedResult<MLTransformFactory, T1> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransformParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1>(this CombinedResult<T1, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransformParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2>(this CombinedResult<MLTransformFactory, T1, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2>(this CombinedResult<T1, MLTransformFactory, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2>(this CombinedResult<T1, T2, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, T3, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3>(this CombinedResult<MLTransformFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, T3, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3>(this CombinedResult<T1, MLTransformFactory, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, T3, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3>(this CombinedResult<T1, T2, MLTransformFactory, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MLTransformFactory, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, T3, T4, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3, T4>(this CombinedResult<MLTransformFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, T3, T4, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3, T4>(this CombinedResult<T1, MLTransformFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, T3, T4, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, MLTransformFactory, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MLTransformFactory, T4, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MLTransformFactory, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MLTransformFactory, InnerMLTransformTransformParametersFactory> WithTransformParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.TransformParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransformParameters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1>(this CombinedResult<MLTransformFactory, T1> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputRecordTables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1>(this CombinedResult<T1, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputRecordTables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2>(this CombinedResult<MLTransformFactory, T1, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2>(this CombinedResult<T1, MLTransformFactory, T2> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2>(this CombinedResult<T1, T2, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, T3, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3>(this CombinedResult<MLTransformFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, T3, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3>(this CombinedResult<T1, MLTransformFactory, T2, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, T3, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3>(this CombinedResult<T1, T2, MLTransformFactory, T3> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MLTransformFactory, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3>(this CombinedResult<T1, T2, T3, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MLTransformFactory, T1, T2, T3, T4, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3, T4>(this CombinedResult<MLTransformFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MLTransformFactory, T2, T3, T4, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3, T4>(this CombinedResult<T1, MLTransformFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MLTransformFactory, T3, T4, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3, T4>(this CombinedResult<T1, T2, MLTransformFactory, T3, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MLTransformFactory, T4, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MLTransformFactory, T4> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MLTransformFactory, InnerMLTransformInputRecordTablesFactory> WithInputRecordTables<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MLTransformFactory> combinedResult, Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputRecordTables(combinedResult.T5, subFactoryAction));
}
