using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("                                        Made by"); Thread.Sleep(500);
        Console.WriteLine();
        Console.Write("                                  Anonym");Thread.Sleep(800);Console.Write("Soft "); Thread.Sleep(800); Console.Write("Studio"); Thread.Sleep(1000);
        Console.Clear();
        
        for (byte i = 0; ; i++)
        {
            Console.WriteLine("1. CORONAVIRUS TEST");
            Console.WriteLine("2. PREGNANCY TEST");
            Console.WriteLine("3. EXIT");
            byte test_choose = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            if (test_choose == 1)
            {
                Console.WriteLine("WARNING! YOUR ANSWER MUST BE YES OR NO");
                Console.WriteLine("Loading...");
                Thread.Sleep(2500);
                Console.Clear();
                Console.WriteLine("Czy masz goraczke?");
                string fever = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Czy masz biegunke?");
                string diarrhea = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Czy masz zapalenie spojowek?");
                string eyes = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Czy utraciles smak lub wech?");
                string taste = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Czy masz trudnosci w oddychaniu lub dusznosci?");
                string breath = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Coronavirus diagnosis = new Coronavirus(fever, diarrhea, eyes, taste, breath);
                Console.WriteLine("Loading...");
                Thread.Sleep(2500);
                Console.Clear();
                diagnosis.Diagnosis();
                Console.WriteLine("nacisnij ENTER aby przejsc dalej");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            else if (test_choose == 2)
            {
                for (byte j = 0; ; j++)
                {
                    Console.WriteLine("Wybierz swoja plec");
                    Console.WriteLine("1. Male");
                    Console.WriteLine("2.Female");
                    byte sex = Convert.ToByte(Console.ReadLine());
                    Console.Clear();
                    if (sex == 1)
                    {
                        Console.WriteLine("Nie jestes w ciazy!");
                        Console.WriteLine("nacisnij ENTER aby przejsc dalej");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else if (sex == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("WARNING! YOUR ANSWER MUST BE YES OR NO");
                        Console.WriteLine("Loading...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        Console.WriteLine("Czy spoznia sie Pani miesioczka?");
                        string period = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Czy zauwazyla Pani zmiany w swoich piersiach?");
                        string breasts = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Czy czuje Pani ostatnio zmeczenie czesciaj niz zwykle?");
                        string tired = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Czy ma Pani poranne mdlosci?");
                        string nausea = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Czy ma Pani czestrze wymioty ostatnio?");
                        string vomiting = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Czy korzysta Pani otatnio czesciej niz zwykle z toalety?");
                        string toilet = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Czy ma Pani wachania nastroju?");
                        string mood = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Czy w ostatnim czasie ma Pani czesto zmieniajace sie dziwne zachcianki oraz wrazliwosc na zapachy?");
                        string whims = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Czy ma Pani ostatnio czeste skorcze?");
                        string contractions = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        Pregnancy diagnosis = new Pregnancy(period, breasts, tired, nausea, vomiting, toilet, mood, whims, contractions);
                        Console.WriteLine("Loading...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        diagnosis.Diagnosis();
                        Console.WriteLine("nacisnij ENTER aby przejsc dalej");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorect choise!");
                    }
                }
                continue;
            }

            else if (test_choose == 3)
            {
                break;
            }

            else
            {
                Console.WriteLine("Incorrect choise!");
            }
        }
    }
}
class Pregnancy
{
    byte symptons=0;
    byte psymptons = 0;
    public Pregnancy(params string[] args)
    {
        for(byte j=0;j<args.Length;j++)
        {
            if(args[j]=="yes" || args[j] == "YES" || args[j] == "Yes" || args[j] == "tak" || args[j] == "TAK" || args[j] == "Tak")
            {
                this.symptons += 1;
            }
        }
        if(args[0]== "yes" || args[0] == "YES" || args[0] == "Yes" || args[0] == "tak" || args[0] == "TAK" || args[0] == "Tak")
        {
            this.psymptons += 1;
        }
        if (args[3] == "yes" || args[3] == "YES" || args[3] == "Yes" || args[3] == "tak" || args[3] == "TAK" || args[3] == "Tak")
        {
            this.psymptons += 1;
        }
        if (args[4] == "yes" || args[4] == "YES" || args[4] == "Yes" || args[4] == "tak" || args[4] == "TAK" || args[4] == "Tak")
        {
            this.psymptons += 1;
        }
        if (args[7] == "yes" || args[7] == "YES" || args[7] == "Yes" || args[7] == "tak" || args[7] == "TAK" || args[7] == "Tak")
        {
            this.psymptons += 1;
        }
    }

    public void Diagnosis()
    {
        if(psymptons==0)
        {
            Console.WriteLine("Nie jest Pani w ciazy!");
        }

        else if(psymptons==4)
        {
            Console.WriteLine("Jest Pani w ciazy!");
        }
        else
        {
            if (this.symptons == 0)
            {
                Console.WriteLine("Nie jest Pani w ciazy!");
            }

            else if (this.symptons == 9)
            {
                Console.WriteLine("Jest Pani w ciazy!");
            }

            else if (this.symptons > 0 && this.symptons < 5)
            {
                Console.WriteLine("Jest mala szansa ze jest Pani w ciazy!");
            }

            else
            {
                Console.WriteLine("Jest bardzo duza szanasa ze jest Pani w ciazy!");
            }
        }
    }
}

class Coronavirus
{
    byte symptons=0;
    public Coronavirus(params string[] args)
    {
        for(byte i=0;i<args.Length;i++)
        {
            if (args[i] == "yes" || args[i] == "YES" || args[i] == "Yes" || args[i] == "tak" || args[i] == "TAK" || args[i] == "Tak")
            {
                this.symptons += 1;
                continue;
            }
            else
                continue;
        }
    }

    public void Diagnosis()
    {
        if(this.symptons==0)
        {
            Console.WriteLine("Nie masz koronawirusa");
        }
        else if(this.symptons>0 && this.symptons<3)
        {
            Console.WriteLine("Jest szansa ze masz koronawirusa");
        }
        else
        {
            Console.WriteLine("Prawdopodobnie masz koronawirusa");
        }
    }
}