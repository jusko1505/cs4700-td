using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager single;

    void Awake(){
        if(single != null){
            Debug.LogError("There is more than one BuildManager");
            return;
        }
        single = this;
    }

    public GameObject Tower1;
    public GameObject Tower2;

    private GameObject towerToBuild;

    public GameObject SetTowerToBuild(TowerPrefabAndCosts tower){
        towerToBuild = tower;
    }

    public bool allowedToBuild(){
        return towerToBuild != null;
    }


    public void BuildTowerOnTile(Tile tile){

        if(PlayerResources.Gold < towerToBuild.cost){
            Debug.Log ("Not enough gold to build");
            return;
        }
        PlayerResources.Gold -= towerToBuild;
        GameObject tower = (GameObject)Instantiate(towerToBuild.prefab, tile.GetBuildPosition, Quaternion.identity);
        tile.tower = tower;

        Debug.Log("Tower Built, Remaining Gold" + PlayerResources.Gold);
    }


    











    //public bool allowedToBuild {get { return towerToBuild != null } };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}