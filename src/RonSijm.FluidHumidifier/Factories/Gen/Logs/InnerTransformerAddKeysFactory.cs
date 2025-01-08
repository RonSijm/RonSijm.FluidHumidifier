// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerAddKeysFactory(Action<Humidifier.Logs.TransformerTypes.AddKeys> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.AddKeys>
{

    protected override Humidifier.Logs.TransformerTypes.AddKeys Create()
    {
        var addKeysResult = CreateAddKeys();
        factoryAction?.Invoke(addKeysResult);

        return addKeysResult;
    }

    private Humidifier.Logs.TransformerTypes.AddKeys CreateAddKeys()
    {
        var addKeysResult = new Humidifier.Logs.TransformerTypes.AddKeys();

        return addKeysResult;
    }

} // End Of Class

public static class InnerTransformerAddKeysFactoryExtensions
{
}
