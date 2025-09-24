using System;

class Program
{
	static void Main(string[] args)
	{
		Objeto gravitador = new CambiaGravedad();
		Objeto gancho = new Gancho();
		PJ corredor = new PJ(gancho);
		corredor.UsarObjeto();
    }
}

public class PJ
{
	private Objeto objeto;
	
	public PJ(Objeto objeto)
	{
		this.objeto = objeto;
    }

	public void UsarObjeto()
	{
		objeto.usar();
	}
}

public interface Objeto
{
	void usar();
}

public class CambiaGravedad : Objeto
{
	public void usar()
	{
		Console.WriteLine("Cambiando la gravedad...");
    }
}

public class Gancho : Objeto
{
	public void usar()
	{
		Console.WriteLine("Usando el gancho...");
	}
}

//Como la clase depende de una abstraccion y no una implementacion concreta,
//podemos cambiar o añadir nuevos objetos sin modificar al jugador