using UnityEngine;
using System.Collections;

public class SS_Script : MonoBehaviour {
	public bool mouseOverSS = false; 
	private float blinkTrig = 0; 
	Animator animator;

	void Start () {
		animator = GetComponent<Animator>();
	}
		
	void OnMouseEnter(){ 
		mouseOverSS = true;
		animator.SetTrigger ("PointerEnter");
	}

	void OnMouseExit(){ 
		mouseOverSS = false;
		animator.SetTrigger ("PointerExit");
	}


	void Update(){
	
		blinkTrig = Random.value; 

		if (blinkTrig >= 0.98) {
			animator.SetTrigger ("BlinkTrigger");
		} else {}
	}
}

