namespace Poker12.Core.Jugadas;

public class Par(JugadaAbs? siguiente = null)
    : JugadaAbs("Par", 9, siguiente)
{
    protected override Resultado Aplicar(CartasJugada cartas)
    {
        var valor = cartas.MayorValorConNCartas(2);
        if (valor!=0)
            return ResultadoCon(valor);
        return base.Aplicar(cartas);
    }
}