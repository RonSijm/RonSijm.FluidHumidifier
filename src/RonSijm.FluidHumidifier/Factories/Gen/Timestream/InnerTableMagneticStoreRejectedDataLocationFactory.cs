// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerTableMagneticStoreRejectedDataLocationFactory(Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation>
{

    internal InnerTableS3ConfigurationFactory S3ConfigurationFactory { get; set; }

    protected override Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation Create()
    {
        var magneticStoreRejectedDataLocationResult = CreateMagneticStoreRejectedDataLocation();
        factoryAction?.Invoke(magneticStoreRejectedDataLocationResult);

        return magneticStoreRejectedDataLocationResult;
    }

    private Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation CreateMagneticStoreRejectedDataLocation()
    {
        var magneticStoreRejectedDataLocationResult = new Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation();

        return magneticStoreRejectedDataLocationResult;
    }
    public override void CreateChildren(Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation result)
    {
        base.CreateChildren(result);

        result.S3Configuration ??= S3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTableMagneticStoreRejectedDataLocationFactoryExtensions
{
    public static CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, InnerTableS3ConfigurationFactory> WithS3Configuration(this InnerTableMagneticStoreRejectedDataLocationFactory parentFactory, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null)
    {
        parentFactory.S3ConfigurationFactory = new InnerTableS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ConfigurationFactory);
    }

    public static CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, T1, InnerTableS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, T1> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableMagneticStoreRejectedDataLocationFactory, InnerTableS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<T1, InnerTableMagneticStoreRejectedDataLocationFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, T1, T2, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableMagneticStoreRejectedDataLocationFactory, T2, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, InnerTableMagneticStoreRejectedDataLocationFactory, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableMagneticStoreRejectedDataLocationFactory, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerTableMagneticStoreRejectedDataLocationFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, T1, T2, T3, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableMagneticStoreRejectedDataLocationFactory, T2, T3, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerTableMagneticStoreRejectedDataLocationFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableMagneticStoreRejectedDataLocationFactory, T3, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableMagneticStoreRejectedDataLocationFactory, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableMagneticStoreRejectedDataLocationFactory, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableMagneticStoreRejectedDataLocationFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, T1, T2, T3, T4, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerTableMagneticStoreRejectedDataLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableMagneticStoreRejectedDataLocationFactory, T2, T3, T4, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableMagneticStoreRejectedDataLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableMagneticStoreRejectedDataLocationFactory, T3, T4, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableMagneticStoreRejectedDataLocationFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableMagneticStoreRejectedDataLocationFactory, T4, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableMagneticStoreRejectedDataLocationFactory, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableMagneticStoreRejectedDataLocationFactory, InnerTableS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableMagneticStoreRejectedDataLocationFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T5, subFactoryAction));
}
