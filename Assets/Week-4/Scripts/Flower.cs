using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Flower : MonoBehaviour
    {
        public float rateOfNectar; //refresh rate for flower
        public SpriteRenderer spriteRenderer; //inst the Sprite renderer
        public bool haveNectar = false; //does the flower have nectar ready
        void Update()
        {
            spriteRenderer = GetComponent<SpriteRenderer>(); //getting sprite renderer componet
            
            if (rateOfNectar >= 0 && rateOfNectar < 2000) //nectar not ready
            {
                spriteRenderer.color = Color.red; 
                rateOfNectar ++;
            }
            if (rateOfNectar == 2000) //nectar ready
            {
                spriteRenderer.color = Color.green;
                haveNectar = true; 
                nectarReady();
            }
            
            
        }
        public bool nectarReady() //nectar ready to collect
        {
            if (haveNectar == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool nectarTakin() //nectar has been collected, flower has no more nectar
        {
            haveNectar = false;
            spriteRenderer.color = Color.red;
            rateOfNectar = 0;
            return true;
        }
    }


