using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject[] food;

    public void openPizza()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].gameObject.SetActive(false);
        }
        food[0].gameObject.SetActive(true);
    }

    public void openFrenchFries() 
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].gameObject.SetActive(false);
        }
        food[1].gameObject.SetActive(true);
    }
}



// {
//     public GameObject pizza;
//     public GameObject french_fries;

//     public void openPizza()
//     {
//         pizza.gameObject.SetActive(true);
//         french_fries.gameObject.SetActive(false);
//     }

//     public void openFrenchFries()
//     {
//         french_fries.gameObject.SetActive(true);
//         pizza.gameObject.SetActive(false);
//     }
// }
