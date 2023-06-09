
using UnityEngine;

public class ShopScript : MonoBehaviour
{

    /* takes care of the functions of the shop UI's buttons */
    public TowerPrefabAndCosts tower1;
    public TowerPrefabAndCosts tower2;
    public TowerPrefabAndCosts tower3;
    BuildManager buildManager;

    void Start(){
        buildManager = BuildManager.single;
    }

    /* on click of a selected button representing a tower*/
    public void SelectTower1(){
        Debug.Log("Tower1 Selected");
        //buildManager.SetTurretToBuild(tower1);
    }

    public void SelectTower2(){
        Debug.Log("Tower2 Selected");
        //buildManager.SetTurretToBuild(tower1);
    }

    public void SelectTower3(){
        Debug.Log("Tower3 Selected");
        //buildManager.SetTurretToBuild(tower1);
    }
    
}
