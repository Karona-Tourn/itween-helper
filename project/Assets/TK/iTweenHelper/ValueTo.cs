using UnityEngine;
using UnityEngine.Events;

namespace TK.iTweenHelper
{
	public class ValueTo : iTweenJob<ValueTo>
	{
		public class From : Property<float, double, Vector2, Vector3, Color, Rect>
		{
			public From ( ValueTo tween ) : base ( "from", tween ) { }
		}

		public class To : Property<float, double, Vector2, Vector3, Color, Rect>
		{
			public To ( ValueTo tween ) : base ( "to", tween ) { }
		}

		public class OnStartTarget : Property<GameObject>
		{
			public OnStartTarget ( ValueTo tween ) : base ( "onstarttarget", tween ) { }
		}

		public class OnStartParams : Property<object>
		{
			public OnStartParams ( ValueTo tween ) : base ( "onstartparams", tween ) { }
		}

		public class OnStart : Property<string, UnityAction<float>, UnityAction<double>, UnityAction<Vector2>, UnityAction<Vector3>, UnityAction<Rect>, UnityAction<Color>>
		{
			public OnStart ( ValueTo tween ) : base ( "onstart", tween ) { }
		}

		public class OnUpdateTarget : Property<GameObject>
		{
			public OnUpdateTarget ( ValueTo tween ) : base ( "onupdatetarget", tween ) { }
		}

		public class OnUpdateParams : Property<object>
		{
			public OnUpdateParams ( ValueTo tween ) : base ( "onupdateparams", tween ) { }
		}

		public class OnUpdate : Property<string, UnityAction<float>, UnityAction<double>, UnityAction<Vector2>, UnityAction<Vector3>, UnityAction<Rect>, UnityAction<Color>>
		{
			public OnUpdate ( ValueTo tween ) : base ( "onupdate", tween ) { }
		}

		public class OnCompleteTarget : Property<GameObject>
		{
			public OnCompleteTarget ( ValueTo tween ) : base ( "oncompletetarget", tween ) { }
		}

		public class OnCompleteParams : Property<object>
		{
			public OnCompleteParams ( ValueTo tween ) : base ( "oncompleteparams", tween ) { }
		}

		public class OnComplete : Property<string, UnityAction, UnityAction<float>, UnityAction<double>, UnityAction<Vector2>, UnityAction<Vector3>, UnityAction<Rect>, UnityAction<Color>>
		{
			public OnComplete ( ValueTo tween ) : base ( "oncomplete", tween ) { }
		}

		public Name name = null;
		public From from = null;
		public To to = null;
		public Time time = null;
		public Delay delay = null;
		public Speed speed = null;
		public EaseType easetype = null;
		public LoopType looptype = null;
		public OnStartTarget onstarttarget = null;
		public OnStartParams onstartparams = null;
		public OnStart onstart = null;
		public OnUpdateTarget onupdatetarget = null;
		public OnUpdateParams onupdateparams = null;
		public OnUpdate onupdate = null;
		public OnCompleteTarget oncompletetarget = null;
		public OnCompleteParams oncompleteparams = null;
		public OnComplete oncomplete = null;
		public IgnoreTimeScale ignoretimescale = null;

		public ValueTo ( GameObject target ) : base ( target, iTween.ValueTo )
		{
			name = new Name ( this );
			from = new From ( this );
			to = new To ( this );
			time = new Time ( this );
			delay = new Delay ( this );
			speed = new Speed ( this );
			onstarttarget = new OnStartTarget ( this );
			onstartparams = new OnStartParams ( this );
			onstart = new OnStart ( this );
			onupdatetarget = new OnUpdateTarget ( this );
			onupdateparams = new OnUpdateParams ( this );
			onupdate = new OnUpdate ( this );
			oncompletetarget = new OnCompleteTarget ( this );
			oncompleteparams = new OnCompleteParams ( this );
			oncomplete = new OnComplete ( this );
			easetype = new EaseType ( this );
			looptype = new LoopType ( this );
			ignoretimescale = new IgnoreTimeScale ( this );
		}
	}
}
