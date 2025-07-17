// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dia semanal");

var nombredia = "";
while(true) { 
    Console.WriteLine("Introduce un número del 1 al 7 (o 0 para salir):"); 
    var dia = Console.ReadLine();
    // Si el nº es 0, salimos del programa
    if(dia == "0") { 
        Console.WriteLine("Hasta Luego!");
        break;
    }
    // Si el nº está entre 1 y 7, escribimos el día correspondiente de la semana y 
    // si es otro nº o carácter, escribimos 'Día no válido'.
    switch (dia) { 
        case "1":
            nombredia = "Lunes";
            break;
        case "2":
            nombredia = "Martes";
            break;
        case "3":
            nombredia = "Miércoles";
            break;
        case "4":
            nombredia = "Jueves";
            break;
        case "5":
            nombredia = "Viernes";
            break;
        case "6":
            nombredia = "Sábado";
            break;
        case "7":
            nombredia = "Domingo";
            break;
        default:
            nombredia = "Día no válido";
            break;
    }
    Console.WriteLine(nombredia); // Salida del nombre del día (o del error)
}


