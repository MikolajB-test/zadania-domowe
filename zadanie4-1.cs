/*Zadanie 1. Napisz program, który próbuje odczytać zawartość pliku tekstowego. Program powinien obsługiwać
wyjątek związany z brakiem pliku oraz wyjątek związany z błędami odczytu. [odp_01.cs]*/

using System;

class Program
{
    static void Main()
     {
            //deklaracja zmiennej reader służącej do odczytu pliku, null umożliwia nam późniejsze sprawdzenie czy utworzono obiekt
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.IO.StreamReader reader = null;
        

        try
        {
            //próba odczytu pliku "plikdoodczytu.txt"
            reader = new System.IO.StreamReader("plikdoodczytu.txt");
            Console.WriteLine(reader.ReadToEnd());
        }
        //błąd wyskakujący gdy plik nie został znaleziony
        catch (System.IO.FileNotFoundException ex)
        {
            Console.WriteLine($"blad: plik nie zostal znaleziony! {ex.Message}");
        }
        finally
        {
            //sprawdzenie poprawności utworzenia pliku
            if (reader != null)
            {
                reader.Close();
                Console.WriteLine("plik zostal zamnkniety");
            }
        }
    }
}