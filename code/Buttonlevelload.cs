using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonlevelload : MonoBehaviour
{
    public string mLevelToLoad;


    public void LoadLevel()
    {
        //load the new level (mLevelLoad)
        SceneManager.LoadScene(mLevelToLoad);
    }
}
