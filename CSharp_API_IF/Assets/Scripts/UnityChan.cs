using System.Security.Permissions;
using UnityEngine;

public class Unity_Chan : MonoBehaviour
{
 
   private void Walk()
    {
        bool key = Input.GetKey(KeyCode.W);

        ani.Setbool ("走路開關", key);
    }

   private void Update()
    {
        Walk();
    }
}
