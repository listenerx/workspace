using UnityEngine;
using System.Collections;

public class cameraippon : MonoBehaviour {
	// 今のカメラnowCamera、移動先のカメラcheckCamera
	public GameObject checkCamera;
	public GameObject nowCamera;
	
	// Use this for initialization
	void Start () {
		// やりまぁす
	}
	
	// Update is called once per frame
	void Update () {
		// やりまぁす
	}

	void OnClick () {
		// カメラをセーブ
		GameObject.FindGameObjectWithTag("CameraList").GetComponent<cameracontrol>().SetCameraID (checkCamera);
		
		// カメラを切り替える。
		nowCamera.SetActive (false);
		checkCamera.SetActive (true);
	}
}