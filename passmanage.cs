using UnityEngine;
using System.Collections;

public class passmanage : MonoBehaviour
{

		/*本プロジェクトではパスワードを使う場所が３カ所ある。
パスワードは0-9まであり、それぞれタップすると次の数のspriteになっている。
数字SpriteはSpriteScriptクラスで管理され、Sprite配列のimage変数に格納されている。
また、int型のidx変数を宣言し、数字の番号とリンクさせ、配列の番号を指定するのに扱う。
rendere.spriteで表示されているspriteにアクセスし、image[idx]番号になる様に数字spriteを変更させている*/

		public GameObject pass1;
		public GameObject pass2;
		public GameObject pass3;
		public GameObject redpass1;
		public GameObject redpass2;
		public GameObject redpass3;
		public GameObject passA;
		public GameObject passB;
		public GameObject passC;
		public GameObject passD;
		public const int PASS_ANSWER1 = 7;
		public const int PASS_ANSWER2 = 7;
		public const int PASS_ANSWER3 = 2;
		public const int RpassAnswer1 = 1;
		public const int RpassAnswer2 = 8;
		public const int RpassAnswer3 = 6;
		public const int Apass = 2;
		public const int Bpass = 4;
		public const int Cpass = 5;
		public const int Dpass = 3;
		public bool passFlag;
		public bool Rpassflag;
		public bool Apassflag;
		public GameObject passparent;
		public GameObject f72;
		public GameObject stopsuruyokun;
		public GameObject hutatoru;
		public GameObject f170;
		public GameObject redhutatoru;
		public GameObject az4toaz5;
		public AudioClip kacha;
		public bool Rpassderuyoflag;
		public bool Apassderuyoflag;
		//public menuitemkanrikun utib;

		// Use this for initialization
		void Start ()
		{
				//pass1 =(GameObject)GameObject.Find("f67a"); 
				//pass2 =(GameObject)GameObject.Find("f67b"); 
				//pass3 =(GameObject)GameObject.Find("f67c"); 
				passFlag = false;
				Rpassflag = false;
				stopsuruyokun.SetActive (false);
				hutatoru.SetActive (false);
		}

		void Update ()
		{
				//pass answerとidxの番号が同じならパスワードを解除する
				if (!passFlag) {
						if (pass1.GetComponent<SpriteScript> ().idx == PASS_ANSWER1) {
								if (pass2.GetComponent<SpriteScript> ().idx == PASS_ANSWER2) {
										if (pass3.GetComponent<SpriteScript> ().idx == PASS_ANSWER3) {
												stopsuruyokun.SetActive (true);
												StartCoroutine (Example ());
												passFlag = true;
												//utib.barlfragkun = true;
										}
								}
						}
				}
				if (!Rpassflag) {
						if (Rpassderuyoflag) {
								if (redpass1.GetComponent<SpriteScript> ().idx == RpassAnswer1) {
										if (redpass2.GetComponent<SpriteScript> ().idx == RpassAnswer2) {
												if (redpass3.GetComponent<SpriteScript> ().idx == RpassAnswer3) {
														stopsuruyokun.SetActive (true);
														StartCoroutine (ExampleR ());
														Rpassflag = true;
														Rpassderuyoflag = false;
												}
										}
								}
						}
				}
				if (!Apassflag) {
						//if(Apassderuyoflag){
						if (passA.GetComponent<SpriteScript> ().idx == Apass) {
								if (passB.GetComponent<SpriteScript> ().idx == Bpass) {
										if (passC.GetComponent<SpriteScript> ().idx == Cpass) {
												if (passD.GetComponent<SpriteScript> ().idx == Dpass) {
														stopsuruyokun.SetActive (true);
														StartCoroutine (ExampleX ());
														Apassflag = true;
														//Apassderuyoflag = false;
														//}
												}
										}
								}
						}
				}
		}
		//パスワードを解除したらstopsuruyokunをアクティブにし、一定時間タップ不可にする。
		IEnumerator Example ()
		{
				yield return new WaitForSeconds (1);
				stopsuruyokun.SetActive (false);
				f72.SetActive (false);
				hutatoru.SetActive (true);
				audio.PlayOneShot (kacha, 0.8F);
		}
		//パスワードを解除したらstopsuruyokunをアクティブにし、一定時間タップ不可にする。
		IEnumerator ExampleR ()
		{
				yield return new WaitForSeconds (1);
				stopsuruyokun.SetActive (false);
				f170.SetActive (false);
				redhutatoru.SetActive (true);
				audio.PlayOneShot (kacha, 0.8F);
		}
		//パスワードを解除したらstopsuruyokunをアクティブにし、一定時間タップ不可にする。
		IEnumerator ExampleX ()
		{
				yield return new WaitForSeconds (1);
				stopsuruyokun.SetActive (false);
				passparent.SetActive (false);
				az4toaz5.SetActive (true);
				audio.PlayOneShot (kacha, 0.8F);
		}
}