using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeInfoText : MonoBehaviour
{
    public TextMeshProUGUI info;

    public void changetxt(TextMeshProUGUI reference)
    {
        info.text = reference.text;
    }
}
