// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp 
{
    class Program 
    {
        static void Main() 
        {      
            bool isNoWinner = false;
            while(!isNoWinner) {
                Program.DrawGame(Program.data);

                Program.SelectOnBoard(currentPlayer);

                isNoWinner = true;
            }
        }

        static void SelectOnBoard(string player) {
            int place = -1;
            do
            {   
                Console.WriteLine("Seleccione un número entre 1 y 9");
                try {
                    var response = Console.ReadLine();
                    if(response == null) throw new ArgumentNullException();
                    else place = Int32.Parse(response);
                }
                catch
                {
                    Console.WriteLine("Su respuesta no puede estar vacía");
                }
                if(place <= 1 || place > 9) Console.WriteLine("Debe seleccionar entre 1 y 9");

            } while(place < 1 || place > 9);
            
            data[place-1] = Program.currentPlayer;
            Program.DrawGame(Program.data);
            
        }

        static void DrawGame(string[] data)
        {
            Console.WriteLine(
                data[0] + " | " + data[1] + " | " + data[2] + "\n" +
                "---" + "---" + "---" + "---" + "\n" +
                data[3] + " | " + data[4] + " | " + data[5] + "\n" +
                "---" + "---" + "---" + "---" + "\n" +
                data[6] + " | " + data[7] + " | " + data[8]
            );
        }
        
        const string emptyCell = "  ";
        const string firstPlayer = " X ";
        const string secondPlayer = " O ";
        static string currentPlayer = firstPlayer;
        static string[] data = {Program.emptyCell, Program.emptyCell, Program.emptyCell, Program.emptyCell, Program.emptyCell, Program.emptyCell, Program.emptyCell, Program.emptyCell, Program.emptyCell};
    }
}

