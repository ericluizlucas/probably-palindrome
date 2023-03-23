class sc
{
    public char letter;
    public int count;
}

class comp : Comparer<sc>
{
    public override int Compare(sc? x, sc? y)
    {
        return (x.letter.CompareTo(y.letter));
    }
}

class Solver
{
    static bool Solve(string input)
    {
        if(input == "") return true;
        bool resp = false;
        char[] arr = input.ToCharArray();

        sc[] element = new sc[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            element[i] = new sc();
            element[i].letter = arr[i];
            element[i].count = 0;
        }



        element[0].count = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(i);
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (element[i].count != -1 && element[j].count != -1)
                {
                    if (element[i].letter == element[j].letter)
                    {
                        element[i].count += 1;
                        element[j].count = -1;
                    }
                    else
                    {
                        element[j].count = 1;
                    }
                }

            }


        }

        int qttOdd = 0;
        for (int k = 0; k < element.Length; k++)
        {

            if (element[k].count != -1 && element[k].count % 2 != 0) qttOdd += 1;

            Console.WriteLine(element[k].letter + " " + element[k].count);
        }
        Console.WriteLine(qttOdd);

        if(qttOdd <= 1) resp = true;

        return resp;
    }

    public static void Main()
    {
        string input = "abbac";
        bool resp = Solve(input);

        Console.WriteLine(resp);
    }

}



