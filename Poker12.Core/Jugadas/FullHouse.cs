namespace Poker12.Core.Jugadas;

public class FullHouse(JugadaAbs? siguiente = null) : JugadaAbs("FullHouse",3, siguiente)
{
    protected override Resultado Aplicar(CartasJugada cartas)
    {
        var valorCon3 = cartas.MayorValorConNCartas(3);
        var valorCon2 = cartas.MayorValorConNCartas(2);
        if (valorCon2 != 0 && valorCon3 != 0)
            return ResultadoCon(valorCon3);
        return base.Aplicar(cartas);
    }
}
