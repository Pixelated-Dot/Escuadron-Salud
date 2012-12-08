using UnityEngine;
using System.Collections;

public class GameItem : MonoBehaviour {
	
	public GameObject sceneStateContainer;
	
	SceneState sceneState;
	
	// Use this for initialization
	void Start () {
		
		sceneState = (SceneState)sceneStateContainer.GetComponent(typeof(SceneState));
	
		sceneState.increasePendinItems();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void DestroyItem()
	{
		sceneState.decreasePendingItems();
	}
}
