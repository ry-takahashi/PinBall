using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour {

	// HingeJointコンポーネントを入れる
	private HingeJoint myHingeJoint;

	// 初期の傾き
	private float defaultAngle = 20;

	// 弾いた時の傾き
	private float flickAngle = -20;

	// Use this for initialization
	void Start () {
		// HingeJointコンポーネント取得
		this.myHingeJoint = GetComponent<HingeJoint>();

		// フリッパーの傾きを設定
		SetAngle( this.defaultAngle );
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.LeftArrow) &&
		   tag == "LeftFripperTag") {
			SetAngle (this.flickAngle);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow) &&
			tag == "RightFripperTag") {
			SetAngle (this.flickAngle);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow) &&
			tag == "LeftFripperTag") {
			SetAngle (this.defaultAngle);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow) &&
			tag == "RightFripperTag") {
			SetAngle (this.defaultAngle);
		}

		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				Debug.Log ("触ってるよ");
			}
		}




	}

	// フリッパーの傾きを設定
	public void SetAngle( float Angle ) {
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = Angle;
		this.myHingeJoint.spring = jointSpr;
	}

}
