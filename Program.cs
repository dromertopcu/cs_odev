// 1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
// 2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
// 3- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
// 4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
//
//
//****************** Çift Olan Sayılar ******************//

Console.WriteLine("Lütfen pozitif bir sayı giriniz :");
int dongu = int.Parse(Console.ReadLine());
Console.WriteLine($"Lütfen {dongu} adet pozitif sayı giriniz :");
int[] sayilar = new int[dongu];
for(int i = 0;i< dongu;i++)
{
    sayilar[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("***** Çift olan Sayılar *****");
foreach(int sayi in sayilar)
{
    if(sayi%2 == 0)
    {
        Console.WriteLine(sayi) ;
    }
}


//****************** m ile Bölünen Sayılar ******************//

Console.WriteLine("Lütfen bir boşluk bırakarak iki adet pozitif sayı giriniz :");
string[] dizi = Console.ReadLine().Split(" ");

Console.WriteLine($"Aralarında boşluk bırakarak {dizi[0]} adet pozitif sayı giriniz :");
string[] sayilar2 = Console.ReadLine().Split(" ");

Console.WriteLine($"***** {dizi[1]} ile Bölünen Sayılar***** ");
foreach(var sayi in sayilar2)
{
    int s = int.Parse(sayi);
    if(s % int.Parse(dizi[1]) == 0)
        Console.WriteLine(s); 
}

//****************** Sondan Başa Doğru Yazılan Kelimeler ******************//

Console.WriteLine("Lütfen pozitif bir sayı giriniz :");
int adet = int.Parse(Console.ReadLine());

Console.WriteLine($"Lütfen aralarında boşluk bırakarak {adet} adet kelime giriniz :");
string[] kelimeler = Console.ReadLine().Split(" ");

Console.WriteLine("***** Sondan Başa Doğru Yazdığınız Kelimeler *****");

for(int i = adet-1;i>=0;i--)
{
    Console.WriteLine(kelimeler[i]);
}


//****************** Toplam Kelime ve Harf Sayısı ******************//

Console.WriteLine("Lütfen bir cümle yazınız :");
string cumle = Console.ReadLine();
cumle = cumle.Trim(',','.',' ');
string[] kelimeler2 = cumle.Split(" ");
foreach(string item in kelimeler2)
    Console.WriteLine(item);
int kelimeSayisi = kelimeler2.Count();

cumle = cumle.Replace(" ","");
int harfSayisi = cumle.Count();
Console.WriteLine("***** Toplam Kelime ve Harf Sayısı *****");

Console.WriteLine($"Toplam Kelime Sayısı : {kelimeSayisi}");

Console.WriteLine($"Toplam Harf Sayısı : {harfSayisi}");