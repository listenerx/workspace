using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cameracontrol : MonoBehaviour
{

		public List<GameObject> cameraList;
		public int CameraID;

		// Use this for initialization
		void Start ()
		{
				CameraChange (5);
				CameraID = 5;
				CameraChange (CameraID);
		}
	
		// Update is called once per frame
		void Update ()
		{
		}
		/*forでCameraIDとCameraNumberが同じになるまで回し
同じだった場合にCameraIDと同じ番号のCameraをアクティブ、それ以外をFalseにする。
たしかゲームを始める時に5番以外をFalseにするために作った記憶（うろ覚え）
そもそも最初に５番以外をFalseにしとけばメモリも使わないかもしれない
もしかしてandroid2.3系で動かないのは、カメラを全部アクティブにしてたせいカモ？*/
		public void CameraChange (int cameraNumber)
		{
				CameraID = cameraNumber;
				for (int i = 0; i < cameraList.Count; i++) {
						if (i == cameraNumber) {
								cameraList [i].SetActive (true);
						} else {
								cameraList [i].SetActive (false);
						}
				}
		}
		//cameraipponクラスのonclickで呼ばれ、引数にCheckcamera(GM)が指定される
		//cameraipponで今のカメラをfalse、移動先のカメラをtrueにしている
		//また、カメラが切り替わる度にsetintでセーブし
		//ゲームの再開時にカメラロードでcameraIDを取得している
		public void SetCameraID (GameObject cam)
		{
				CameraID = cameraList.IndexOf (cam);
				PlayerPrefs.SetInt ("CameraID", CameraID);
		}

		/*変数CameraIDが値を持っていれば
Getintで取得し、CameraChange関数の引数にIDの番号を渡してロードする
値が入っていなければ、５番のカメラ（初期カメラ）
を読み込む様に指定する*/
		public void LoadSceneCamera ()
		{
				if (PlayerPrefs.HasKey ("CameraID")) {
						CameraID = PlayerPrefs.GetInt ("CameraID");
						CameraChange (CameraID);
						Debug.Log (PlayerPrefs.GetInt ("CameraID"));
				} else {
						CameraChange (5);
						CameraID = 5;
						CameraChange (CameraID);
						PlayerPrefs.SetInt ("CameraID", CameraID);
						Debug.Log (PlayerPrefs.GetInt ("CameraID"));
				}
		}
		/*最初に読み込むカメラ(5)番を読むのに使う関数。
Startで呼ばれている*/
		public void InitSceneCamera ()
		{
				CameraChange (5);
				CameraID = 5;
				CameraChange (CameraID);
				PlayerPrefs.SetInt ("CameraID", CameraID);
				Debug.Log (PlayerPrefs.GetInt ("CameraID"));
		}
}
