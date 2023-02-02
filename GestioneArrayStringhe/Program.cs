using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
                        Console.ForegroundColor = ConsoleColor.Red;                     // Imposta colore carattere a rosso
                        Console.WriteLine("Opzione non valida!");                       // Stampa 'Opzione non valida!'
                        Console.ResetColor();                                           // Reimposta colore
                        break;                                                          // Interrompi esecuzione
                    case 1:
                        Console.Write("Inserire elemento: ");                           // Stampa 'Inserire elemento: '
                        e = Console.ReadLine();                                         // Input variabile 'e'
                        if (Aggiunta(e, array, ref dim) == true)                        // Se chiamata funzione 'Aggiunta' restituisce 'true'
                        {
                            Console.ForegroundColor = ConsoleColor.Green;               // Imposta colore carattere a verde
                            Console.WriteLine("Elemento inserito correttamente!");      // Stampa 'Elemento inserito correttamente!'
                            Console.ResetColor();                                       // Reimposta colore
                        }
                        else                                                            // ...altrimenti...
                        {
                            Console.ForegroundColor = ConsoleColor.Red;                 // Imposta colore carattere a rosso
                            Console.WriteLine("Array pieno!");                          // Stampa 'Array pieno!'
                            Console.ResetColor();                                       // Reimposta colore
                        }
                        break;                                                          // Interrompere esecuzione
                    case 2:                                                             // Se 'scelta' uguale ad 2
                        Console.Write("Inserire elemento che si desidera eliminare: "); // Stampa 'Inserire elemento che si desidera eliminare:'
                        e = Console.ReadLine();                                         // Input variabile 'e'
                        if (CancellaSingolo(e, array, ref dim) == true)                 // Se chiamata funzione 'Cancella' restituisce 'true'
                        {
                            Console.ForegroundColor = ConsoleColor.Green;               // Imposta colore carattere a verde
                            Console.WriteLine("Elemento cancellato correttamente!");    // Stampa 'Elemento cancellato correttamente!'
                            Console.ResetColor();                                       // Reimposta colore
                        }
                        else                                                            // Altrimenti
                        {
                            Console.ForegroundColor = ConsoleColor.Red;                 // Imposta colore carattere a rosso
                            Console.WriteLine("Elemento non eliminato correttamente!"); // Stampa 'Elemento non eliminato correttamente!'
                            Console.ResetColor();                                       // Reimposta colore
                        }
                        break;                                                          // Interrompere esecuzione
                    case 3:                                                             // Se 'scelta' uguale a 3
                        BubbleSort(array, ref dim);                                     // Chiamata funzione 'BubbleSort'
                        Thread.Sleep(1000);                                             // Attesa esecuzione di 1 secondo
                        Console.ForegroundColor = ConsoleColor.Green;                   // Imposta colore carattere a verde
                        Console.WriteLine("L'array è stato ordinato correttamente!");   // Stampa 'L'array è stato ordinato correttamente!'
                        Console.ResetColor();                                           // Reimposta colore
                        break;                                                          // Interrompere esecuzione
                    case 4:                                                             // Se 'scelta' uguale a 4
                        Console.Write("Inserire elemento da ricercare: ");              // Stampa 'Inserire elemento da ricercare:'
                        e = Console.ReadLine();                                         // Input variabie 'e'
                        if (RicercaSeq(e, array) == -1)                                 // Se valore resituito dalla funziome 'RicercaSeq' equivale a -1
                        {
                            Console.ForegroundColor = ConsoleColor.Red;                 // Imposta colore carattere a rosso
                            Console.WriteLine("Elemento non trovato!");                 // Stampa 'Elemento non trovato!'
                            Console.ResetColor();                                       // Reimposta colore
                        }
                        else                                                            // Altrimenti
                        {
                            Console.ForegroundColor = ConsoleColor.Green;               // Imposta colore carattere a verde
                            Console.WriteLine($"Elemento '{e}' trovato in posizone " + RicercaSeq(e, array));    // Stampa 'Elemento '{e}' trovato in posizone ' + posizione elemento (restituita dalla funzione)
                            Console.ResetColor();                                       // Reimposta colore
                        }
                        break;                                                          // Interrompere esecuzione
                    case 5:                                                             // Se 'scelta' uguale a 5
                        Console.Write("Inserire l'elemento: ");                         // Stampa 'Inserire l'elemento: '
                        e = Console.ReadLine();                                         // Input variabile 'e'
                        if (NumeroRipet(e, array) != 0)                                 // Se il valore resituito dalla funzione 'NumeroRipet' è diverso da 0
                        {
                            Console.ForegroundColor = ConsoleColor.Green;               // Imposta colore carattere a verde
                            Console.WriteLine($"L'elemento '{e}' si ripete per " + NumeroRipet(e, array) + " volta/e");  // Stampa 'L'elemento '{e}' si ripete per " + valore resituito dalla funzione 'NumeroRipet' + " volta/e'
                            Console.ResetColor();                                       // Resetta colore
                        }
                        else                                                            // Altrimenti
                        {
                            Console.ForegroundColor = ConsoleColor.Red;                 // Imposta colore carattere a rosso
                            Console.WriteLine($"L'elemento '{e}' non è presente nell'array");  // Stampa 'L'elemento '{e}' non è presente nell'array'
                            Console.ResetColor();                                       // Resetta colore
                        }
                        break;                                                          // Interrompere esecuzione
                    case 6:                                                             // Se 'scelta' uguale a 6
                        break;                                                          // Interrompere esecuzione
                    case 7:                                                             // Se 'scelta' uguale a 7
                        Visualizza(array, ref dim);                                     // Chiamata funzione 'Visualizza'
                        break;                                                          // Interrompere esecuzione
                    case 8:                                                             // Se 'scelta' uguale a 8
                        break;                                                          // Interrompere esecuzione
                    case 9:                                                             // Se 'scelta' uguale a 9
                        Console.Write("Inserire l'elemento: ");                         // Stampa 'Inserire l'elemento:'
                        e = Console.ReadLine();                                         // Input varibile 'e'
                        if (CancellaOcc(e, array, ref dim) == true)                     // Se valore restituiro dalla funzione 'CancellaOcc' è 'true'
                        {
                            Console.ForegroundColor = ConsoleColor.Green;               // Imposta colore carattere a verde
                            Console.WriteLine("Tutte le occorrenze sono state cancellate correttamente!");  // Stampa 'Tutte le occorrenze sono state cancellate correttamente!'
                            Console.ResetColor();                                       // Resetta colore
                        }
                        else                                                            // Altrimenti
                        {
                            Console.ForegroundColor = ConsoleColor.Red;                 // Imposta colore carattere a rosso
                            Console.WriteLine("Errore! Occorrenze non canellate correttamente!");   // Stampa 'Errore! Occorrenze non canellate correttamente!'
                            Console.ResetColor();                                       // Resetta colore
                        }
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
            bool agg = true;                                                            // Dichiarazioe variabile 'agg'
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
        static bool CancellaSingolo(string e, string[] array, ref int dim)              // Funzione 'CancellaSingolo' per cancellare un singolo elemento dall'array
        {
            bool cancellatos = false;                                                   // Dichiarazione variabile 'cancellatos'
            for (int i = 0; i < array.Length; i++)                                      // Ciclo
            {
                if (array[i] == e)                                                      // Condizione per verificare che a 'i' sia presente 'e'
                {
                    dim--;                                                              // Diminuzione variabile 'dim'
                    for (int j = i; j < array.Length - 1; j++)                          // Ciclo per spostare di una posizione indietro tutti i valori dopo la posizione del valore eliminato
                    {
                        array[j] = array[j + 1];                                        // Assegnazione all'elemento in posizione 'j' l'elemento successivo
                    }
                    cancellatos = true;                                                 // Assegnazione alla variabile 'cancellatos' il valore 'true'
                    break;                                                              // Interruzione esecuzione
                }
            }
            return cancellatos;                                                         // Restituisci 'cancellatos'
        }
        // Ordinamento dei nomi (BubbleSort);
        static void BubbleSort(string[] array, ref int dim)                             // Funzione 'BubbleSort' per ordinare gli elementi dell'array
        {
            int x, y;                                                                   // Dichiarazione variabili tipo intero 'x' e 'y'
            string temp;                                                                // Dichiarazione variabile tipo stringa 'temp'
            for (x = 0; x < dim - 1; x++)                                               // Ciclo per scorrerer tutto l'array
            {
                for (y = 0; y < dim - 1; y++)                                           // Ciclo confronto a coppie
                {
                    int comp = string.Compare(array[y], array[y + 1]);                  // Dichiarazione variabile 'comp' (string.Compare restituisce un intero che indica se la prima stringa è minore (-1), uguale (0) o maggiore (1) rispetto alla seconda stringa.)
                    if (comp == 1)                                                      // Se 'comp' uguale a '1'
                    {
                        temp = array[y];                                                // Salvataggio del elemento alla posizione 'y' dell'array in 'temp'
                        array[y] = array[y + 1];                                        // Scambio elemento successivo a 'y' nella posizione 'y'
                        array[y + 1] = temp;                                            // Spostamento elemento contenuto in 'temp' nella posizione successiva a 'y'
                    } 
                }
            }
        }
        // Ricerca sequenziale;
        static int RicercaSeq(string e, string[] array)                                 // Funzione 'RicercaSeq' che cerca e restituisce la posizione di un elemento
        {
            int risultatoricerca = 0;                                                   // Dichiarazione variabile tipo intero 'risultatoricerca'
            for (int i = 0; i < array.Length; i++)                                      // Ciclo controllo presenza elemento ricercato
            {
                if (array[i] == e)                                                      // Se elemento array in posizione 'i' è uguale a 'e' (elemento da ricercare)
                {
                    risultatoricerca = i;                                               // Assegnazione 'risultatoricerca' valore 'i'
                    break;                                                              // Interrompere esecuzione
                }
                else                                                                    // Altrimenti
                {
                    risultatoricerca = -1;                                              // Assegnazione a 'risultatoricerca' valore '-1'
                }
            }
            return risultatoricerca;                                                    // Restituisci 'risultatoricerca'
        }
        // Visualizza nomi ripetuti con numero ripetizioni;
        static int NumeroRipet(string e, string[] array)                                // Funzione 'NumeroRipet' che restituisce il numero di volte che si ripete il valore all'interno dell'array
        {
            int nr = 0;                                                                 // Dichiarazione variabile 'nr'
            for (int i = 0; i < array.Length; i++)                                      // Ciclo controllo che scorre l'array
            {
                if (array[i] == e)                                                      // Se l'elemento dell'array in posizione 'i' equivale all'elemento inserito ('e')
                {
                    nr++;                                                               // Incrementa variabile 'nr'
                }
            }
            return nr;                                                                  // Restituire 'nr'
        }
        // Modifica di un nome;
        // Visualizzazione di tutti i nomi presenti;
        static void Visualizza(string[]array, ref int dim)                              // Funzione 'Visualizza' per stampare l'array
        {
            for (int i = 0; i < dim; i++)                                               // Ciclo stampa array
            {
                Console.Write(array[i] + " ");                                          // Stampa array + spazio per distanziare gli elementi
            }
        }
        // Ricerca del nome più lungo e più corto;
        // Cancellazione di tutte le occorrenze di un nome;
        static bool CancellaOcc(string e, string[] array, ref int dim)                  // Funzione 'CancellaOcc' che cancella tutte le occorrenze di un elemento
        {
            bool canc = false;                                                          // Dichiarazione variabile 'canc'
            for (int i = 0; i < dim; i++)                                               // Ciclo che scorre tutt l'array
            {
                if (array[i] == e)                                                      // Se l'elemento dell'array alla posizione 'i' è uguale a 'e'
                {
                    dim--;                                                              // Decrementa 'dim'
                    for (int j = i; j < dim; j++)                                       // Ciclo che sposta tutti gli elementi successivi all'elemento cancellato una posizione indietro
                    {
                        array[j] = array[j + 1];                                        // Assegnazione all'elemento in posizione 'j' l'elemento successivo
                    }
                    i--;                                                                // Decrementa 'i'
                    canc = true;                                                        // Assegnazione valore 'true' alla variabile 'canc'
                }
            }
            return canc;                                                                // Restituire 'canc'
        }
    }
}