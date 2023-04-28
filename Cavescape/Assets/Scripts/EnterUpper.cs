using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EnterUpper {
    public class EnterUpper : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
    	{
    		if (other.tag == "Exit")
            {
                SceneManager.LoadScene(2);
    		}
    	}
    }
}
