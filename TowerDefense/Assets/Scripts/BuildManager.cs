using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;

    private GameObject turretToBuild;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager");
        }
        instance = this;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }


    public void SetTurretToBuild (GameObject turret)
    {
    	turretToBuild = turret;
    }
}
