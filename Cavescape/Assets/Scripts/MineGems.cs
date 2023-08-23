using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gems {
    public class MineGems : MonoBehaviour {
    
    	public AudioSource audioSource;
    
        public int GemsMined;
    
        public GameObject Gem1;
        public GameObject Gem1fake;
        public GameObject Gem2;
        public GameObject Gem2fake;
        public GameObject Gem3;
        public GameObject Gem3fake;
        public GameObject Gem4;
        public GameObject Gem4fake;
        public GameObject Gem5;
        public GameObject Gem5fake;
        public GameObject Gem6;
        public GameObject Gem6fake;
    
    	void OnTriggerEnter(Collider other)
    	{
    		if (other.tag == "Pickaxe") {
    			Mine();
    		}
    	}

        void MineSound()
        {
            audioSource.Play();
            //AudioSource.PlayClipAtPoint(MineSoundEffect, transform.position);
        }
    
    	public void Mine()
    	{
            if(GemsMined==0)
            {
                Gem1.SetActive(true);
                Destroy(Gem1fake);
                MineSound();
            }
            if(GemsMined==1)
            {
                Gem2.SetActive(true);
                Destroy(Gem2fake);
                MineSound();
            }
            if(GemsMined==2)
            {
                Gem3.SetActive(true);
                Destroy(Gem3fake);
                MineSound();
            }
            if(GemsMined==3)
            {
                Gem4.SetActive(true);
                Destroy(Gem4fake);
                MineSound();
            }
            if(GemsMined==4)
            {
                Gem5.SetActive(true);
                Destroy(Gem5fake);
                MineSound();
            }
            if(GemsMined==5)
            {
                Gem6.SetActive(true);
                Destroy(Gem6fake);
                MineSound();
            }
    		GemsMined++;
    	}
    }
}