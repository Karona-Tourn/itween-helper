using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using UnityEngine;

namespace TK.iTweenHelper
{
	public class iTweenJob<T> where T : iTweenJob<T>
	{
		public delegate void Act ( GameObject target, Hashtable args );
		private Act act = null;
		private GameObject target = null;
		private Hashtable hash = null;

		public iTweenJob ( GameObject target, Act act )
		{
			this.act = act;
			this.target = target;
		}

		public T Prepare ()
		{
			hash = iTween.Hash ();
			var type = this.GetType ();
			var fields = type.GetFields (BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
			for ( int i = fields.Length - 1; i >= 0; i-- )
			{
				var field = fields[i];
				if ( typeof ( IProperty ).IsAssignableFrom ( field.FieldType ) )
				{
					var method = field.FieldType.GetMethod ("Get", BindingFlags.Public | BindingFlags.Instance);
					var fieldObj = field.GetValue (this);
					var value = method.Invoke (fieldObj, null);
					if ( value == null ) { continue; }
					var name = field.FieldType.GetField ("name", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue (fieldObj);
					if ( hash.ContainsKey ( name ) )
					{
						hash[name] = value;
					}
					else
					{
						hash.Add ( name, value );
					}
				}
			}
			return (T)this;
		}

		public void StopTheSameType ()
		{
			iTween.Stop ( target, act.Method.Name );
		}

		public void StopByName ()
		{
			if ( hash == null ) { return; }
			if ( !hash.ContainsKey ( "name" ) ) { return; }
			iTween.StopByName ( target, hash["name"].ToString () );
		}

		public void Play ()
		{
			if ( hash == null ) { return; }

			act ( target, hash );
		}

		public interface IProperty
		{
			object Get ();
		}

		public class Property<ValueType> : IProperty
		{
			private T tween = null;
			public readonly string name = "";
			private object value = null;

			public Property ( string name, T tween )
			{
				this.name = name;
				this.tween = tween;
			}

			public object Get ()
			{
				return value;
			}

			protected T SetRaw ( object value )
			{
				this.value = value;
				return tween;
			}

			public T Set ( ValueType value )
			{
				return SetRaw ( value );
			}
		}

		public class Property<ValueType1, ValueType2> : Property<ValueType1>, IProperty
		{
			public Property ( string name, T tween ) : base ( name, tween )
			{
			}

			public T Set ( ValueType2 value )
			{
				return SetRaw ( value );
			}
		}

		public class Property<ValueType1, ValueType2, ValueType3> : Property<ValueType1, ValueType2>, IProperty
		{
			public Property ( string name, T tween ) : base ( name, tween )
			{
			}

			public T Set ( ValueType3 value )
			{
				return SetRaw ( value );
			}
		}

		public class Property<ValueType1, ValueType2, ValueType3, ValueType4> : Property<ValueType1, ValueType2, ValueType3>, IProperty
		{
			public Property ( string name, T tween ) : base ( name, tween )
			{
			}

			public T Set ( ValueType4 value )
			{
				return SetRaw ( value );
			}
		}

		public class Property<ValueType1, ValueType2, ValueType3, ValueType4, ValueType5> : Property<ValueType1, ValueType2, ValueType3, ValueType4>, IProperty
		{
			public Property ( string name, T tween ) : base ( name, tween )
			{
			}

			public T Set ( ValueType5 value )
			{
				return SetRaw ( value );
			}
		}

		public class Property<ValueType1, ValueType2, ValueType3, ValueType4, ValueType5, ValueType6> : Property<ValueType1, ValueType2, ValueType3, ValueType4, ValueType5>, IProperty
		{
			public Property ( string name, T tween ) : base ( name, tween )
			{
			}

			public T Set ( ValueType6 value )
			{
				return SetRaw ( value );
			}
		}

		public class Property<ValueType1, ValueType2, ValueType3, ValueType4, ValueType5, ValueType6, ValueType7> : Property<ValueType1, ValueType2, ValueType3, ValueType4, ValueType5, ValueType6>, IProperty
		{
			public Property ( string name, T tween ) : base ( name, tween )
			{
			}

			public T Set ( ValueType7 value )
			{
				return SetRaw ( value );
			}
		}

		public class Property<ValueType1, ValueType2, ValueType3, ValueType4, ValueType5, ValueType6, ValueType7, ValueType8> : Property<ValueType1, ValueType2, ValueType3, ValueType4, ValueType5, ValueType6, ValueType7>, IProperty
		{
			public Property ( string name, T tween ) : base ( name, tween )
			{
			}

			public T Set ( ValueType8 value )
			{
				return SetRaw ( value );
			}
		}

		public class Name : Property<string>
		{
			public Name ( T tween ) : base ( "name", tween ) { }
		}

		public class Time : Property<float, double>
		{
			public Time ( T tween ) : base ( "time", tween ) { }
		}

		public class Speed : Property<float, double>
		{
			public Speed ( T tween ) : base ( "speed", tween ) { }
		}

		public class Delay : Property<float, double>
		{
			public Delay ( T tween ) : base ( "delay", tween ) { }
		}

		public class X : Property<float, double>
		{
			public X ( T tween ) : base ( "x", tween ) { }
		}

		public class Y : Property<float, double>
		{
			public Y ( T tween ) : base ( "y", tween ) { }
		}

		public class Z : Property<float, double>
		{
			public Z ( T tween ) : base ( "z", tween ) { }
		}

		public class IgnoreTimeScale : Property<bool>
		{
			public IgnoreTimeScale ( T tween ) : base ( "ignoretimescale", tween ) { }
		}

		public class LoopType : Property<string, iTween.LoopType>
		{
			public LoopType ( T tween ) : base ( "looptype", tween ) { }
		}

		public class EaseType : Property<string, iTween.EaseType>
		{
			public EaseType ( T tween ) : base ( "easetype", tween ) { }
		}
	}
}
