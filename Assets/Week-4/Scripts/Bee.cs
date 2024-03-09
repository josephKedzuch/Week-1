using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bee : MonoBehaviour
    {
        private Hive Hive;
        private bool hasNectar;
        private bool isNectarReady;
        
        public void Init(Hive hive)
        {
            Hive = hive;
            CheckAnyFlower();
        }

        public void CheckAnyFlower()
        {
            Flower[] randflower = FindObjectsByType<Flower>(FindObjectsSortMode.None);  // find all available flowers
            
            System.Random rand = new System.Random();
            int a = rand.Next(0, 4);
            Flower flower = randflower[a];  // randomly select one of the available flowers to go to
            transform.DOMove(flower.transform.position, 1f).OnComplete(() =>
            {
                
                isNectarReady = flower.nectarReady();  // check to see if flower selected has nectar
                if (isNectarReady)
                {
                    hasNectar = flower.nectarTakin();  // take flower's nectar
                    transform.DOMove(Hive.transform.position, 1f).OnComplete(() =>
                    {
                        Hive.GiveNectar(); // gives nectar to the hive
                        hasNectar = false;
                        CheckAnyFlower(); // look for new flower
                    }).SetEase(Ease.Linear);
                }
                else
                {
                    CheckAnyFlower(); // look for new flower
                }
                
                
            }).SetEase(Ease.Linear);
        }
        
    }
