﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Events_UnityEvent_UnityEngine_GameObjectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Events.UnityEvent<UnityEngine.GameObject>), typeof(UnityEngine.Events.UnityEventBase), "UnityEvent_UnityEngine_GameObject");
		L.RegFunction("AddListener", AddListener);
		L.RegFunction("RemoveListener", RemoveListener);
		L.RegFunction("Invoke", Invoke);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Events.UnityEvent<UnityEngine.GameObject> obj = (UnityEngine.Events.UnityEvent<UnityEngine.GameObject>)ToLua.CheckObject(L, 1, typeof(UnityEngine.Events.UnityEvent<UnityEngine.GameObject>));
			UnityEngine.Events.UnityAction<UnityEngine.GameObject> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UnityEngine.GameObject>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UnityEngine.GameObject>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.GameObject>), func) as UnityEngine.Events.UnityAction<UnityEngine.GameObject>;
			}

			obj.AddListener(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Events.UnityEvent<UnityEngine.GameObject> obj = (UnityEngine.Events.UnityEvent<UnityEngine.GameObject>)ToLua.CheckObject(L, 1, typeof(UnityEngine.Events.UnityEvent<UnityEngine.GameObject>));
			UnityEngine.Events.UnityAction<UnityEngine.GameObject> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UnityEngine.GameObject>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UnityEngine.GameObject>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.GameObject>), func) as UnityEngine.Events.UnityAction<UnityEngine.GameObject>;
			}

			obj.RemoveListener(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Invoke(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Events.UnityEvent<UnityEngine.GameObject> obj = (UnityEngine.Events.UnityEvent<UnityEngine.GameObject>)ToLua.CheckObject(L, 1, typeof(UnityEngine.Events.UnityEvent<UnityEngine.GameObject>));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.Invoke(arg0);
			return 0;
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
}

