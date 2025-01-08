// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerMoveKeysFactory(Action<Humidifier.Logs.TransformerTypes.MoveKeys> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.MoveKeys>
{

    protected override Humidifier.Logs.TransformerTypes.MoveKeys Create()
    {
        var moveKeysResult = CreateMoveKeys();
        factoryAction?.Invoke(moveKeysResult);

        return moveKeysResult;
    }

    private Humidifier.Logs.TransformerTypes.MoveKeys CreateMoveKeys()
    {
        var moveKeysResult = new Humidifier.Logs.TransformerTypes.MoveKeys();

        return moveKeysResult;
    }

} // End Of Class

public static class InnerTransformerMoveKeysFactoryExtensions
{
}
