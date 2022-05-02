using System.IO;

//suma();
//intervalo();
//serieMenor150();
//salario();
Console.WriteLine(calcularMonto(5));

void suma()
{
    int i, suma, dato;
    do
    {
        Console.WriteLine("ingrese un numero positivo");
    } while (!int.TryParse(Console.ReadLine(), out dato) || dato < 0); //mientras no sea numero y sea negativo
    suma = 0;
    for (i = 0; i < 100; i++)
    {
        suma += dato + i;
    }
    Console.WriteLine("valor de la suma: " + suma);
}

void intervalo()
{
    int a, b, salida,mayor;
    do
    {
        Console.WriteLine("ingrese el primer operando");
    } while (!int.TryParse(Console.ReadLine(), out a)); //mientras no sea numero
    do
    {
        Console.WriteLine("ingrese el segundo operando");
    } while (!int.TryParse(Console.ReadLine(), out b) || b == a); //mientras no sea numero y distinto de a

    salida = (a < b) ? a : b;
    mayor = (salida == a) ? b : a;
   
    while (salida < mayor)
    {
        Console.WriteLine(salida);
        salida += 7;
    }
}

void serieMenor150()
{
    int cant, acum, dato;
    float media;
    cant = acum = 0;

    do
    {
        do
        {
            Console.WriteLine("ingrese un numero");
        } while (!int.TryParse(Console.ReadLine(), out dato)); //mientras no sea numero
        cant++;
        acum += dato;
    } while (acum<=150); //mientras no supere 150
    media = (float)acum / (float)cant;
    Console.WriteLine("total acumulado: " + acum + " cant de num introducidos: " 
        + cant + " media: " + media);
}

void salario()
{
    String nombre;
    int cantHoras;
    double valorHoras, salario;
    Console.WriteLine("ingrese nombre del trabajador");
    nombre = Console.ReadLine();
    do
    {
        Console.WriteLine("ingrese cant de horas");
    } while (!int.TryParse(Console.ReadLine(), out cantHoras) || cantHoras < 0); //mientras no sea numero y sea negativo
    do
    {
        Console.WriteLine("ingrese el valor de la hora");
    } while (!double.TryParse(Console.ReadLine(), out valorHoras) || valorHoras < 0); //mientras no sea numero y sea negativo
    salario = cantHoras * valorHoras;

    Console.WriteLine("el salario de " + nombre + " es de " + salario);

}

void radar()
{
    Boolean bandera = true;
    String linea;
    int mayorCoches,interCoches, anterior,velocidad,tipo,cont,contBici,contMoto,contCoche,contCamion,contError;
    mayorCoches = interCoches = cont = contBici = contCoche = contCamion = contMoto = contError = 0;
    StreamReader sr = new StreamReader("C:\\Users\\Gutie\\Desktop\\radar.txt");
    linea = sr.ReadLine();
    anterior = -1;
    while (linea!=null && bandera && cont<1000)
    {
        cont++;
        tipo = int.Parse(linea);
        velocidad = int.Parse(linea);
        switch (tipo)
        {
            case 0:
                contBici++;
                break;
            case 1: contMoto++;
                break;
            case 2: contCoche++;
                break;
            case 3: contCamion++;
                break;
            case 4: 
                contError++;
                bandera = (anterior == tipo) ? false : true;
                break;
            default:
                Console.WriteLine("error: " + tipo);
                break;
        }
        if (tipo != 2)
            interCoches++;
        else
        {
            if (interCoches > mayorCoches)
                mayorCoches = interCoches;
            interCoches = 0;   
        }
        anterior = tipo;
    }
    Console.WriteLine("cant de vehiculos: " + cont + " cant de errores: " + contError + "porcentajes: ");
    Console.WriteLine("bici: %" + 100*((double)contBici / cont));
    Console.WriteLine("moto: %" + 100 * ((double)contMoto / cont));
    Console.WriteLine("camion: %" + 100 * ((double)contCamion / cont));
    Console.WriteLine("error: %" + 100 * ((double)contError / cont));
    Console.WriteLine("maximo intervalo entre dos coches: " + mayorCoches);
}

double calcularMonto(int cantHoras)
{
    int promo;
    double costoHoras = 1.5;

    promo = cantHoras / 5;

    return (cantHoras - promo) * costoHoras;
}