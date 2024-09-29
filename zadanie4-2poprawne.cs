/*Napisz program, który wczytuje liczbę od użytkownika i oblicza jej pierwiastek kwadratowy. Program
powinien obsługiwać wyjątek związany z niepoprawnym formatem liczby oraz wyjątek związany z obliczaniem
pierwiastka kwadratowego z liczby ujemnej. [odp_02.cs]*/

using System;

class Program
{
    static void Main()
    {
        // poprawne wyświetlanie polskich znaków
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double x = 0;
        bool isValidInput = false;  // określanie poprawności wporawdzonej liczby

        while (!isValidInput)
        {
            try
            {
                // podajesz liczbę i program sprawdza czy jest w dobrym formacie
                Console.Write("Podaj liczbę: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))  // sprawdzamy,czy coś zostało wpisane
                {
                    Console.WriteLine("Nie wprowadzono liczby. Spróbuj ponownie.");
                    continue;  // jeśli nic nie wpisano, zapętla się do początku
                }

                x = Convert.ToDouble(input);  // konwertowanie tekstu na liczbę

                // sprawdzenie czy liczba jest ujemna
                if (x < 0)
                {
                    throw new ArgumentException("Nie można obliczyć pierwiastka kwadratowego z liczby ujemnej.");
                }

                isValidInput = true;  // Jeśli wszystko jest OK, ustawiamy flagę na true, aby wyjść z pętli
            }
            // obsługa wyjątku gdy liczba ma niepoprawny format
            catch (FormatException ex)
            {
                Console.WriteLine($"Niepoprawny format liczby: {ex.Message}");
            }
            // obsługa wyjątku gdy liczba jest ujemna
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            // obsługa innych nieoczekiwanych błędów
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
            }
        }

        // liczenie i podanie wyniku
        double wynik = Math.Sqrt(x);
        Console.WriteLine($"Pierwiastek kwadratowy z {x} wynosi {wynik:F2}");
    }
}