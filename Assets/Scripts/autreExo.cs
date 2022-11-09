using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autreExo : MonoBehaviour
{
    /* Tableau */
    //initialise un tableau avec 5 element;
    public int[] monTableau = new int[5];
    //initialise un tableau avec les elements prérempli
    public int[] monTableau1 = new int[]{12,15,15,61};
    public string[] tableau_string = new string[]{"hello", "motto"};
    public int[] listeVerre = new int[]{58,1,42,23};
    //int empty = 0;

    public int[] tableauExo = new int[]{15,85,60,10};
    public int[] tableauExo1 = new int[]{6,4,5,1,9,7,8,4};
    public int[] tableauExo2 = new int[]{4,7,3,1,2,5,6,7};
    
    public int[] tableauExo3 = new int[8];
    int somme;

    public int[] tableauExo4 = new int[]{2,5,9,3,4,6,7,22};
    public int[] tableauExo5;
    public int nombreDePair = 0; 

    void Start()
    {
    /*
        #region afficher mes variables
        print("truc bidule");
        print(monTableau[0]);
        #endregion
        #region foreach
        foreach(int tableau in monTableau1)
        {
            print(tableau);
        }
        foreach(string mot in tableau_string)
        {
            print(mot);
        }
        //equivalence en for
        for(int i=0;i<monTableau1.Length;i++)
        {
            print(monTableau1[i]);
        }
        #endregion
        #region exo verre
    for(int y = 0; y < listeVerre.Length-1; y++)
    {

        for(int i = 0; i < listeVerre.Length -1; i++)
        {
            if(listeVerre[i]>listeVerre[i+1])
            {
                empty= listeVerre[i];
                listeVerre[i] = listeVerre[i+1];
                listeVerre[i+1] = empty;
            }
        }
    }
    foreach(int verre in listeVerre)
    {
        print(verre);
    }
    #endregion
        #region exo somme tableau
    for(int i=0; i< tableauExo.Length; i++)
    {
        somme += tableauExo[i];
    }
    print("Somme du tableau : " + somme);
    #endregion
        #region exo somme tableau + tableau
        for(int i = 0; i < tableauExo1.Length ; i++)
        {
            tableauExo3[i] = tableauExo1[i] + tableauExo2[i];
        }
        foreach(int sommeTable in tableauExo3)
        {
            print("Somme: " + sommeTable);
        }
        #endregion
        #region exo tableau pair
        for(int i=0; i<tableauExo4.Length; i++)
        {
            if(tableauExo4[i] % 2 == 0)
            {
                nombreDePair++;
            }
        }
        int[] tableauExo6 = new int[nombreDePair];
        int y = 0;
        for(int i=0; i<tableauExo4.Length; i++)
        {
            if(tableauExo4[i] % 2 == 0)
            {
                tableauExo6[y] = tableauExo4[i];
                print("table " + y + "= " + tableauExo6[y]);
                y++;
                
            }
        }
        #endregion
    */

    #region exp mediane
    int[] tableauAMediane = new int[]{8,1,6,19,94,35,2};
    int[] tableauAMediane2 = new int[]{95,67,29,61,1,3,6};
    int intermediaire;
    int tableSize;
// range tableau 1
    for(int y = 0; y < tableauAMediane.Length; y++)
    {
        for(int i = 0; i < tableauAMediane.Length-1; i++)
        {
            if(tableauAMediane[i]>tableauAMediane[i+1])
            {
                intermediaire = tableauAMediane[i];
                tableauAMediane[i] = tableauAMediane[i+1];
                tableauAMediane[i+1] = intermediaire;
            }
        }
    }
    tableSize = tableauAMediane.Length / 2;
    if(tableSize % 2 != 0)



    #endregion

    }

    void Update()
    {
        
    }
}
