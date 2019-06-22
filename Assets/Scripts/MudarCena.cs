using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCena : MonoBehaviour {

    public void ChangeToScene(string scene)
    {
        Application.LoadLevel(scene);
    }
}
