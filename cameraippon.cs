using UnityEngine;
using System.Collections;

public class cameraippon : MonoBehaviour {


	/*今移しているカメラnowCameraと、移動先のカメラcheckCameraを宣言する。
これ自体は矢印や移動したい所に設定し、onclickでカメラを切り替える。
また、カメラをセーブしたいので、SetCameraID関数を呼び、移動先のカメラを引数に指定する。*/
	public GameObject checkCamera;
	public GameObject nowCamera;

	void Start () {
		//cameraBn1 = (GameObject)GameObject.Find("cameraBn1"); 
		//cameraBn3 = (GameObject)GameObject.Find("cameraBn3"); 
	}
	void Update () {
	}
	void OnClick() {
		//if(checkCamera.activeInHierarchy){
		GameObject.FindGameObjectWithTag("CameraList").GetComponent<cameracontrol>().SetCameraID (checkCamera);
			nowCamera.SetActive (false);
			checkCamera.SetActive (true);
		}
}