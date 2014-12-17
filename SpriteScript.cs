using UnityEngine;
using System.Collections;

public class SpriteScript : MonoBehaviour
{
		
		/*本プロジェクトではパスワードを使う場所が３カ所ある。
パスワードは0-9まであり、それぞれタップすると次の数のspriteに変更される。
数字SpriteはSpriteScriptクラスで管理され、Sprite配列のimage変数に格納されている。
また、int型のidx変数を宣言し、数字の番号とリンクさせ、配列の番号を指定するのに扱う。
rendere.spriteで表示されているspriteにアクセスし、image[idx]番号になる様に数字spriteを変更させている*/


		//rendererのspriteにアクセスしたいので参照を宣言。
		SpriteRenderer renderer;
		public Sprite[] image;
		public int idx;
		public AudioClip kachi5;

		void Start ()
		{
				renderer = GetComponent<SpriteRenderer> ();
				//kachi5 = gameObject.GetComponent<AudioSource>();
		}
		
		void Update ()
		{
		}
		// 配列にはいった数字画像をタップで1ずつ変えてlengthまで行ったら0に戻る
	//関数OnClickはNGUIの関数
		void OnClick ()
		{
				//if(Input.GetKeyDown(KeyCode.Space)){
				audio.PlayOneShot (kachi5, 1F);
				renderer.sprite = image [idx];
				idx++;
				if (idx >= image.Length)
						idx = 0;
		}
}