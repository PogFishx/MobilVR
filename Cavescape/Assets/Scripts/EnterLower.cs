using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EnterLower {
    public class EnterLower : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
    	{
    		if (other.tag == "Player")
            {
                SceneManager.LoadScene(1);
    		}
    	}
    }
}
