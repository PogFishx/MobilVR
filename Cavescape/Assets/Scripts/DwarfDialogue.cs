using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Dwarf {
    public class DwarfDialogue : MonoBehaviour
    {
        public GameObject DwarfText;
        public GameObject text1;
        public GameObject text2;
        
        void OnTriggerEnter(Collider other)
		{
			if (other.tag == "Player") {
                DwarfText.SetActive(true);
                Invoke("TextChange", 10);
			}
		}
        void TextChange()
        {
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }
}
