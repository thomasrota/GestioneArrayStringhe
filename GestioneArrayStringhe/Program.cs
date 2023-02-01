using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneArrayStringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dichiarazioni
            int scelta;                                                                 // Dichiarazione variabile di tipo intero 'scelta'

            // Elaborazione
            // Struttura menù
            do                                                                          // Esegui...
            {
                // Stampa opzioni
                Console.Clear();                                                        // Pulizia contenuto console
                Console.WriteLine("1 - Aggiunta\n2 - Cancella\n3 - Ordinamento (alfabeitco)\n4 - Ricerca sequenziale\n5 - Visualizza ripetuti\n6 - Modifica nome\n7 - Visualizzazione array\n8 - Ricerca nome più lungo e più corto, visualizzazione\n9 - Cancella tutti elementi uguali\n0 - Uscita");         // Stampa messaggi selezione casi
                Console.WriteLine();                                                    // A capo
                Console.Write("Inserisci la scelta: ");                                 // Scelta opzione
                scelta = Convert.ToInt32(Console.ReadLine());                           // Input variabile 'scelta'
                // Esecuzione opzioni
                switch (scelta)                                                         // Selezione casi in base al valore della variabile 'scelta'
                {
                    default:                                                            // Se 'scelta' non corrisponde a nessun valore dei casi
                        Console.WriteLine("Opzione non valida!");                       // Stampa 'Opzione non valida!'
                        break;                                                          // Interrompi esecuzione
                    case 1:                                                             // Se 'scelta' uguale ad 1
                        break;                                                          // Interrompere esecuzione
                    case 2:                                                             // Se 'scelta' uguale ad 2
                        break;                                                          // Interrompere esecuzione
                    case 3:                                                             // Se 'scelta' uguale a 3
                        break;                                                          // Interrompere esecuzione
                    case 4:                                                             // Se 'scelta' uguale a 4
                        break;                                                          // Interrompere esecuzione
                    case 5:                                                             // Se 'scelta' uguale a 5
                        break;                                                          // Interrompere esecuzione
                    case 6:                                                             // Se 'scelta' uguale a 6
                        break;                                                          // Interrompere esecuzione
                    case 7:                                                             // Se 'scelta' uguale a 7
                        break;                                                          // Interrompere esecuzione
                    case 8:                                                             // Se 'scelta' uguale a 8
                        break;                                                          // Interrompere esecuzione
                    case 9:                                                             // Se 'scelta' uguale a 9
                        break;                                                          // Interrompere esecuzione
                    case 0:                                                             // Se 'scelta' uguale a 0
                        Environment.Exit(1);                                            // Uscita programma
                        break;                                                          // Interrompere esecuzione
                }
                Console.ReadKey();                                                      // Attesa un'azione da parte dell'utente prima di continuare l'esecuzione
            } while (scelta != 0);                                                      // ...mentre variabile 'scelta' è diversa da 0
        }
    }
}
