bool visible = true;
//while (true) 
//Console.WriteLine("Alphabet A : \n");
do
{
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 1; j <= 5; j++)
        {
            Console.ForegroundColor = visible ? ConsoleColor.Blue : ConsoleColor.Green;
            visible = !visible;
            //Console.Clear();
            string A = (i == 1 || i == 3 || j == 1 || j == 5) ? "*" : " ";
            visible = !visible;
            System.Console.Write(A);
        }
        System.Console.WriteLine();
        //Console.Clear();
    }
    Thread.Sleep(250); Console.Clear();
} while (true);





 
/*int n = 1;
while (true)

    Console.WriteLine(n = n + 1);
*/
