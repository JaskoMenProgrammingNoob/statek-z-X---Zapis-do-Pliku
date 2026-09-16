using System;
using System.IO;
class Program
{
    static void Main()
    {
        int szerokosc = 51;
        int wysokosc = 25;

        FileStream F = new FileStream("statek.txt", FileMode.Create);

        for (int i = 0; i < wysokosc; i++)
        {
            for (int j = 0; j < szerokosc; j++)
            {
                // Górna część
                if (i == 0 && j >= 24 && j <= 26)
                F.WriteByte((byte)'X');

                else if (i == 1 && j >= 22 && j <= 28)
                    F.WriteByte((byte)'X');

                else if (i == 2 && j >= 20 && j <= 30)
                    F.WriteByte((byte)'X');

                // Kabina
                else if (i >= 3 && i <= 7 &&
                (j == 18 || j == 32))
                    F.WriteByte((byte)'X');

                else if (i == 3 && j >= 18 && j <= 32)
            F.WriteByte((byte)'X');

        else if (i == 7 && j >= 18 && j <= 32)
            F.WriteByte((byte)'X');
                // Kadłub
                else if (i >= 8 && i <= 15 && j >= 10 && j <= 40 )
                    F.WriteByte((byte)'X');
                // Skrzydła
                else if ( i >= 12 && i <= 18 && (j >= 3 && j <= 9 || j >= 41 && j <= 47))
                    F.WriteByte((byte)'X');
                // Dolna część
                else if( i >= 16 && i <= 19 && j >= 15 && j <= 35 )
                    F.WriteByte((byte)'X');
                // Silnik
                else if(i >= 20 && i <= 21 && (j >= 15 && j <= 19 || j >= 23 && j <= 27 || j >= 31 && j <= 35))
                    F.WriteByte((byte)'X');
                // Napęd
                else if(i == 22 && (j >= 16 && j <= 18 || j >= 24 && j <= 26 || j >= 32 && j <= 34))
                    F.WriteByte((byte)'|');
                else if( i == 23 && (j >= 15 && j <= 19 || j >= 23 && j <= 27 || j >= 31 && j <= 35))
                    F.WriteByte((byte)'V');
                else if (i == 24 && (j >= 16 && j <= 18 || j >= 24 && j <= 26 || j >= 32 && j <= 34))
                    F.WriteByte((byte)'v');
                else
                            F.WriteByte((byte)' ');
    }

    F.WriteByte((byte)'\n');
        }

F.Close();

F = new FileStream("statek.txt", FileMode.Open);

for (int i = 0; i < wysokosc; i++)
{
    for (int j = 0; j < szerokosc; j++)
    {
        Console.Write((char)F.ReadByte());
    }

    F.ReadByte();
    Console.WriteLine();
}

F.Close();
    }
}
 