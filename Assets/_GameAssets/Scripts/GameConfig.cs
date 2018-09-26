
public class GameConfig {
    //atributos 
    private static bool jugando = true;

    // hariamos get y set de la clase (GetJugando - SetJugando) pero por semantica le cambiamos el nombre
    public static bool IsPlaying()
    {

        return jugando;
    }


    public static void ArrancaJuego()
    {

        jugando = true;

    }

    public static void ParaJuego()
    {

        jugando = false;

    }


}
