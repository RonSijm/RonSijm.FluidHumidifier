// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOpenTableFormatInputFactory(Action<Humidifier.Glue.TableTypes.OpenTableFormatInput> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.OpenTableFormatInput>
{

    internal InnerTableIcebergInputFactory IcebergInputFactory { get; set; }

    protected override Humidifier.Glue.TableTypes.OpenTableFormatInput Create()
    {
        var openTableFormatInputResult = CreateOpenTableFormatInput();
        factoryAction?.Invoke(openTableFormatInputResult);

        return openTableFormatInputResult;
    }

    private Humidifier.Glue.TableTypes.OpenTableFormatInput CreateOpenTableFormatInput()
    {
        var openTableFormatInputResult = new Humidifier.Glue.TableTypes.OpenTableFormatInput();

        return openTableFormatInputResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableTypes.OpenTableFormatInput result)
    {
        base.CreateChildren(result);

        result.IcebergInput ??= IcebergInputFactory?.Build();
    }

} // End Of Class

public static class InnerTableOpenTableFormatInputFactoryExtensions
{
    public static CombinedResult<InnerTableOpenTableFormatInputFactory, InnerTableIcebergInputFactory> WithIcebergInput(this InnerTableOpenTableFormatInputFactory parentFactory, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null)
    {
        parentFactory.IcebergInputFactory = new InnerTableIcebergInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IcebergInputFactory);
    }

    public static CombinedResult<InnerTableOpenTableFormatInputFactory, T1, InnerTableIcebergInputFactory> WithIcebergInput<T1>(this CombinedResult<InnerTableOpenTableFormatInputFactory, T1> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableOpenTableFormatInputFactory, InnerTableIcebergInputFactory> WithIcebergInput<T1>(this CombinedResult<T1, InnerTableOpenTableFormatInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableOpenTableFormatInputFactory, T1, T2, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2>(this CombinedResult<InnerTableOpenTableFormatInputFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableOpenTableFormatInputFactory, T2, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2>(this CombinedResult<T1, InnerTableOpenTableFormatInputFactory, T2> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableOpenTableFormatInputFactory, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2>(this CombinedResult<T1, T2, InnerTableOpenTableFormatInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableOpenTableFormatInputFactory, T1, T2, T3, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3>(this CombinedResult<InnerTableOpenTableFormatInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableOpenTableFormatInputFactory, T2, T3, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3>(this CombinedResult<T1, InnerTableOpenTableFormatInputFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableOpenTableFormatInputFactory, T3, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableOpenTableFormatInputFactory, T3> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableOpenTableFormatInputFactory, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableOpenTableFormatInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableOpenTableFormatInputFactory, T1, T2, T3, T4, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3, T4>(this CombinedResult<InnerTableOpenTableFormatInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableOpenTableFormatInputFactory, T2, T3, T4, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableOpenTableFormatInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableOpenTableFormatInputFactory, T3, T4, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableOpenTableFormatInputFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableOpenTableFormatInputFactory, T4, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableOpenTableFormatInputFactory, T4> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableOpenTableFormatInputFactory, InnerTableIcebergInputFactory> WithIcebergInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableOpenTableFormatInputFactory> combinedResult, Action<Humidifier.Glue.TableTypes.IcebergInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergInput(combinedResult.T5, subFactoryAction));
}
