using System;

public class Ex2
{
    public static void Main()
    {
        int[] tab = new int[10];
        int i, n, p = 0, val;
        Console.Write("\n\n insère un entier dans son emplacement adéquat dans un tableau trié :\n");
        Console.Write("-----------------------------------------\n");

        Console.Write("Entrez la taille du tableau: ");
        n = Convert.ToInt32(Console.ReadLine());
        /* stocker les valeurs dans le tableau*/
        Console.Write("Entrez {0} element en ordre croissant:\n", n);
        for (i=0; i<n; i++)
        {
            Console.Write("element - {0} : ", i);
            tab[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Entrez la nouvelle valeur qu'on veut inserer : ");
        val = Convert.ToInt32(Console.ReadLine());
        Console.Write("le tableau avant l'insertion de la nouvelle valeur :\n ");
        for (i=0; i<n; i++)
            Console.Write("{0} ", tab[i]);
        /* Determnier la position du valeur qu'on veut inserer.*/
        for (i=0; i<n; i++)
            if (val<tab[i])
            {
                p = i;
                break;
            }
        /* decaler les nombres dans le cote droite */
        for (i=n; i>=p; i--)
            tab[i]= tab[i-1];
        /* insert value at the proper position */
        tab[p]=val;

        Console.Write("\n\nApres l'insertion :\n ");
        for (i=0; i<=n; i++)
            Console.Write("{0} ", tab[i]);
        Console.Write("\n");
        Console.ReadKey();
    }
}
