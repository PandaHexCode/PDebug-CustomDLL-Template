using System;
using UnityEngine;

namespace PDebugCustomDLLTemplate{

    /*PDebug CutomDLL Template for building a DLL that contains a Unity MonoBehaviour,
    * so that PDebug can add Custom Behaviours to an GameObject.
    */
    /*If you want to use Functions or Types from your target Game just
    * add the "Assembly-CSharp.dll" to your References (Dependencies - > Add Project Reference).
    */

    public class CustomBehaviour : MonoBehaviour{

        private void Start(){
            Debug.Log("CustomDLL was initialized!");
        }

        private void Update(){
        }

        private void OnGUI(){/*For easily writing custom gui*/
        }

    }

}
