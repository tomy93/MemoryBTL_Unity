using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMessageSetter : MonoBehaviour {
    [SerializeField] private Text lblMessage;

    public void SetMessage(string s) {
        lblMessage.text = "Lo lograste en " + s + " segundos";
    }
}
