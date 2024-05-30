namespace Poker12.Core.Jugadas;
public class EscaleraReal(JugadaAbs? siguiente = null) : JugadaAbs("Escalera Real", 1, siguiente)
{
    protected override Resultado Aplicar(CartasJugada cartas)
    {
        bool escaleraReal = cartas.MismoPalo && cartas.SonConsecutivas &&
            cartas.MenorOrdenada.Valor == EValor.As && cartas.MayorOrdenada.Valor == EValor.K;

        if (escaleraReal)
        {
            return ResultadoCon(cartas.MayorValorAbsoluto);
        }
        return base.Aplicar(cartas);
    }
}