using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor; // allows the unity editor .isPlaying to be turned off
#endif



public class GameManager : MonoBehaviour {
    private static GameManager instance = new GameManager();

    private UIManager uiManager;
    //private ConfigManager configManager;
<<<<<<< HEAD:Assets/scripts/Sim/GameManager.cs
    private ROSManager rosManager;
=======
    //private ROSManager rosManager;
>>>>>>> d84dba77ee1f1a3b09ba5decfd2e16b04f2bb67e:Assets/Scripts/GameManager.cs

    public static GameManager getInstance()
    {
        return instance;
    }

    // Use this for initialization
    void Start () {
        ConfigManager.getInstance();
    }
	
	// Update is called once per frame
	void Update () {
        ROSManager.getInstance().ROSRender();
        
	}

    public ROSManager getROSManager() {
        return ROSManager.getInstance();
    }

    public ConfigManager getConfigManager()
    {
        return ConfigManager.getInstance();
    }

    public void Quit()
    {
<<<<<<< HEAD:Assets/scripts/Sim/GameManager.cs

=======
>>>>>>> d84dba77ee1f1a3b09ba5decfd2e16b04f2bb67e:Assets/Scripts/GameManager.cs
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false; // in editor turn off play mode
        #else
        Application.Quit();// if an application then quit
        #endif
<<<<<<< HEAD:Assets/scripts/Sim/GameManager.cs

=======
>>>>>>> d84dba77ee1f1a3b09ba5decfd2e16b04f2bb67e:Assets/Scripts/GameManager.cs
    }


}
