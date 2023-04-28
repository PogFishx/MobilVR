using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lantern {
    public class LightLantern : MonoBehaviour {
        
        public Light light;
        public ParticleSystem ps;

        // Update is called once per frame
        void OnTriggerEnter(Collider other)
    	{
    		if (other.tag == "Torch")
            {
    			light.enabled = true;
                ps.enableEmission = true;
    		}
    	}
    }
}