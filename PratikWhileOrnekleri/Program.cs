
// 10 kere tanımlı yazıyı ekrana yazdırma
int x = 0;
while(x != 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    x++;
}
Console.WriteLine("---------------------------------------------------\n----------------------------------");
// 0 ile 20 arasındaki sayıları ekrana yazdırma
int sayı = 0;
while (sayı!= 21)
{
    Console.WriteLine(sayı);
    sayı++;
}

Console.WriteLine("---------------------------------------------------\n----------------------------------");

//0 ile 20 arasındaki çift sayıları ekrana yazdırma
int sayı2 = 0;
while (sayı2 != 20)
{
    Console.WriteLine(sayı2);
    sayı2 += 2;
}
Console.WriteLine("---------------------------------------------------\n----------------------------------");

// 50 ile 150 sayıları arasındaki sayıların toplamanı ekrana yazdırma
int sayı3  = 50;
int toplam = 0;
while (sayı3 != 150)
{

    toplam += sayı3;
    sayı3++;
}
Console.WriteLine(toplam);
Console.WriteLine("---------------------------------------------------\n----------------------------------");

// 0 ile 120 arasında çift sayıların toplamını ekrana yazdırma

int sayı4 = 0;
int cifttoplam = 0;
while(sayı4 !=120)
{
    cifttoplam += sayı4;
    sayı4+=2;
        
}
Console.WriteLine(cifttoplam);
Console.WriteLine("---------------------------------------------------\n----------------------------------");
// 0 ile 120 arasındaki tek sayıları ekrana yazdırma
int sayı5  = 1;
int tektoplam = 0;

while (sayı5 !=121)
{
    tektoplam += sayı5;
    sayı5 += 2;
}
Console.WriteLine(tektoplam);