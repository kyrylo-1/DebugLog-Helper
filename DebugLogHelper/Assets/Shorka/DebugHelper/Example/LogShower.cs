using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shorka
{
    public class LogShower : MonoBehaviour
    {
        
        void Start()
        {
            Debug.Log("This is " + "colored log".StrColored(DebugColors.blue));
            Debug.Log("This is " + "italics log".StrItalics());
            Debug.Log("This is " + "bold log".StrBold());
            Debug.Log("This is " + "bold & colored log".StrBold().StrColored(DebugColors.purple));
            Debug.Log("This is " + "sized log".StrSized(17));
        }        
    }
}