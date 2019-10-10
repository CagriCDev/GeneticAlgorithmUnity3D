using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text generationCount;
    public Text succesText;
    public GameObject getterObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PopulationController.count > 0)
        {
            generationCount.text = "Generation = " + PopulationController.count.ToString();
        }
        //  generationCount.text = 

        if (PopulationController.count > 0)
        {
            succesText.text = "Genetic Algorithm learned gen  = " + Triggered.succesGens.ToString();
        }

   
}
}