using UnityEngine;
using UnityEngine.Events;

namespace TK.iTweenHelper
{
	public class ColorFrom : iTweenJob<ColorFrom>
	{
		public Name name = null;
		public Property<Color> color = null;
		public Property<float, double> r = null;
		public Property<float, double> g = null;
		public Property<float, double> b = null;
		public Property<iTween.NamedValueColor, string> NamedValueColor = null;
		public Property<bool> includechildren = null;
		public Time time = null;
		public Delay delay = null;
		public EaseType easetype = null;
		public LoopType looptype = null;
		public Property<GameObject> onstarttarget = null;
		public Property<object> onstartparams = null;
		public Property<string, UnityAction, UnityAction<object>, UnityAction<Color>> onstart = null;
		public Property<GameObject> onupdatetarget = null;
		public Property<object> onupdateparams = null;
		public Property<string, UnityAction, UnityAction<object>, UnityAction<Color>> onupdate = null;
		public Property<GameObject> oncompletetarget = null;
		public Property<object> oncompleteparams = null;
		public Property<string, UnityAction, UnityAction<object>, UnityAction<Color>> oncomplete = null;
		public IgnoreTimeScale ignoretimescale = null;

		public ColorFrom ( GameObject target ) : base ( target, iTween.ColorFrom )
		{
			name = new Name ( this );
			color = new Property<Color> ( "color", this );
			r = new Property<float, double> ( "r", this );
			g = new Property<float, double> ( "g", this );
			b = new Property<float, double> ( "b", this );
			includechildren = new Property<bool> ( "includechildren", this );
			time = new Time ( this );
			delay = new Delay ( this );
			easetype = new EaseType ( this );
			looptype = new LoopType ( this );
			onstarttarget = new Property<GameObject> ( "onstarttarget", this );
			onstartparams = new Property<object> ( "onstartparams", this );
			onstart = new Property<string, UnityAction, UnityAction<object>, UnityAction<Color>> ( "onstart", this );
			onupdatetarget = new Property<GameObject> ( "onupdatetarget", this );
			onupdateparams = new Property<object> ( "onupdateparams", this );
			onupdate = new Property<string, UnityAction, UnityAction<object>, UnityAction<Color>> ( "onupdate", this );
			oncompletetarget = new Property<GameObject> ( "oncompletetarget", this );
			oncompleteparams = new Property<object> ( "oncompleteparams", this );
			oncomplete = new Property<string, UnityAction, UnityAction<object>, UnityAction<Color>> ( "oncomplete", this );
			ignoretimescale = new IgnoreTimeScale ( this );
		}
	}
}
