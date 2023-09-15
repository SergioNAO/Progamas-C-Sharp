Random random = new Random();
int diasparaExpirar = random.Next(12);
int porcentajeDescuento = 0;

Console.WriteLine(diasparaExpirar);
if(diasparaExpirar == 0){
    Console.WriteLine("Tu Suscripcion Expiro!!");
}
else if(diasparaExpirar == 1){
    Console.WriteLine("Tu Suscripcion Expira en un dia!!");
    porcentajeDescuento = 20;
}
else if(diasparaExpirar <= 5){
    Console.WriteLine($"Tu Suscripcion expira en {diasparaExpirar} dias.");
    porcentajeDescuento = 10;
}
else if(diasparaExpirar <= 10){
    Console.WriteLine("Tu Suscripcion expira pronto\n Renuevala Ahora!!");
}

if(porcentajeDescuento > 0){
    Console.WriteLine($"Renueva Ahora y Obten un {porcentajeDescuento}% de Descuento!");
}


