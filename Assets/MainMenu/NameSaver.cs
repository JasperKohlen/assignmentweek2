using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameSaver : MonoBehaviour
{
    public InputField input;
    // Start is called before the first frame update

    public static string PlayerName;
    public void ChangeName()
    {
        PlayerName = input.text;
    }
}
