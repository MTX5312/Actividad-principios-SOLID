using System;

public class Enemigo
{
	public string Nombre;
	public int Vida;
	
	public Enemigo(string nombre, int vida)
	{
		Nombre = nombre;

		Vida = vida;
    }

	public void RecibirDanio(int danio)
		{
		Vida -= danio;
		if (Vida < 0)
		{
			Vida = 0;
		}
		Console.WriteLine($"{Nombre} ha recibido {danio} de daño. Vida restante: {Vida}");
    }
}

public class GenerarEnemigos()
{
	public void Generar(Enemigo fantasma)
	{
		Console.WriteLine($"Generando {fantasma.name} en la pantalla...");
    }
}

public class JuegoTerminado()
{
	public void VerificarDerrota(Enemigo enemigo)
	{
		if (enemigo.Vida <= 0)
		{
			Console.WriteLine($"{enemigo.Nombre} ha sido derrotado!");
		}
    }
}

//Las responsabilidades se dividen entre las clases
//Se pueden realizar modificaciones sin cambiar la clase Enemigo