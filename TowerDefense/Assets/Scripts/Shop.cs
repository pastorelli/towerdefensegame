using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBluePrint stadardTurret;
    public TurretBluePrint missileLauncher;
    public TurretBluePrint laserBeamer;

	BuildManager buildManager;

	void Start()
	{
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret()
	{
        buildManager.SelectTurretToBuild(stadardTurret);
	}

	public void SelectMissileLauncher()
	{
        buildManager.SelectTurretToBuild(missileLauncher);
    }

	public void SelectLaserBeamer()
	{
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
