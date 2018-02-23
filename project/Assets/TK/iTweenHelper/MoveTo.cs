using UnityEngine;
using UnityEngine.Events;

namespace TK.iTweenHelper
{
	public class MoveTo : iTweenJob<MoveTo>
	{
		public class Position : Property<Transform, Vector3>
		{
			public Position ( MoveTo tween ) : base ( "position", tween ) { }
		}

		public class Path : Property<Transform[], Vector3[]>
		{
			public Path ( MoveTo tween ) : base ( "path", tween ) { }
		}

		public Name name = null;
		public Position position = null;
		public Path path = null;
		public Property<bool> movetopath = null;
		public X x = null;
		public Y y = null;
		public Z z = null;
		public Property<bool> orienttopath = null;
		public Time time = null;
		public Delay delay = null;
		public Speed speed = null;
		public Property<Transform, Vector3> looktarget = null;
		public Property<float, double> looktime = null;
		public Property<float, double> lookahead = null;
		public Property<string> axis = null;
		public Property<bool> islocal = null;
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

		public MoveTo ( GameObject target ) : base ( target, iTween.MoveTo )
		{
			name = new Name ( this );
			position = new Position ( this );
			path = new Path ( this );
			movetopath = new Property<bool> ( "movetopath", this );
			x = new X ( this );
			y = new Y ( this );
			z = new Z ( this );
			orienttopath = new Property<bool> ( "orienttopath", this );
			time = new Time ( this );
			delay = new Delay ( this );
			speed = new Speed ( this );
			looktarget = new Property<Transform, Vector3> ( "looktarget", this );
			looktime = new Property<float, double> ( "looktime", this );
			lookahead = new Property<float, double> ( "lookahead", this );
			axis = new Property<string> ( "axis", this );
			islocal = new Property<bool> ( "islocal", this );
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
