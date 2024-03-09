using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hive : MonoBehaviour
    {
        public float honeyProduction; //time for honey production
        public float honeyCount; //how much honey
        public float nectarCount; // how much nector
        public int numOfBees = 3; //number of bees
       // [SerializeField] Transform hive;
        [SerializeField] GameObject Bee;

        private void Update()
        {
            
            if (nectarCount == 0) //checking if there is nectar
            {
                honeyProduction = 0;
            }
            else if (honeyProduction >= 3)
            {
                nectarCount--;
                honeyCount++;
                honeyProduction = 0;
            }
            honeyProduction += Time.deltaTime;
        }
        public void Start()
        {
            for (int i = 0; i < numOfBees; i++)
            {
                var bee = Instantiate(Bee, gameObject.transform.position , Quaternion.identity); // makes a new bee
                bee.GetComponent<Bee>().Init(this); // assigns this hive instance to the new bee
            }
        }

        public void GiveNectar() // adds nectar to the hive and triggers update
        {
            nectarCount++;
            Update();
        }
    }
