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
            string[] array = new string[100];                                           // Dichiarazione array di tipo stringa 'array'
            string e;                                                                   // Dichiarazione variabile di tipo stringa 'e'
            int dim = 0;                                                                // Dichiarazione variabile di tipo intero 'dim'
            int scelta;                                                                 // Dichiarazione variabile di tipo intero 'scelta'

            // Elaborazione
            // Struttura menù
            do                                                                          // Esegui...
            {
                // Stampa opzioni
                Console.Clear();                                                        // Pulizia contenuto console
                Console.WriteLine("Seleziona un'opzione:\n1 - Aggiunta\n2 - Cancella\n3 - Ordinamento (alfabeitco)\n4 - Ricerca sequenziale\n5 - Visualizza ripetuti\n6 - Modifica nome\n7 - Visualizzazione array\n8 - Ricerca nome più lungo e più corto, visualizzazione\n9 - Cancella tutti elementi uguali\n0 - Uscita");         // Stampa messaggi selezione casi
                Console.WriteLine();                                                    // A capo
                Console.Write("Inserisci la scelta: ");                                 // Scelta opzione
                scelta = Convert.ToInt32(Console.ReadLine());                           // Input variabile 'scelta'
                // Esecuzione opzioni
                switch (scelta)                                                         // Selezione casi in base al valore della variabile 'scelta'
                {
                    default:                                                            // Se 'scelta' non corrisponde a nessun valore dei casi
                        Console.WriteLine("Opzione non valida!");                       // Stampa 'Opzione non valida!'
                        break;                                                          // Interrompi esecuzione
                    case 1:
                        Console.WriteLine("Inserire elemento: ");
                        e = Console.ReadLine();
                        if (Aggiunta(e, array, ref dim) == true)                        // Se chiamata funzione 'Aggiunta' restituisce 'true'
                        {
                            Console.WriteLine("Elemento inserito correttamente!");      // Stampa 'Elemento inserito correttamente!'
                        }
                        else                                                            // ...altrimenti...
                        {
                            Console.WriteLine("Array pieno!");                          // Stampa 'Array pieno!'
                        }
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
                        for (int i = 0; i < dim; i++)                                   // Ciclo stampa array
                        {
                            Console.Write(array[i] + " ");                              // Stampa array
                        }
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
        // Funzioni
        // Aggiunta di un nome;
        static bool Aggiunta(string e, string[] array, ref int index)                   // Funzione 'Aggiunta' per aggiungere elementi all'array
        {
            bool agg = true;
            if (index < array.Length)                                                   // Se è stata raggiunta la dimensione massima dell'array           
            {
                array[index] = e;                                                       // Aggiungere l'elemento
                index++;                                                                // Incremento indice
            }
            else                                                                        // ...altrimenti...
            {
                agg = false;                                                            // Assegnazione 'false' alla variabile 'agg'
            }
            return agg;                                                                 // Restiruire 'agg'
        }
        // Cancellazione del singolo nome;
        // Ordinamento dei nomi (BubbleSort);
        // Ricerca sequenziale;
        // Visualizza nomi ripetuti con numero ripetizioni;
        // Modifica di un nome;
        // Visualizzazione di tutti i nomi presenti;
        // Ricerca del nome più lungo e più corto;
        // Cancellazione di tutte le occorrenze di un nome;
    }
}
