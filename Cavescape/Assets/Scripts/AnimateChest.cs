using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animation {
    public class AnimateChest : MonoBehaviour
    {
        public Animator chestAnimator;
        bool open = false;
    
        // Update is called once per frame
        public void Open()
        {
            if(open==false)
            {
                chestAnimator.ResetTrigger("Close");
                chestAnimator.SetTrigger("Open");
            } 
            if(open==true)
            {
                chestAnimator.ResetTrigger("Open");
                chestAnimator.SetTrigger("Close");
            }
            open = !open;
        }
    }
}