using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCar : MonoBehaviour
{
    [SerializeField] Renderer[] carParts;
    [SerializeField] Color[] colors;
    // Start is called before the first frame update
   
   public void Red()
   {
        for(int i=0; i<carParts.Length; i++ )
        {
            carParts[i].materials[0].color = colors[0];
        }
   }
   
   public void Green()
   {
        for(int i=0; i<carParts.Length; i++ )
        {
            carParts[i].materials[0].color = colors[1];
        }
   }

   public void Blue()
   {
        for(int i=0; i<carParts.Length; i++ )
        {
            carParts[i].materials[0].color = colors[2];
        }
   }

   public void Yellow()
   {
        for(int i=0; i<carParts.Length; i++ )
        {
            carParts[i].materials[0].color = colors[3];
        }
   }
}   
