using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exit {
    public class Exit : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
    	{
    		if (other.tag == "Player")
            {
                Application.Quit();
                
                //This is for testing in the unity editor
                //UnityEditor.EditorApplication.isPlaying = false;
    		}
    	}
    }
}
