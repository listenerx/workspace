using UnityEngine;
using System.Collections;

public class SpriteScript : MonoBehaviour {		
	// 本プロジェクトではパスワードを使う場所が３カ所ある。
	// パスワードは0-9まであり、それぞれタップすると次の数のspriteに変更される。
	// 数字SpriteはSpriteScriptクラスで管理され、Sprite配列のimage変数に格納されている。
	// また、int型のidx変数を宣言し、数字の番号とリンクさせ、配列の番号を指定するのに扱う。
	// rendere.spriteで表示されているspriteにアクセスし、image[idx]番号になる様に数字spriteを変更させている
	

	// rendererのspriteにアクセスしたいので参照を宣言。
	SpriteRenderer renderer;
	public Sprite[] image;
	public int idx;
	public AudioClip kachi5;
	
	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		// やりまぁす
	}
	
	// 配列にはいった数字画像をタップで1ずつ変えてlengthまで行ったら0に戻る
	// 関数OnClickはNGUIの関数
	void OnClick () {
		audio.PlayOneShot (kachi5, 1F);
		renderer.sprite = image [idx++];
		if (idx >= image.Length) idx = 0;
	}
}