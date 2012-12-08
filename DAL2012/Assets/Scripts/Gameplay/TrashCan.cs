using UnityEngine;
using System.Collections;

public class TrashCan : MonoBehaviour {
	
	public tk2dAnimatedSprite trashAnimation;
	
	void findAnimations(Transform currentTransform)
	{
		foreach (Transform child in currentTransform)
		{
			
			if (child.gameObject.name == "anim_recycle")
				trashAnimation = (tk2dAnimatedSprite)child.gameObject.GetComponent(typeof(tk2dAnimatedSprite));
		
			findAnimations(child);
		}
	}
	
	// Use this for initialization
	void Start () 
	{
		findAnimations(transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void AnimateTrash()
	{
		trashAnimation.Play("emptying");	
		audio.Play();
	}
}
