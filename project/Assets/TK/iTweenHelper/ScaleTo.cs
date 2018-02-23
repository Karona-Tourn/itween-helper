using UnityEngine;
using UnityEngine.Events;

namespace TK.iTweenHelper
{
	public class ScaleTo : iTweenJob<ScaleTo>
	{
		public Name name = null;
		public Property<Transform, Vector3> scale = null;
		public X x = null;
		public Y y = null;
		public Z z = null;
		public Time time = null;
		public Delay delay = null;
		public Speed speed = null;
		public EaseType easetype = null;
		public LoopType looptype = null;
		public Property<GameObject> onstarttarget = null;
		public Property<object> onstartparams = null;
		public Property<string, UnityAction, UnityAction<object>> onstart = null;
		public Property<GameObject> onupdatetarget = null;
		public Property<object> onupdateparams = null;
		public Property<string, UnityAction, UnityAction<object>> onupdate = null;
		public Property<GameObject> oncompletetarget = null;
		public Property<object> oncompleteparams = null;
		public Property<string, UnityAction, UnityAction<object>> oncomplete = null;
		public IgnoreTimeScale ignoretimescale = null;

		public ScaleTo ( GameObject target ) : base ( target, iTween.ScaleTo )
		{
			name = new Name ( this );
			scale = new Property<Transform, Vector3> ( "scale", this );
			x = new X ( this );
			y = new Y ( this );
			z = new Z ( this );
			time = new Time ( this );
			delay = new Delay ( this );
			speed = new Speed ( this );
			easetype = new EaseType ( this );
			looptype = new LoopType ( this );
			onstarttarget = new Property<GameObject> ( "onstarttarget", this );
			onstartparams = new Property<object> ( "onstartparams", this );
			onstart = new Property<string, UnityAction, UnityAction<object>> ( "onstart", this );
			onupdatetarget = new Property<GameObject> ( "onupdatetarget", this );
			onupdateparams = new Property<object> ( "onupdateparams", this );
			onupdate = new Property<string, UnityAction, UnityAction<object>> ( "onupdate", this );
			oncompletetarget = new Property<GameObject> ( "oncompletetarget", this );
			oncompleteparams = new Property<object> ( "oncompleteparams", this );
			oncomplete = new Property<string, UnityAction, UnityAction<object>> ( "oncomplete", this );
			ignoretimescale = new IgnoreTimeScale ( this );
		}
	}
}
