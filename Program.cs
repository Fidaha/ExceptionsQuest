using LesExceptions.Models;

namespace LesExceptions
{
    public class Program
    {
        static void ThrowError()
        {
            throw new CustomException("Hafida ? On a un problème !");
        }
        public static void Main(string[] args)
        {

            try
            {
                // Appel de la fonction ThrowError() englobée dans un try/catch
                ThrowError();
            }
            catch (CustomException ex)
            {
                // Affichage de la date et du message de l'exception dans la console

                Console.WriteLine($"Date de l'exception : {ex.TimeRaised}");
                Console.WriteLine($"Message de l'exception : {ex.Message}");
            }


        }
    }
}