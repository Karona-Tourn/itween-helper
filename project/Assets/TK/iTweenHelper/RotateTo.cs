using UnityEngine;
using UnityEngine.Events;

namespace TK.iTweenHelper
{
	public class RotateTo : iTweenJob<RotateTo>
	{
		public Name name = null;
		public Property<Transform, Vector3> rotation = null;
		public X x = null;
		public Y y = null;
		public Z z = null;
		public Property<bool> islocal = null;
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

		public RotateTo ( GameObject target ) : base ( target, iTween.RotateTo )
		{
			name = new Name ( this );
			rotation = new Property<Transform, Vector3> ( "rotation", this );
			x = new X ( this );
			y = new Y ( this );
			z = new Z ( this );
			islocal = new Property<bool> ( "islocal", this );
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
