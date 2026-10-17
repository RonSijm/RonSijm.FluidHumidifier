// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableIcebergInputFactory(Action<Humidifier.Glue.TableTypes.IcebergInput> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.IcebergInput>
{

    internal InnerTableIcebergTableInputFactory IcebergTableInputFactory { get; set; }

    protected override Humidifier.Glue.TableTypes.IcebergInput Create()
    {
        var icebergInputResult = CreateIcebergInput();
        factoryAction?.Invoke(icebergInputResult);

        return icebergInputResult;
    }

    private Humidifier.Glue.TableTypes.IcebergInput CreateIcebergInput()
    {
        var icebergInputResult = new Humidifier.Glue.TableTypes.IcebergInput();

        return icebergInputResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableTypes.IcebergInput result)
    {
        base.CreateChildren(result);

        result.IcebergTableInput ??= IcebergTableInputFactory?.Build();
    }

} // End Of Class

public static class InnerTableIcebergInputFactoryExtensions
{
    public static CombinedResult<InnerTableIcebergInputFactory, InnerTableIcebergTableInputFactory> WithIcebergTableInput(this InnerTableIcebergInputFactory parentFactory, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null)
    {
        parentFactory.IcebergTableInputFactory = new InnerTableIcebergTableInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IcebergTableInputFactory);
    }

    public static CombinedResult<InnerTableIcebergInputFactory, T1, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1>(this CombinedResult<InnerTableIcebergInputFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableIcebergInputFactory, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1>(this CombinedResult<T1, InnerTableIcebergInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTableIcebergInputFactory, T1, T2, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2>(this CombinedResult<InnerTableIcebergInputFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableIcebergInputFactory, T2, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2>(this CombinedResult<T1, InnerTableIcebergInputFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableIcebergInputFactory, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2>(this CombinedResult<T1, T2, InnerTableIcebergInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTableIcebergInputFactory, T1, T2, T3, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3>(this CombinedResult<InnerTableIcebergInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableIcebergInputFactory, T2, T3, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3>(this CombinedResult<T1, InnerTableIcebergInputFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableIcebergInputFactory, T3, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableIcebergInputFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableIcebergInputFactory, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableIcebergInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTableIcebergInputFactory, T1, T2, T3, T4, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3, T4>(this CombinedResult<InnerTableIcebergInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableIcebergInputFactory, T2, T3, T4, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableIcebergInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableIcebergInputFactory, T3, T4, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableIcebergInputFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableIcebergInputFactory, T4, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableIcebergInputFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTableIcebergInputFactory, InnerTableIcebergTableInputFactory> WithIcebergTableInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableIcebergInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergTableInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergTableInput(combinedResult.T5, subFactoryAction).T2);
}
