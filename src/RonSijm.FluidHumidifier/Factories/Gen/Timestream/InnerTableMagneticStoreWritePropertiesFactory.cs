// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerTableMagneticStoreWritePropertiesFactory(Action<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties>
{

    internal InnerTableMagneticStoreRejectedDataLocationFactory MagneticStoreRejectedDataLocationFactory { get; set; }

    protected override Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties Create()
    {
        var magneticStoreWritePropertiesResult = CreateMagneticStoreWriteProperties();
        factoryAction?.Invoke(magneticStoreWritePropertiesResult);

        return magneticStoreWritePropertiesResult;
    }

    private Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties CreateMagneticStoreWriteProperties()
    {
        var magneticStoreWritePropertiesResult = new Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties();

        return magneticStoreWritePropertiesResult;
    }
    public override void CreateChildren(Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties result)
    {
        base.CreateChildren(result);

        result.MagneticStoreRejectedDataLocation ??= MagneticStoreRejectedDataLocationFactory?.Build();
    }

} // End Of Class

public static class InnerTableMagneticStoreWritePropertiesFactoryExtensions
{
    public static CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation(this InnerTableMagneticStoreWritePropertiesFactory parentFactory, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null)
    {
        parentFactory.MagneticStoreRejectedDataLocationFactory = new InnerTableMagneticStoreRejectedDataLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MagneticStoreRejectedDataLocationFactory);
    }

    public static CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, T1, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1>(this CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, T1> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableMagneticStoreWritePropertiesFactory, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1>(this CombinedResult<T1, InnerTableMagneticStoreWritePropertiesFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, T1, T2, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2>(this CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableMagneticStoreWritePropertiesFactory, T2, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2>(this CombinedResult<T1, InnerTableMagneticStoreWritePropertiesFactory, T2> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableMagneticStoreWritePropertiesFactory, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2>(this CombinedResult<T1, T2, InnerTableMagneticStoreWritePropertiesFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, T1, T2, T3, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3>(this CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableMagneticStoreWritePropertiesFactory, T2, T3, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3>(this CombinedResult<T1, InnerTableMagneticStoreWritePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableMagneticStoreWritePropertiesFactory, T3, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableMagneticStoreWritePropertiesFactory, T3> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableMagneticStoreWritePropertiesFactory, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableMagneticStoreWritePropertiesFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, T1, T2, T3, T4, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3, T4>(this CombinedResult<InnerTableMagneticStoreWritePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableMagneticStoreWritePropertiesFactory, T2, T3, T4, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableMagneticStoreWritePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableMagneticStoreWritePropertiesFactory, T3, T4, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableMagneticStoreWritePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableMagneticStoreWritePropertiesFactory, T4, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableMagneticStoreWritePropertiesFactory, T4> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableMagneticStoreWritePropertiesFactory, InnerTableMagneticStoreRejectedDataLocationFactory> WithMagneticStoreRejectedDataLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableMagneticStoreWritePropertiesFactory> combinedResult, Action<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMagneticStoreRejectedDataLocation(combinedResult.T5, subFactoryAction));
}
