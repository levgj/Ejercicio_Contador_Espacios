using UnityEngine;

public class SpaceCount : MonoBehaviour

{
    public int spacePressedCount = 0;
    float Timer = 0.0f; 
    bool isPlaying = false; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //este script indica las acciones al presionar el espacio
        if(Input.GetKeyDown("space"))
        {
            spacePressedCount ++ ;
            Debug.Log("space has been pressed" + spacePressedCount + "times");
            
        }

        if(spacePressedCount > 0)
        {
            isPlaying = true;
        }

        if(isPlaying == true)
        {
            Timer = Timer++;
            Debug.Log("Timer");
        }

        if(Timer = 10.0f)
        {
            isPlaying = false;
        }

    }
}
