using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Poker12.Core;
using Poker12.Core.Jugadas;

namespace MyBenchmarks;

public class PokerXD
{
    public JugadaAbs InstanciarJugadas()
    {
        var cartaAlta = new CartaAlta();
        var par = new Par(cartaAlta);
        var doblepar = new DoblePar(par);
        var trio = new Trio(doblepar);
        var escalera = new Escalera(trio);
        var color = new Color(escalera);
        var fullhouse = new FullHouse(color);
        var poker = new Poker(fullhouse);
        var escaleracolor = new EscaleraColor(poker);
        var escalerareal = new EscaleraReal(escaleracolor);

        return escalerareal;
    }

    [Benchmark]
    public Resultado ObtenerResultado()
    {
        var jugada = InstanciarJugadas();
        //  genera una lista de 5 cartas, que solamente se le pueda aplicar carta alta
        var cartas = new List<Carta>()
        {
            new(EPalo.Corazon, EValor.J),
            new(EPalo.Picas, EValor.As),
            new(EPalo.Corazon, EValor.Tres),
            new(EPalo.Trebol, EValor.Dos),
            new(EPalo.Picas, EValor.Cuatro)
        };
        return jugada.Aplicar(cartas);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<PokerXD>();
    }
}
