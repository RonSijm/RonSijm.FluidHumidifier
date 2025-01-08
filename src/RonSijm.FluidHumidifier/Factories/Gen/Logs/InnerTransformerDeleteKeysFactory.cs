// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerDeleteKeysFactory(Action<Humidifier.Logs.TransformerTypes.DeleteKeys> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.DeleteKeys>
{

    protected override Humidifier.Logs.TransformerTypes.DeleteKeys Create()
    {
        var deleteKeysResult = CreateDeleteKeys();
        factoryAction?.Invoke(deleteKeysResult);

        return deleteKeysResult;
    }

    private Humidifier.Logs.TransformerTypes.DeleteKeys CreateDeleteKeys()
    {
        var deleteKeysResult = new Humidifier.Logs.TransformerTypes.DeleteKeys();

        return deleteKeysResult;
    }

} // End Of Class

public static class InnerTransformerDeleteKeysFactoryExtensions
{
}
