using UnityEngine;
using System.Collections;

public class TimedSceneChange : MonoBehaviour {
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        Application.LoadLevel("MiniGame");
    }
}
