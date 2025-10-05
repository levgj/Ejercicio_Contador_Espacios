using UnityEngine;

public class SpaceCount : MonoBehaviour

{
    int spacePressedCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            spacePressedCount ++ ;
            Debug.Log("space has been pressed" + spacePressedCount + "times");
            
        }
    }
}
