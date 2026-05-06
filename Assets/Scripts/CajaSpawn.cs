using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CajaSpawn : MonoBehaviour
{
  int randomNumber;
public float StartValue;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
   
   
   
   
 }

void LocateBoxAtRandomPosition()
{
    Vector3 currentPosition = transform.position;
    float newX = 0f;
    randomNumber = Random.Range (0,3);
    if(randomNumber == 0){
        newX= -2;   
    }else if (randomNumber == 1){
        newX= 0;
    }else if(randomNumber == 2){
        newX = 2;
  
    }

    
currentPosition.x = newX;
transform.position = currentPosition;


}




}
