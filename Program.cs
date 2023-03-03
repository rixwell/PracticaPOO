using System;

class Program
{
    static void Main(string[] args)
    {
        Motor motor = new Motor(200);

        Console.WriteLine("Potencia del motor: " + motor.GetPotencia());

        motor.SetLitrosDeAceite(5);
        Console.WriteLine("Litros de aceite: " + motor.GetLitrosDeAceite());
    }
}

class Motor
{
    private int litros_de_aceite;
    private int potencia;

    public Motor(int potencia)
    {
        this.potencia = potencia;
        this.litros_de_aceite = 0;
    }

    public int GetLitrosDeAceite()
    {
        return this.litros_de_aceite;
    }

    public void SetLitrosDeAceite(int litros)
    {
        this.litros_de_aceite = litros;
    }

    public int GetPotencia()
    {
        return this.potencia;
    }

    public void SetPotencia(int potencia)
    {
        this.potencia = potencia;
    }
}

class Coche
{
    private Motor motor;
    private string marca;
    private string modelo;
    private double precioAverias;

    public Coche(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.motor = new Motor(0);
        this.precioAverias = 0.0;
    }

    public string GetMarca()
    {
        return this.marca;
    }

    public string GetModelo()
    {
        return this.modelo;
    }

    public double GetPrecioAverias()
    {
        return this.precioAverias;
    }

    public void AcumularAveria(double importe)
    {
        this.precioAverias += importe;
    }
}
class Garaje
{
    private Coche coche;
    private string averia;
    private int cochesAtendidos;

    public bool AceptarCoche(Coche coche, string averia)
    {
        if (this.coche == null)
        {
            this.coche = coche;
            this.averia = averia;
            this.cochesAtendidos++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public Coche DevolverCoche()
    {
        Coche cocheDevuelto = this.coche;
        this.coche = null;
        this.averia = null;
        return cocheDevuelto;
    }
}

    class PracticaPOO
    {
        static void Main(string[] args)
        {
          
            Garaje garaje = new Garaje();

            Coche coche1 = new Coche("Toyota", "Corolla");
            Coche coche2 = new Coche("Honda", "Civic");


            garaje.AceptarCoche(coche1, "Avería 1");
            garaje.AceptarCoche(coche2, "Avería 2");

           
            Console.WriteLine("Información de los coches:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Coche 1:");
            Console.WriteLine("Marca: " + coche1.Marca);
            Console.WriteLine("Modelo: " + coche1.Modelo);
            Console.WriteLine("Precio de las averías: " + coche1.PrecioAverias);
            Console.WriteLine("Litros de aceite: " + coche1.Motor.LitrosDeAceite);
            Console.WriteLine("Potencia del motor: " + coche1.Motor.Potencia);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Coche 2:");
            Console.WriteLine("Marca: " + coche2.Marca);
            Console.WriteLine("Modelo: " + coche2.Modelo);
            Console.WriteLine("Precio de las averías: " + coche2.PrecioAverias);
            Console.WriteLine("Litros de aceite: " + coche2.Motor.LitrosDeAceite);
            Console.WriteLine("Potencia del motor: " + coche2.Motor.Potencia);

          
            Console.ReadKey();
        }
    }


