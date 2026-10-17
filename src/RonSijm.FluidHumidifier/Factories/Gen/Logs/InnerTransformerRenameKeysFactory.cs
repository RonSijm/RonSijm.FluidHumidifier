// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerRenameKeysFactory(Action<Humidifier.Logs.TransformerTypes.RenameKeys> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.RenameKeys>
{

    protected override Humidifier.Logs.TransformerTypes.RenameKeys Create()
    {
        var renameKeysResult = CreateRenameKeys();
        factoryAction?.Invoke(renameKeysResult);

        return renameKeysResult;
    }

    private Humidifier.Logs.TransformerTypes.RenameKeys CreateRenameKeys()
    {
        var renameKeysResult = new Humidifier.Logs.TransformerTypes.RenameKeys();

        return renameKeysResult;
    }

} // End Of Class

public static class InnerTransformerRenameKeysFactoryExtensions
{
}
