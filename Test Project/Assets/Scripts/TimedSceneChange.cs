using UnityEngine;
using System.Collections;

public class TimedSceneChange : MonoBehaviour {
    IEnumerator Start()
    {
        yield return new WaitForSeconds(6f);
        Application.LoadLevel("MiniGame");
    }
}
