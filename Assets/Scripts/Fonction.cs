using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonction : MonoBehaviour
{
    // Start is called before the first frame update
    public int nombre;
    public string nprenom;
    public int sommeFunction;
    void Start()
    {
        // nombre = maFonction(89);       
        // print("nombre " + nombre);
        // nprenom = maString("Olivier");
        // print("pstart " + nprenom);
        // affichage("Corinne",24);
        // affichage(nprenom,39);
        sommeFunction = calculSomme(50,300);
        print(sommeFunction);
    }

#region mafonction
    public int maFonction(int nchiffre)
    {
        return nchiffre*5;
    }
#endregion
    public int calculSomme(int nb1, int nb2)
    {
        return  nb1 + nb2;
        
    }
    public string maString(string nom)
    {
        return nom;
    }

    public void affichage(string prenom, int age)
    {
        print("prenom : " + prenom + " j'ai " + age + "ans" );
        
    }


}