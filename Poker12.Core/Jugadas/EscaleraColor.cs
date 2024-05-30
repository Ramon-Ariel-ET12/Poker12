namespace Poker12.Core.Jugadas;

public class EscaleraColor(JugadaAbs? siguiente = null) : JugadaAbs("Escalera Color", 2, siguiente)
{
    protected override Resultado Aplicar(CartasJugada cartas)
    {
        bool escaleraColor = cartas.SonConsecutivas && cartas.MismoPalo;
        if (escaleraColor)
        {
            return ResultadoCon((byte)cartas.MayorOrdenada.Valor);
        }
        return base.Aplicar(cartas);
    }
}