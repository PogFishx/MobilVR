using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Gems {
	public class CollectGems : MonoBehaviour {

		public TMP_Text DisplayGemsCollected;

		public static int GemsCollected;

		public GameObject HatchClosed;
		public GameObject HatchOpen;

		void OnTriggerEnter(Collider other)
		{
			if (other.tag == "Chest") {
				Collect ();
			}
			if (other.tag == "FakeChest") {
				Destroy(gameObject);
			}
		}

		public void Collect()
		{
			GemsCollected++;
			DisplayGemsCollected.text = GemsCollected.ToString()+"/10";
			if (GemsCollected > 9)
			{
				HatchClosed.SetActive(false);
				HatchOpen.SetActive(true);
			}
			Destroy(gameObject);
		}
	}
}
