using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    //public = ouvert a unity et aux autres script
    public int nombre;

    //private = accessible seulement dans ce script
    private int nombre2;
    
    // est private par defaut
    int nombre3;

    public string chaine;

    // Start is called before the first frame update
    void Start()
    {
        nombre = 15;
        chaine = "une phrase dedans";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
