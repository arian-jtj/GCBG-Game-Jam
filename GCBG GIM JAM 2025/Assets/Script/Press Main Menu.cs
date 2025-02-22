using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SomeScript: MonoBehaviour {

void Update(){
if(Input.GetKeyDown(KeyCode.Escape)){
SceneManager.LoadScene("Main Menu");
}
}
}