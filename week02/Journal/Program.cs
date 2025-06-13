using System;

class Program
{
    static void Main(string[] args)
    {
       string input;
       Journal A = new Journal();//aqui almaceno la entrada del usuario, y tambien para mostrar la estructura de mi coleccion en la opcion 2

       do
       {
        Console.WriteLine("1. write");
        Console.WriteLine("2. Display all");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load Jounal for name");
        Console.WriteLine("5. Quit");

        Console.Write("> ");
        input = Console.ReadLine();

            if (input == "1")
            {

                Entry i = new Entry(); // Esto me genera preguntas aleaorias 
                Shape p = new Shape(); //esto me guarda las listas 
                


                string ask = i.promtGenerator(); //esto llama a las preguntas random
                Console.WriteLine(ask);

                Console.Write("> ");
                 string answer = Console.ReadLine();
                
                p._prompt2 = ask;   //almaceno la informacion del usuario en estas variables de Entry
                p._answer = answer;// lo mismo a qui
                p._date = DateTime.Now.ToShortDateString();//y aqui

                A.AddEntry(p);                // Uso un metodo del programa Journal para guardar la informacion -
                Console.WriteLine("Save!");   // - de cada p. 
                Console.WriteLine();

            }
            else if (input == "2")
            {
                A.DisplayAll();
            }
            else if (input == "3")
            {
                Console.WriteLine("Put a name");
                Console.Write("> ");
                string filename = Console.ReadLine();
                filename += ".txt";                    //lo guardo en formato txt para que el usuario no tenga que escribir .txt a cada nombre
                A.SaveToFile(filename);

            }
            else if (input == "4")
            {
                Console.WriteLine("what title are you looking for? ");
                Console.Write("> ");
                string input2 = Console.ReadLine();
                input2 += ".txt";

                A.LoadFile(input2);

            }
            
            

       }while (input != "5");

       Console.WriteLine("Good Bye !");
    }
}