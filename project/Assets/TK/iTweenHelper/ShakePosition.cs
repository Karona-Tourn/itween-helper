using UnityEngine;
using UnityEngine.Events;

namespace TK.iTweenHelper
{
	public class ShakePosition : iTweenJob<ShakePosition>
	{
		public Name name = null;
		public Property<Vector3> amount = null;
		public Property<bool> movetopath = null;
		public X x = null;
		public Y y = null;
		public Z z = null;
		public Property<bool> orienttopath = null;
		public Time time = null;
		public Delay delay = null;
		public Property<Transform, Vector3> looktarget = null;
		public Property<float, double> looktime = null;
		public Property<string> axis = null;
		public Property<bool> islocal = null;
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

		public ShakePosition ( GameObject target ) : base ( target, iTween.ShakePosition )
		{
			name = new Name ( this );
			amount = new Property<Vector3> ( "amount", this );
			movetopath = new Property<bool> ( "movetopath", this );
			x = new X ( this );
			y = new Y ( this );
			z = new Z ( this );
			orienttopath = new Property<bool> ( "orienttopath", this );
			time = new Time ( this );
			delay = new Delay ( this );
			looktarget = new Property<Transform, Vector3> ( "looktarget", this );
			looktime = new Property<float, double> ( "looktime", this );
			axis = new Property<string> ( "axis", this );
			islocal = new Property<bool> ( "islocal", this );
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
