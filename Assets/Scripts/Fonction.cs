using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonction : MonoBehaviour
{
    // Start is called before the first frame update
    public int nombre;
    public string nprenom;
    public int sommeFunction;
    public int[] tableau1 = new int[]{5,6,8,9,1,3,4};

    public int iteration = 0;
    void Start()
    {
        // nombre = maFonction(89);       
        // print("nombre " + nombre);
        // nprenom = maString("Olivier");
        // print("pstart " + nprenom);
        // affichage("Corinne",24);
        // affichage(nprenom,39);
        //sommeFunction = calculSomme(50,300);
        // print(sommeFunction);
        // print(calculSomme(12,25));
        // print(isPair(5));
        // print(isPair(2));
        // print(isPair(19));
        print(removeVowel("hello"));
        print(removeVowel("how are you today?"));

    }

    /*
    #region mafonction
    public int maFonction(int nchiffre)
    {
        return nchiffre*5;
    }
    public string maString(string nom)
    {
        return nom;
    }

    public void affichage(string prenom ="Claudine", int age)
    {
        print("prenom : " + prenom + " j'ai " + age + "ans" );
        
    }
    #endregion
    
    #region calcul somme
    public int calculSomme(int nb1, int nb2)
    {
        return  nb1 + nb2;
        
    }
    #endregion
    

    #region isPair
    //ecrire une fonction qui prend un argument et renvoie 1 si impair et 0 si pair
    public int isPair(int nbP)
    {
        if(nbP % 2 == 0)
        {
            return 0;
        }
            return 1;
     }

    #endregion

    */

    #region replace vowel
    char[] charac;
    string[] vowels = new string[]{"A","a","E","e","I","i","O","o","U","u","Y","y"};
    string result;
    string test;
    public string removeVowel(string line)
    {
        charac = line.ToCharArray();
         for (int i = 0; i < charac.Length; i++)
         {
            test = "";
            test = test + charac[i];
            for(int y=0; y<vowels.Length; y++){
                if(vowels[y] == test)
            //  if(test == "A" || test == "a"
            //  || test == "E"|| test == "e"
            //  || test == "I"|| test == "i"
            //  || test == "O"|| test == "o"
            //  || test == "U"|| test == "u"
            //  || test == "Y"|| test == "y" )
             {
                charac[i] = ' ';
             }
            }
         }
        foreach(char ch in charac)
        {
            result = result + ch;
        }
        return result;
    }
    #endregion



}