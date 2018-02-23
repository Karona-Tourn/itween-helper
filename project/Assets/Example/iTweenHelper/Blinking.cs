using UnityEngine;
using UnityEngine.UI;

public class Blinking : MonoBehaviour
{
	private Graphic graphic = null;

	// Use this for initialization
	void Start ()
	{
		graphic = GetComponent<Graphic> ();

		if ( graphic != null )
		{
			new TK.iTweenHelper.ValueTo ( gameObject )
				.from.Set ( 0.1f )
				.to.Set ( 1f )
				.time.Set ( 0.3f )
				.looptype.Set ( iTween.LoopType.pingPong )
				.onupdate.Set ( ( float a ) =>
				{
					Color color = graphic.color;
					color.a = a;
					graphic.color = color;
				} )
				.Prepare ()
				.Play ();
		}
	}
}
