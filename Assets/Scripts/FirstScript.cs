using System.Security.Cryptography;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //public = ouvert a unity et aux autres script
    public int nombre;

    //private = accessible seulement dans ce script
    private int nombre2 = 50;
    
    // est private par defaut
    int nombre3 = 69;
    int nombre4 = 5;

    public int somme;
    public string chaine;
    public string chaine1 = "et puis la suite";
    public int age;
    public string job;
    bool bac;
    
    

    // Start is called before the first frame update
     void Start()
    {
        nombre = 15 + 15;
        chaine = "une phrase dedans";
        print("affichage console");
        print(nombre2);
        somme = nombre3 + nombre4;
        //concatenation
        print("la somme " + somme);
        print("voila " + chaine + " " + chaine1);
        print($"hello c'est une phrase avec {chaine}");

        // incrementation
        nombre = nombre+1;
        
        // condition
        nombre = 15;
        if(nombre>15)
        {
            print("nombre supérieur à 15");
        } else if (nombre < 15)
        {
            print("nombre inférieur à 15");
            
        } 
        else
        {
            print("nombre égal à 15");
        };
        
        //exo
        age = 18;
        if(age>12 && age < 17)
        {
            print("vous êtes un ado");
        } else if (age <= 12)
        {
            print("Vous etes un enfant");
        } else {
            print("vous etes un adulte normalement");
        };
        
        //job = "gamer";
        //job = "dev";
        job = "baker";
        if(job == "gamer" || job == "dev")
        {
            print("vous pouvez passer");
        } else 
        {
            print("You Shall Not Pass!");
        }

        //Boucle

        //tant que
        /*
        while(nombre<=100)
        {
            print("nombre = " + nombre);
            nombre ++;
        }
        */

        //Pour
        /*
        for(int i=1; i<100; i++)
        {
            print("nombre i = " + i);

        }
        */

        //fait tant que , execute au moins une fois
        /*
        do{;
            print("nombre2 = " + nombre2);
            nombre2++;
        }while(nombre2 <=100);
        */

        //exo

        /*
        enfant de 3ans va a l'ecole jusqu'as 18ans,
        si il a le bac il va a la fac sinon redouble une fois.
        après 5 ans de fac il devient métier
        */
        int ageChild;
        for(ageChild = 3; ageChild<=17; ageChild++)
        {
            print("l'enfant à " + ageChild + "ans");
        }
        do{
            print("il passe son bac");
            int rdn = Random.Range(0, 2);
            ageChild++;
            if (rdn==1)
            {
                print("il rate son bac");
            } else
            {
                print("il a son bac");
                bac = true;
            }
        }while(!bac);
        for (int i=0; i<6; i++)
        {
            print("il va a la fac");
            ageChild++;
        }
        print("il trouve un metier à " +ageChild + "ans");
        



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
