Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1+roll2+roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    if((roll1 == roll2) && (roll2 == roll3)){
    Console.WriteLine("Obtuviste 3 numeros iguales! \nTendras un bono de +6 puntos en el Total");
    total +=6;
    Console.WriteLine("Ahora el Total de puntos es: "+total);
    }
    else{
    Console.WriteLine("Obtuviste numeros iguales! \nTendras un bono de +2 puntos en el Total!");
    total +=2;
    Console.WriteLine("Ahora el Total de puntos es: "+total);
    }
}

if(total >= 16){
    Console.WriteLine("Ganaste un Auto!!");
}
else if(total >=10){
    Console.WriteLine("Ganaste una Laptop!!");
}
else if(total == 7){
    Console.WriteLine("Ganaste un Viaje!!");
}
else{
    Console.WriteLine("Ganaste un Gatito!!");
}