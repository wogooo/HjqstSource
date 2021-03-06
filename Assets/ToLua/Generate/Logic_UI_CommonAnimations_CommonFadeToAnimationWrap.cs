﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Logic_UI_CommonAnimations_CommonFadeToAnimationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Logic.UI.CommonAnimations.CommonFadeToAnimation), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Get", Get);
		L.RegFunction("init", init);
		L.RegFunction("setComplete", setComplete);
		L.RegFunction("startAction", startAction);
		L.RegFunction("OnUpdateFloat", OnUpdateFloat);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("time", get_time, set_time);
		L.RegVar("delay", get_delay, set_delay);
		L.RegVar("fromAlpha", get_fromAlpha, set_fromAlpha);
		L.RegVar("toAlpha", get_toAlpha, set_toAlpha);
		L.RegVar("onComplete", get_onComplete, set_onComplete);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			Logic.UI.CommonAnimations.CommonFadeToAnimation o = Logic.UI.CommonAnimations.CommonFadeToAnimation.Get(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)ToLua.CheckObject(L, 1, typeof(Logic.UI.CommonAnimations.CommonFadeToAnimation));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
			obj.init(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int setComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)ToLua.CheckObject(L, 1, typeof(Logic.UI.CommonAnimations.CommonFadeToAnimation));
			System.Action arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (System.Action)ToLua.CheckObject(L, 2, typeof(System.Action));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(System.Action), func) as System.Action;
			}

			obj.setComplete(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int startAction(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)ToLua.CheckObject(L, 1, typeof(Logic.UI.CommonAnimations.CommonFadeToAnimation));
			obj.startAction();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdateFloat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)ToLua.CheckObject(L, 1, typeof(Logic.UI.CommonAnimations.CommonFadeToAnimation));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.OnUpdateFloat(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_time(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			float ret = obj.time;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index time on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_delay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			float ret = obj.delay;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index delay on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fromAlpha(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			float ret = obj.fromAlpha;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index fromAlpha on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_toAlpha(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			float ret = obj.toAlpha;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index toAlpha on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onComplete(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			System.Action ret = obj.onComplete;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onComplete on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_time(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.time = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index time on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_delay(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.delay = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index delay on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fromAlpha(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.fromAlpha = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index fromAlpha on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_toAlpha(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.toAlpha = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index toAlpha on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onComplete(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.UI.CommonAnimations.CommonFadeToAnimation obj = (Logic.UI.CommonAnimations.CommonFadeToAnimation)o;
			System.Action arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (System.Action)ToLua.CheckObject(L, 2, typeof(System.Action));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(System.Action), func) as System.Action;
			}

			obj.onComplete = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onComplete on a nil value" : e.Message);
		}
	}
}

